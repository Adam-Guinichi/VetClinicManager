using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class ConsultationForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";
        private int animalId;
        private int vetId;

        private List<(int id, string name, int qty)> addedMedicines = new List<(int, string, int)>();

        public ConsultationForm(int animalId, int vetId)
        {
            InitializeComponent();
            this.animalId = animalId;
            this.vetId = vetId;
            LoadMedicaments();
        }

        private void LoadMedicaments()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id_Medicament, Nom, Unite, QuantiteStock FROM Medicament WHERE QuantiteStock > 0 ORDER BY Nom";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbMedicament.DataSource = dt;
                    cmbMedicament.DisplayMember = "Nom";
                    cmbMedicament.ValueMember = "Id_Medicament";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement médicaments : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAjouterMedicament_Click(object sender, EventArgs e)
        {
            if (cmbMedicament.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un médicament.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idMed = (int)cmbMedicament.SelectedValue;
            string medName = cmbMedicament.Text;
            int qty = (int)numQuantite.Value;

            if (qty <= 0)
            {
                MessageBox.Show("La quantité doit être supérieure à 0.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView row = (DataRowView)cmbMedicament.SelectedItem;
            int stock = Convert.ToInt32(row["QuantiteStock"]);
            if (qty > stock)
            {
                MessageBox.Show($"Stock insuffisant. Disponible : {stock} {row["Unite"]}", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            addedMedicines.Add((idMed, medName, qty));
            lstMedicaments.Items.Add($"{medName} - {qty} unité(s)");

            cmbMedicament.SelectedIndex = -1;
            numQuantite.Value = 1;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string diagnostic = txtDiagnostic.Text.Trim();
            string traitement = txtTraitement.Text.Trim();
            string remarques = txtRemarques.Text.Trim();

            if (string.IsNullOrEmpty(diagnostic))
            {
                MessageBox.Show("Le diagnostic est obligatoire.", "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string insertConsult = @"INSERT INTO Consultation (DateHeure, Diagnostic, Traitement, Remarques, Id_Veterinaire, Id_Animal)
                                             VALUES (GETDATE(), @Diag, @Trait, @Rem, @VetId, @AnimalId);
                                             SELECT SCOPE_IDENTITY();";
                    int newConsultId;
                    using (SqlCommand cmd = new SqlCommand(insertConsult, conn))
                    {
                        cmd.Parameters.AddWithValue("@Diag", diagnostic);
                        cmd.Parameters.AddWithValue("@Trait", string.IsNullOrEmpty(traitement) ? (object)DBNull.Value : traitement);
                        cmd.Parameters.AddWithValue("@Rem", string.IsNullOrEmpty(remarques) ? (object)DBNull.Value : remarques);
                        cmd.Parameters.AddWithValue("@VetId", vetId);
                        cmd.Parameters.AddWithValue("@AnimalId", animalId); 
                        newConsultId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    
                    foreach (var med in addedMedicines)
                    {
                        string insertMed = "INSERT INTO Consultation_Medicament (Id_Consultation, Id_Medicament, Quantite) VALUES (@ConsId, @MedId, @Qty)";
                        using (SqlCommand cmd = new SqlCommand(insertMed, conn))
                        {
                            cmd.Parameters.AddWithValue("@ConsId", newConsultId);
                            cmd.Parameters.AddWithValue("@MedId", med.id);
                            cmd.Parameters.AddWithValue("@Qty", med.qty);
                            cmd.ExecuteNonQuery();
                        }

                        string updateStock = "UPDATE Medicament SET QuantiteStock = QuantiteStock - @Qty WHERE Id_Medicament = @MedId";
                        using (SqlCommand cmd = new SqlCommand(updateStock, conn))
                        {
                            cmd.Parameters.AddWithValue("@Qty", med.qty);
                            cmd.Parameters.AddWithValue("@MedId", med.id);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Consultation enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
