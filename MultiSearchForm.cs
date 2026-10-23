using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class MultiSearchForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";

        public MultiSearchForm()
        {
            InitializeComponent();
        }

        private void btnSearchProprietaires_Click(object sender, EventArgs e)
        {
            string search = txtSearchProprietaires.Text.Trim();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT Id_Proprietaire, Nom, Prenom, Adresse, Telephone, Email
                                     FROM Proprietaire
                                     WHERE Nom LIKE @Search OR Prenom LIKE @Search OR Telephone LIKE @Search OR Email LIKE @Search
                                     ORDER BY Nom";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + search + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvProprietaires.DataSource = dt;
                        dgvProprietaires.Columns["Id_Proprietaire"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur recherche propriétaires : {ex.Message}");
            }
        }

        private void btnSearchAnimaux_Click(object sender, EventArgs e)
        {
            string search = txtSearchAnimaux.Text.Trim();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT a.Id_Animal, a.Nom, a.Espece, a.Race, a.DateNaissance, a.Sexe,
                                            p.Nom + ' ' + p.Prenom AS Proprietaire
                                     FROM Animal a
                                     INNER JOIN Proprietaire p ON a.Id_Proprietaire = p.Id_Proprietaire
                                     WHERE a.Nom LIKE @Search OR a.Espece LIKE @Search OR a.Race LIKE @Search 
                                        OR p.Nom LIKE @Search OR p.Prenom LIKE @Search
                                     ORDER BY a.Nom";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + search + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvAnimaux.DataSource = dt;
                        dgvAnimaux.Columns["Id_Animal"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur recherche animaux : {ex.Message}");
            }
        }

        private void btnSearchRendezVous_Click(object sender, EventArgs e)
        {
            string search = txtSearchRendezVous.Text.Trim();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT r.Id_RendezVous, a.Nom AS Animal, u.Prenom + ' ' + u.Nom AS Veterinaire,
                                            r.DateHeure, r.Motif, r.Statut
                                     FROM RendezVous r
                                     INNER JOIN Animal a ON r.Id_Animal = a.Id_Animal
                                     INNER JOIN Utilisateur u ON r.Id_Veterinaire = u.Id_Utilisateur
                                     WHERE a.Nom LIKE @Search OR u.Nom LIKE @Search OR u.Prenom LIKE @Search OR r.Motif LIKE @Search
                                     ORDER BY r.DateHeure DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + search + "%");
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
                MessageBox.Show($"Erreur recherche rendez-vous : {ex.Message}");
            }
        }

        private void btnSearchFactures_Click(object sender, EventArgs e)
        {
            string search = txtSearchFactures.Text.Trim();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT f.Id_Facture, f.MontantTotal, f.DateEmission, f.StatutPaiement, f.ModePaiement,
                                            a.Nom AS Animal, p.Nom + ' ' + p.Prenom AS Proprietaire,
                                            c.DateHeure AS DateConsultation
                                     FROM Facture f
                                     INNER JOIN Consultation c ON f.Id_Consultation = c.Id_Consultation
                                     LEFT JOIN RendezVous r ON c.Id_RendezVous = r.Id_RendezVous
                                     LEFT JOIN Animal a ON r.Id_Animal = a.Id_Animal
                                     LEFT JOIN Proprietaire p ON a.Id_Proprietaire = p.Id_Proprietaire
                                     WHERE a.Nom LIKE @Search OR p.Nom LIKE @Search OR p.Prenom LIKE @Search 
                                        OR f.StatutPaiement LIKE @Search
                                     ORDER BY f.DateEmission DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", "%" + search + "%");
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvFactures.DataSource = dt;
                        dgvFactures.Columns["Id_Facture"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur recherche factures : {ex.Message}");
            }
        }

        private void btnClearProprietaires_Click(object sender, EventArgs e)
        {
            txtSearchProprietaires.Clear();
            dgvProprietaires.DataSource = null;
        }

        private void btnClearAnimaux_Click(object sender, EventArgs e)
        {
            txtSearchAnimaux.Clear();
            dgvAnimaux.DataSource = null;
        }

        private void btnClearRendezVous_Click(object sender, EventArgs e)
        {
            txtSearchRendezVous.Clear();
            dgvRendezVous.DataSource = null;
        }

        private void btnClearFactures_Click(object sender, EventArgs e)
        {
            txtSearchFactures.Clear();
            dgvFactures.DataSource = null;
        }

        private void lblSearchAnimaux_Click(object sender, EventArgs e)
        {

        }

        private void lblSearchFactures_Click(object sender, EventArgs e)
        {

        }
    }
}
