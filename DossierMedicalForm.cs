using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class DossierMedicalForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";
        private int vetId;  

        public DossierMedicalForm(int vetId)
        {
            InitializeComponent();
            this.vetId = vetId;
            LoadProprietaires();
        }

        private void LoadProprietaires()
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
                    cmbProprietaire.DisplayMember = "Proprietaire";
                    cmbProprietaire.ValueMember = "Id_Proprietaire";
                    cmbProprietaire.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void cmbProprietaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? idProp = (int?)cmbProprietaire.SelectedValue;
            if (idProp.HasValue)
            {
                LoadAnimaux(idProp.Value);
            }
        }

        private void LoadAnimaux(int idProp)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id_Animal, Nom FROM Animal WHERE Id_Proprietaire = @Id ORDER BY Nom";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@Id", idProp);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbAnimal.DisplayMember = "Nom";
                    cmbAnimal.ValueMember = "Id_Animal";
                    cmbAnimal.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void cmbAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            var val = cmbAnimal.SelectedValue;
            if (val == null || val == DBNull.Value) return;
            int idAnimal = Convert.ToInt32(val);
            LoadConsultations(idAnimal);
            LoadVaccinations(idAnimal);
        }

        
        private void LoadConsultations(int idAnimal)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT c.DateHeure, u.Prenom + ' ' + u.Nom AS Veterinaire,
                                            c.Diagnostic, c.Traitement, c.Remarques
                                     FROM Consultation c
                                     LEFT JOIN Utilisateur u ON c.Id_Veterinaire = u.Id_Utilisateur
                                     WHERE c.Id_Animal = @IdAnimal
                                     ORDER BY c.DateHeure DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdAnimal", idAnimal);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvConsultations.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement consultations : {ex.Message}");
            }
        }

        private void LoadVaccinations(int idAnimal)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT Vaccin, DateAdministration, DateRappel, u.Prenom + ' ' + u.Nom AS Veterinaire
                                     FROM Vaccination v
                                     INNER JOIN Utilisateur u ON v.Id_Veterinaire = u.Id_Utilisateur
                                     WHERE v.Id_Animal = @IdAnimal
                                     ORDER BY DateAdministration DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdAnimal", idAnimal);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvVaccinations.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement vaccinations : {ex.Message}");
            }
        }

        private void btnAjouterConsultation_Click(object sender, EventArgs e)
        {
            int? idAnimal = (int?)cmbAnimal.SelectedValue;
            if (!idAnimal.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner un animal.", "Information");
                return;
            }
            ConsultationForm consultationForm = new ConsultationForm(idAnimal.Value, vetId);
            consultationForm.ShowDialog();
            
            LoadConsultations(idAnimal.Value);
        }
    }
}
