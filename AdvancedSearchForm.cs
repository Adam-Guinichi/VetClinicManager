using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class AdvancedSearchForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";

        public AdvancedSearchForm()
        {
            InitializeComponent();
            LoadAnimalSearch();
            LoadConsultationSearch();
            LoadFactureSearch();
        }

        private void LoadAnimalSearch()
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id_Proprietaire, Nom + ' ' + Prenom AS Proprietaire FROM Proprietaire ORDER BY Nom";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbProprietaireAnimal.DataSource = dt;
                    cmbProprietaireAnimal.DisplayMember = "Proprietaire";
                    cmbProprietaireAnimal.ValueMember = "Id_Proprietaire";
                    cmbProprietaireAnimal.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement propriétaires : {ex.Message}");
            }
        }

        private void LoadConsultationSearch()
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id_Utilisateur, Prenom + ' ' + Nom AS Vet FROM Utilisateur WHERE Role = 'Veterinaire' ORDER BY Nom";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbVetCons.DataSource = dt;
                    cmbVetCons.DisplayMember = "Vet";
                    cmbVetCons.ValueMember = "Id_Utilisateur";
                    cmbVetCons.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement vétérinaires : {ex.Message}");
            }
        }

        private void LoadFactureSearch()
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id_Proprietaire, Nom + ' ' + Prenom AS Proprietaire FROM Proprietaire ORDER BY Nom";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbProprietaireFacture.DataSource = dt;
                    cmbProprietaireFacture.DisplayMember = "Proprietaire";
                    cmbProprietaireFacture.ValueMember = "Id_Proprietaire";
                    cmbProprietaireFacture.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement propriétaires : {ex.Message}");
            }
        }

        private void btnSearchAnimal_Click(object sender, EventArgs e)
        {
            string nomAnimal = txtNomAnimal.Text.Trim();
            int? idProprietaire = cmbProprietaireAnimal.SelectedValue as int?;
            string espece = txtEspece.Text.Trim();

            string query = @"SELECT a.Id_Animal, a.Nom, a.Espece, a.Race, a.DateNaissance, a.Sexe,
                                    p.Nom + ' ' + p.Prenom AS Proprietaire, p.Telephone
                             FROM Animal a
                             INNER JOIN Proprietaire p ON a.Id_Proprietaire = p.Id_Proprietaire
                             WHERE 1=1";

            if (!string.IsNullOrEmpty(nomAnimal))
                query += " AND a.Nom LIKE @Nom";
            if (idProprietaire.HasValue)
                query += " AND a.Id_Proprietaire = @IdProp";
            if (!string.IsNullOrEmpty(espece))
                query += " AND a.Espece LIKE @Espece";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(nomAnimal))
                            cmd.Parameters.AddWithValue("@Nom", "%" + nomAnimal + "%");
                        if (idProprietaire.HasValue)
                            cmd.Parameters.AddWithValue("@IdProp", idProprietaire.Value);
                        if (!string.IsNullOrEmpty(espece))
                            cmd.Parameters.AddWithValue("@Espece", "%" + espece + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvAnimalResult.DataSource = dt;
                        dgvAnimalResult.Columns["Id_Animal"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur recherche animaux : {ex.Message}");
            }
        }

        private void btnSearchConsultation_Click(object sender, EventArgs e)
        {
            DateTime? start = chkDateCons.Checked ? dtpStartCons.Value : (DateTime?)null;
            DateTime? end = chkDateCons.Checked ? dtpEndCons.Value : (DateTime?)null;
            int? idVet = cmbVetCons.SelectedValue as int?;
            string diagnostic = txtDiagnostic.Text.Trim();

            string query = @"SELECT c.Id_Consultation, c.DateHeure, c.Diagnostic, c.Traitement,
                                    u.Prenom + ' ' + u.Nom AS Veterinaire,
                                    a.Nom AS Animal, p.Nom + ' ' + p.Prenom AS Proprietaire,
                                    f.MontantTotal, f.StatutPaiement
                             FROM Consultation c
                             LEFT JOIN Utilisateur u ON c.Id_Veterinaire = u.Id_Utilisateur
                             LEFT JOIN RendezVous r ON c.Id_RendezVous = r.Id_RendezVous
                             LEFT JOIN Animal a ON r.Id_Animal = a.Id_Animal
                             LEFT JOIN Proprietaire p ON a.Id_Proprietaire = p.Id_Proprietaire
                             LEFT JOIN Facture f ON c.Id_Consultation = f.Id_Consultation
                             WHERE 1=1";

            if (start.HasValue)
                query += " AND c.DateHeure >= @Start";
            if (end.HasValue)
                query += " AND c.DateHeure <= @End";
            if (idVet.HasValue)
                query += " AND c.Id_Veterinaire = @IdVet";
            if (!string.IsNullOrEmpty(diagnostic))
                query += " AND c.Diagnostic LIKE @Diagnostic";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (start.HasValue)
                            cmd.Parameters.AddWithValue("@Start", start.Value);
                        if (end.HasValue)
                            cmd.Parameters.AddWithValue("@End", end.Value);
                        if (idVet.HasValue)
                            cmd.Parameters.AddWithValue("@IdVet", idVet.Value);
                        if (!string.IsNullOrEmpty(diagnostic))
                            cmd.Parameters.AddWithValue("@Diagnostic", "%" + diagnostic + "%");

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvConsultationResult.DataSource = dt;
                        dgvConsultationResult.Columns["Id_Consultation"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur recherche consultations : {ex.Message}");
            }
        }

        private void btnSearchFacture_Click(object sender, EventArgs e)
        {
            DateTime? start = chkDateFacture.Checked ? dtpStartFacture.Value : (DateTime?)null;
            DateTime? end = chkDateFacture.Checked ? dtpEndFacture.Value : (DateTime?)null;
            int? idProp = cmbProprietaireFacture.SelectedValue as int?;
            string statut = cmbStatut.SelectedItem?.ToString();

            string query = @"SELECT f.Id_Facture, f.MontantTotal, f.DateEmission, f.StatutPaiement, f.ModePaiement,
                                    a.Nom AS Animal, p.Nom + ' ' + p.Prenom AS Proprietaire
                             FROM Facture f
                             INNER JOIN Consultation c ON f.Id_Consultation = c.Id_Consultation
                             LEFT JOIN RendezVous r ON c.Id_RendezVous = r.Id_RendezVous
                             LEFT JOIN Animal a ON r.Id_Animal = a.Id_Animal
                             LEFT JOIN Proprietaire p ON a.Id_Proprietaire = p.Id_Proprietaire
                             WHERE 1=1";

            if (start.HasValue)
                query += " AND f.DateEmission >= @Start";
            if (end.HasValue)
                query += " AND f.DateEmission <= @End";
            if (idProp.HasValue)
                query += " AND p.Id_Proprietaire = @IdProp";
            if (!string.IsNullOrEmpty(statut))
                query += " AND f.StatutPaiement = @Statut";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (start.HasValue)
                            cmd.Parameters.AddWithValue("@Start", start.Value);
                        if (end.HasValue)
                            cmd.Parameters.AddWithValue("@End", end.Value);
                        if (idProp.HasValue)
                            cmd.Parameters.AddWithValue("@IdProp", idProp.Value);
                        if (!string.IsNullOrEmpty(statut))
                            cmd.Parameters.AddWithValue("@Statut", statut);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvFactureResult.DataSource = dt;
                        dgvFactureResult.Columns["Id_Facture"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur recherche factures : {ex.Message}");
            }
        }

        private void chkDateCons_CheckedChanged(object sender, EventArgs e)
        {
            dtpStartCons.Enabled = chkDateCons.Checked;
            dtpEndCons.Enabled = chkDateCons.Checked;
        }

        private void chkDateFacture_CheckedChanged(object sender, EventArgs e)
        {
            dtpStartFacture.Enabled = chkDateFacture.Checked;
            dtpEndFacture.Enabled = chkDateFacture.Checked;
        }
    }
}
