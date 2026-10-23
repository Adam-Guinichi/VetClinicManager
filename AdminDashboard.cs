using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace projetVet
{
    public partial class AdminDashboard : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";

        private int userId;
        private string userName;
        private string userRole;

        

        public AdminDashboard(int userId, string userName, string userRole)
        {
            InitializeComponent();
            this.userId = userId;
            this.userName = userName;
            this.userRole = userRole;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;

            LoadStatistics();
            LoadAlerts();

            lblWelcome.Text = $"Bienvenue, {userName} (Administrateur)";
        }

        private void LoadStatistics()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string userQuery = "SELECT COUNT(*) FROM Utilisateur";
                    int userCount = (int)new SqlCommand(userQuery, conn).ExecuteScalar();
                    lblUserCount.Text = userCount.ToString();

                    
                    string propQuery = "SELECT COUNT(*) FROM Proprietaire";
                    int propCount = (int)new SqlCommand(propQuery, conn).ExecuteScalar();
                    lblProprietaireCount.Text = propCount.ToString();

                    
                    string animalQuery = "SELECT COUNT(*) FROM Animal";
                    int animalCount = (int)new SqlCommand(animalQuery, conn).ExecuteScalar();
                    lblAnimalCount.Text = animalCount.ToString();

                    
                    string medQuery = "SELECT COUNT(*) FROM Medicament";
                    int medCount = (int)new SqlCommand(medQuery, conn).ExecuteScalar();
                    lblMedicamentCount.Text = medCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des statistiques : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAlerts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string lowStockQuery = "SELECT COUNT(*) FROM Medicament WHERE QuantiteStock <= SeuilAlerte";
                    int lowStockCount = (int)new SqlCommand(lowStockQuery, conn).ExecuteScalar();
                    if (lowStockCount > 0)
                        lblLowStockAlert.Text = $"⚠️ {lowStockCount} médicament(s) en stock bas";
                    else
                        lblLowStockAlert.Text = "✅ Stock OK";

                    
                    string expiringQuery = "SELECT COUNT(*) FROM Medicament WHERE DateExpiration <= DATEADD(day, 30, GETDATE()) AND DateExpiration >= GETDATE()";
                    int expiringCount = (int)new SqlCommand(expiringQuery, conn).ExecuteScalar();
                    if (expiringCount > 0)
                        lblExpiringAlert.Text = $"⚠️ {expiringCount} médicament(s) expirent dans 30 jours";
                    else
                        lblExpiringAlert.Text = "✅ Aucune expiration imminente";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des alertes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGestionUtilisateurs_Click(object sender, EventArgs e)
        {
            UserManagementForm userForm = new UserManagementForm();
            userForm.ShowDialog();
            
            LoadStatistics();
        }

        private void btnStockMedicaments_Click(object sender, EventArgs e)
        {
            MedicamentManagement stockForm = new MedicamentManagement();
            stockForm.ShowDialog();
            LoadStatistics(); 
            LoadAlerts();     
        }

        private void btnTableauBord_Click(object sender, EventArgs e)
        {
            AdminStatsForm statsForm = new AdminStatsForm();
            statsForm.ShowDialog();
        }

        private void btnRechercheAvancee_Click(object sender, EventArgs e)
        {
            AdvancedSearchForm searchForm = new AdvancedSearchForm();
            searchForm.ShowDialog();
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }
    }
}
