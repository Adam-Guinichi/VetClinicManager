using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class SecretaryDashboard : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";

        private int userId;
        private string userName;
        private string userRole;

        public SecretaryDashboard(int userId, string userName, string userRole)
        {
            InitializeComponent();
            this.userId = userId;
            this.userName = userName;
            this.userRole = userRole;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            lblWelcome.Text = $"Bienvenue, {userName} (Secrétaire)";

            LoadStats();

            
            this.cardProprietaires.Paint += Card_PaintBorder;
            this.cardAnimaux.Paint += Card_PaintBorder;
            this.cardRdvToday.Paint += Card_PaintBorder;
            this.cardUnpaid.Paint += Card_PaintBorder;
        }

        private void Card_PaintBorder(object? sender, PaintEventArgs e)
        {
            if (sender is Control c)
            {
                using var pen = new System.Drawing.Pen(System.Drawing.Color.LightGray, 1);
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

                    
                    string propQuery = "SELECT COUNT(*) FROM Proprietaire";
                    int propCount = (int)new SqlCommand(propQuery, conn).ExecuteScalar();
                    lblProprietaireCount.Text = propCount.ToString();

                    
                    string animalQuery = "SELECT COUNT(*) FROM Animal";
                    int animalCount = (int)new SqlCommand(animalQuery, conn).ExecuteScalar();
                    lblAnimalCount.Text = animalCount.ToString();

                    
                    string rdvTodayQuery = "SELECT COUNT(*) FROM RendezVous WHERE CAST(DateHeure AS DATE) = CAST(GETDATE() AS DATE)";
                    int rdvTodayCount = (int)new SqlCommand(rdvTodayQuery, conn).ExecuteScalar();
                    lblRdvTodayCount.Text = rdvTodayCount.ToString();

                    
                    string unpaidQuery = "SELECT COUNT(*) FROM Facture WHERE StatutPaiement = 'Impaye'";
                    int unpaidCount = (int)new SqlCommand(unpaidQuery, conn).ExecuteScalar();
                    lblUnpaidCount.Text = unpaidCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des statistiques : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGestionProprietaires_Click(object sender, EventArgs e)
        {
            ProprietairesForm form = new ProprietairesForm();
            form.ShowDialog();
            LoadStats(); 
        }

        private void btnGestionAnimaux_Click(object sender, EventArgs e)
        {
            AnimauxForm form = new AnimauxForm();
            form.ShowDialog();
            LoadStats();
        }

        private void btnGestionRendezVous_Click(object sender, EventArgs e)
        {
            RendezVousForm form = new RendezVousForm();
            form.ShowDialog();
            LoadStats();
        }

        private void btnFacturation_Click(object sender, EventArgs e)
        {
            FacturesForm form = new FacturesForm();
            form.ShowDialog();
            LoadStats();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            MultiSearchForm form = new MultiSearchForm();
            form.ShowDialog();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
