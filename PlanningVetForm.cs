using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class PlanningVetForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";
        private int vetId;

        public PlanningVetForm(int vetId)
        {
            InitializeComponent();
            this.vetId = vetId;
            dtpDate.Value = DateTime.Today;
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            DateTime selectedDate = dtpDate.Value.Date;
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT r.Id_RendezVous, a.Nom AS Animal, p.Nom + ' ' + p.Prenom AS Proprietaire,
                                            r.DateHeure, r.Motif, r.Statut
                                     FROM RendezVous r
                                     INNER JOIN Animal a ON r.Id_Animal = a.Id_Animal
                                     INNER JOIN Proprietaire p ON a.Id_Proprietaire = p.Id_Proprietaire
                                     WHERE r.Id_Veterinaire = @VetId AND CAST(r.DateHeure AS DATE) = @Date
                                     ORDER BY r.DateHeure";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@VetId", vetId);
                        cmd.Parameters.AddWithValue("@Date", selectedDate);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvRendezVous.DataSource = dt;
                        dgvRendezVous.Columns["Id_RendezVous"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}");
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAppointments();
        }
    }
}
