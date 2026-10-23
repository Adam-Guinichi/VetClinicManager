using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class VeterinaireDashboard : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";
        private int userId;
        private string userName;
        private string userRole;

        public VeterinaireDashboard(int userId, string userName, string userRole)
        {
            InitializeComponent();
            this.userId = userId;
            this.userName = userName;
            this.userRole = userRole;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            lblWelcome.Text = $"Bienvenue Dr. {userName}";
            LoadStats();

            if (this.statsPanel != null)
                this.statsPanel.Paint += StatsPanel_Paint;
        }

        private void StatsPanel_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is Control c)
            {
                using var pen = new System.Drawing.Pen(System.Drawing.Color.LightGray);
                e.Graphics.DrawRectangle(pen, 0, 0, c.Width - 1, c.Height - 1);
            }
        }

        private void LoadStats()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM RendezVous WHERE Id_Veterinaire = @Id AND CAST(DateHeure AS DATE) = CAST(GETDATE() AS DATE)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", userId);
                        int count = (int)cmd.ExecuteScalar();
                        lblRdvTodayCount.Text = count.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement stats : {ex.Message}");
            }
        }

        private void btnPlanning_Click(object sender, EventArgs e)
        {
            PlanningVetForm planning = new PlanningVetForm(userId);
            planning.ShowDialog();
            LoadStats();
        }

        private void btnDossierMedical_Click(object sender, EventArgs e)
        {
            try
            {
                
                DossierMedicalForm dossier = new DossierMedicalForm(userId);
                dossier.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ouverture dossier médical : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGestionVaccins_Click(object sender, EventArgs e)
        {
            try
            {
                
                VaccinationForm vaccins = new VaccinationForm(userId);
                vaccins.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur ouverture gestion vaccins : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStockMedicaments_Click(object sender, EventArgs e)
        {
            MedicamentManagement stock = new MedicamentManagement(true);
            stock.ShowDialog();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
