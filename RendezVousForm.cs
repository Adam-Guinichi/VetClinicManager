using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class RendezVousForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";
        private int editingRdvId = -1;

        public RendezVousForm()
        {
            InitializeComponent();
            LoadAnimaux();
            LoadVeterinaires();
            LoadRendezVous();
        }

        private void LoadAnimaux()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id_Animal, Nom FROM Animal ORDER BY Nom";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbAnimal.DataSource = dt;
                    cmbAnimal.DisplayMember = "Nom";
                    cmbAnimal.ValueMember = "Id_Animal";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement animaux : {ex.Message}");
            }
        }

        private void LoadVeterinaires()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id_Utilisateur, Prenom + ' ' + Nom AS Veterinaire FROM Utilisateur WHERE Role = 'Veterinaire' ORDER BY Nom";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbVeterinaire.DataSource = dt;
                    cmbVeterinaire.DisplayMember = "Veterinaire";
                    cmbVeterinaire.ValueMember = "Id_Utilisateur";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement vétérinaires : {ex.Message}");
            }
        }

        private void LoadRendezVous()
        {
            DateTime selectedDate = dtpDate.Value.Date;
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
                                     WHERE CAST(r.DateHeure AS DATE) = @Date
                                     ORDER BY r.DateHeure";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
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
                MessageBox.Show($"Erreur chargement rendez-vous : {ex.Message}");
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadRendezVous();
            ClearForm();
        }

        private void dgvRendezVous_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRendezVous.CurrentRow != null)
            {
                editingRdvId = Convert.ToInt32(dgvRendezVous.CurrentRow.Cells["Id_RendezVous"].Value);
                
                string animalNom = dgvRendezVous.CurrentRow.Cells["Animal"].Value.ToString();
                foreach (DataRowView row in cmbAnimal.Items)
                {
                    if (row["Nom"].ToString() == animalNom)
                    {
                        cmbAnimal.SelectedItem = row;
                        break;
                    }
                }
                
                string vetNom = dgvRendezVous.CurrentRow.Cells["Veterinaire"].Value.ToString();
                foreach (DataRowView row in cmbVeterinaire.Items)
                {
                    if (row["Veterinaire"].ToString() == vetNom)
                    {
                        cmbVeterinaire.SelectedItem = row;
                        break;
                    }
                }
                dtpHeure.Value = Convert.ToDateTime(dgvRendezVous.CurrentRow.Cells["DateHeure"].Value);
                txtMotif.Text = dgvRendezVous.CurrentRow.Cells["Motif"].Value?.ToString();
                cmbStatut.Text = dgvRendezVous.CurrentRow.Cells["Statut"].Value?.ToString();
                btnAdd.Text = "Modifier";
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int? idAnimal = (int?)cmbAnimal.SelectedValue;
            int? idVet = (int?)cmbVeterinaire.SelectedValue;
            DateTime dateHeure = dtpDate.Value.Date + dtpHeure.Value.TimeOfDay;
            string motif = txtMotif.Text.Trim();
            string statut = cmbStatut.SelectedItem?.ToString();

            if (!idAnimal.HasValue || !idVet.HasValue)
            {
                MessageBox.Show("Veuillez sélectionner un animal et un vétérinaire.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (editingRdvId == -1) 
                    {
                        string insert = @"INSERT INTO RendezVous (DateHeure, Motif, Statut, Id_Animal, Id_Veterinaire)
                                          VALUES (@DateHeure, @Motif, @Statut, @IdAnimal, @IdVet)";
                        using (SqlCommand cmd = new SqlCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@DateHeure", dateHeure);
                            cmd.Parameters.AddWithValue("@Motif", string.IsNullOrEmpty(motif) ? (object)DBNull.Value : motif);
                            cmd.Parameters.AddWithValue("@Statut", statut ?? "Planifie");
                            cmd.Parameters.AddWithValue("@IdAnimal", idAnimal.Value);
                            cmd.Parameters.AddWithValue("@IdVet", idVet.Value);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Rendez-vous ajouté.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else 
                    {
                        string update = @"UPDATE RendezVous SET DateHeure=@DateHeure, Motif=@Motif, Statut=@Statut,
                                          Id_Animal=@IdAnimal, Id_Veterinaire=@IdVet
                                          WHERE Id_RendezVous=@Id";
                        using (SqlCommand cmd = new SqlCommand(update, conn))
                        {
                            cmd.Parameters.AddWithValue("@DateHeure", dateHeure);
                            cmd.Parameters.AddWithValue("@Motif", string.IsNullOrEmpty(motif) ? (object)DBNull.Value : motif);
                            cmd.Parameters.AddWithValue("@Statut", statut);
                            cmd.Parameters.AddWithValue("@IdAnimal", idAnimal.Value);
                            cmd.Parameters.AddWithValue("@IdVet", idVet.Value);
                            cmd.Parameters.AddWithValue("@Id", editingRdvId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Rendez-vous modifié.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                ClearForm();
                LoadRendezVous();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            
            
            if (dgvRendezVous.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un rendez-vous à modifier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            dgvRendezVous_SelectionChanged(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (editingRdvId == -1)
            {
                if (dgvRendezVous.CurrentRow == null) return;
                editingRdvId = Convert.ToInt32(dgvRendezVous.CurrentRow.Cells["Id_RendezVous"].Value);
            }
            if (MessageBox.Show("Supprimer ce rendez-vous ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string delete = "DELETE FROM RendezVous WHERE Id_RendezVous = @Id";
                        using (SqlCommand cmd = new SqlCommand(delete, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", editingRdvId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Rendez-vous supprimé.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                            LoadRendezVous();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            editingRdvId = -1;
            btnAdd.Text = "Ajouter";
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            cmbAnimal.SelectedIndex = -1;
            cmbVeterinaire.SelectedIndex = -1;
            dtpHeure.Value = DateTime.Now;
            txtMotif.Clear();
            cmbStatut.SelectedIndex = -1;
        }
    }
}
