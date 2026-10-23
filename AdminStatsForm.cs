using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class AdminStatsForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";

        public AdminStatsForm()
        {
            InitializeComponent();
            dtpStart.Value = DateTime.Now.AddMonths(-1);
            dtpEnd.Value = DateTime.Now;
            LoadStats();
        }

        private void LoadStats()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string rdvQuery = "SELECT COUNT(*) FROM RendezVous WHERE DateHeure BETWEEN @Start AND @End";
                    using (SqlCommand cmd = new SqlCommand(rdvQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Start", dtpStart.Value);
                        cmd.Parameters.AddWithValue("@End", dtpEnd.Value);
                        int rdvCount = (int)cmd.ExecuteScalar();
                        lblRdvCount.Text = rdvCount.ToString();
                    }

                    
                    string consQuery = "SELECT COUNT(*) FROM Consultation WHERE DateHeure BETWEEN @Start AND @End";
                    using (SqlCommand cmd = new SqlCommand(consQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Start", dtpStart.Value);
                        cmd.Parameters.AddWithValue("@End", dtpEnd.Value);
                        int consCount = (int)cmd.ExecuteScalar();
                        lblConsCount.Text = consCount.ToString();
                    }

                    
                    string revenueQuery = "SELECT ISNULL(SUM(MontantTotal), 0) FROM Facture WHERE StatutPaiement = 'Paye' AND DateEmission BETWEEN @Start AND @End";
                    using (SqlCommand cmd = new SqlCommand(revenueQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Start", dtpStart.Value);
                        cmd.Parameters.AddWithValue("@End", dtpEnd.Value);
                        decimal revenue = (decimal)cmd.ExecuteScalar();
                        lblRevenue.Text = revenue.ToString("C");
                    }

                    
                    string recentQuery = @"SELECT TOP 10 c.Id_Consultation, c.DateHeure, 
                                                  a.Nom AS Animal, 
                                                  p.Nom + ' ' + p.Prenom AS Proprietaire, 
                                                  ISNULL(f.MontantTotal, 0) AS MontantTotal, 
                                                  ISNULL(f.StatutPaiement, 'Non facturé') AS StatutPaiement
                                           FROM Consultation c
                                           LEFT JOIN Animal a ON c.Id_Animal = a.Id_Animal
                                           LEFT JOIN Proprietaire p ON a.Id_Proprietaire = p.Id_Proprietaire
                                           LEFT JOIN Facture f ON c.Id_Consultation = f.Id_Consultation
                                           WHERE c.DateHeure BETWEEN @Start AND @End
                                           ORDER BY c.DateHeure DESC";
                    using (SqlCommand cmd = new SqlCommand(recentQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Start", dtpStart.Value);
                        cmd.Parameters.AddWithValue("@End", dtpEnd.Value);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvRecent.DataSource = dt;
                        dgvRecent.Columns["Id_Consultation"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des statistiques : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStats();
        }
    }
}
