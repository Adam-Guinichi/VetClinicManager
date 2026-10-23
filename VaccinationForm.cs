using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class VaccinationForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";
        private int vetId;

        public VaccinationForm(int vetId = 1)
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
                MessageBox.Show($"Erreur chargement propriétaires : {ex.Message}");
            }
        }

        private void cmbProprietaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            var val = cmbProprietaire.SelectedValue;
            if (val == null || val == DBNull.Value) return;
            int idProp = Convert.ToInt32(val);
            LoadAnimaux(idProp);
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
                MessageBox.Show($"Erreur chargement animaux : {ex.Message}");
            }
        }

        private void btnAjouterVaccin_Click(object sender, EventArgs e)
        {
            int? idAnimal = (int?)cmbAnimal.SelectedValue;
            string vaccin = txtVaccin.Text.Trim();
            DateTime dateAdmin = dtpDateAdmin.Value;
            DateTime dateRappel = dtpDateRappel.Value;

            if (!idAnimal.HasValue || string.IsNullOrEmpty(vaccin))
            {
                MessageBox.Show("Veuillez sélectionner un animal et saisir le vaccin.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insert = @"INSERT INTO Vaccination (Id_Animal, Id_Veterinaire, Vaccin, DateAdministration, DateRappel)
                                      VALUES (@IdAnimal, @VetId, @Vaccin, @DateAdmin, @DateRappel)";
                    using (SqlCommand cmd = new SqlCommand(insert, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdAnimal", idAnimal.Value);
                        cmd.Parameters.AddWithValue("@VetId", vetId);
                        cmd.Parameters.AddWithValue("@Vaccin", vaccin);
                        cmd.Parameters.AddWithValue("@DateAdmin", dateAdmin);
                        cmd.Parameters.AddWithValue("@DateRappel", dateRappel);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vaccination enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearForm()
        {
            cmbProprietaire.SelectedIndex = -1;
            cmbAnimal.DataSource = null;
            txtVaccin.Clear();
            dtpDateAdmin.Value = DateTime.Today;
            dtpDateRappel.Value = DateTime.Today.AddMonths(6);
        }
    }
}
