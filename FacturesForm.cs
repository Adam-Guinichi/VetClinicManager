using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class FacturesForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";

        public FacturesForm()
        {
            InitializeComponent();
            LoadFactures();
            LoadConsultationsSansFacture();
        }

        private void LoadFactures()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT f.Id_Facture, f.MontantTotal, f.DateEmission, f.StatutPaiement, f.ModePaiement,
                                            a.Nom AS Animal, 
                                            p.Nom + ' ' + p.Prenom AS Proprietaire,
                                            c.DateHeure AS DateConsultation
                                     FROM Facture f
                                     INNER JOIN Consultation c ON f.Id_Consultation = c.Id_Consultation
                                     LEFT JOIN Animal a ON c.Id_Animal = a.Id_Animal
                                     LEFT JOIN Proprietaire p ON a.Id_Proprietaire = p.Id_Proprietaire
                                     ORDER BY f.DateEmission DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvFactures.DataSource = dt;
                    dgvFactures.Columns["Id_Facture"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement factures : {ex.Message}");
            }
        }

        private void LoadConsultationsSansFacture()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT c.Id_Consultation, 
                                            a.Nom AS Animal, 
                                            p.Nom + ' ' + p.Prenom AS Proprietaire,
                                            c.DateHeure
                                     FROM Consultation c
                                     LEFT JOIN Animal a ON c.Id_Animal = a.Id_Animal
                                     LEFT JOIN Proprietaire p ON a.Id_Proprietaire = p.Id_Proprietaire
                                     WHERE NOT EXISTS (SELECT 1 FROM Facture f WHERE f.Id_Consultation = c.Id_Consultation)
                                     ORDER BY c.DateHeure DESC";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbConsultation.DataSource = dt;
                    cmbConsultation.DisplayMember = "Animal";
                    cmbConsultation.ValueMember = "Id_Consultation";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement consultations : {ex.Message}");
            }
        }

        private void btnGenererFacture_Click(object sender, EventArgs e)
        {
            int? idConsultation = (int?)cmbConsultation.SelectedValue;
            decimal montant = numMontant.Value;
            if (!idConsultation.HasValue || montant <= 0)
            {
                MessageBox.Show("Veuillez sélectionner une consultation et saisir un montant valide.", "Champs invalides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insert = @"INSERT INTO Facture (Id_Consultation, MontantTotal, DateEmission, StatutPaiement)
                                      VALUES (@IdConsultation, @Montant, GETDATE(), 'Impaye')";
                    using (SqlCommand cmd = new SqlCommand(insert, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdConsultation", idConsultation.Value);
                        cmd.Parameters.AddWithValue("@Montant", montant);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Facture générée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFactures();
                        LoadConsultationsSansFacture();
                        numMontant.Value = 0;
                        cmbConsultation.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la génération de la facture : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPayer_Click(object sender, EventArgs e)
        {
            if (dgvFactures.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une facture à payer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idFacture = Convert.ToInt32(dgvFactures.CurrentRow.Cells["Id_Facture"].Value);
            string modePaiement = txtModePaiement.Text.Trim();

            if (string.IsNullOrEmpty(modePaiement))
            {
                MessageBox.Show("Veuillez indiquer le mode de paiement (Espèces, Carte, etc.).", "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string update = @"UPDATE Facture SET StatutPaiement = 'Paye', ModePaiement = @Mode WHERE Id_Facture = @Id";
                    using (SqlCommand cmd = new SqlCommand(update, conn))
                    {
                        cmd.Parameters.AddWithValue("@Mode", modePaiement);
                        cmd.Parameters.AddWithValue("@Id", idFacture);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Paiement enregistré.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadFactures();
                        txtModePaiement.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement du paiement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
