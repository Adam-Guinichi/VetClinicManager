using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace projetVet
{
    public partial class AnimauxForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";
        private int editingAnimalId = -1;

        public AnimauxForm()
        {
            InitializeComponent();
            LoadProprietaires();
            LoadAnimaux();
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
                    cmbProprietaire.DataSource = dt;
                    cmbProprietaire.DisplayMember = "Proprietaire";
                    cmbProprietaire.ValueMember = "Id_Proprietaire";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur chargement propriétaires : {ex.Message}");
            }
        }

        private void LoadAnimaux(string searchTerm = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT a.Id_Animal, a.Nom, a.Espece, a.Race, a.DateNaissance, a.Sexe,
                                            p.Nom + ' ' + p.Prenom AS Proprietaire
                                     FROM Animal a
                                     INNER JOIN Proprietaire p ON a.Id_Proprietaire = p.Id_Proprietaire";
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += " WHERE a.Nom LIKE @Search OR a.Espece LIKE @Search OR a.Race LIKE @Search OR p.Nom LIKE @Search OR p.Prenom LIKE @Search";
                    }
                    query += " ORDER BY a.Nom";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");
                        }

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
                MessageBox.Show($"Erreur chargement animaux : {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadAnimaux(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadAnimaux();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAnimaux.CurrentRow == null) return;
            editingAnimalId = Convert.ToInt32(dgvAnimaux.CurrentRow.Cells["Id_Animal"].Value);
            txtNom.Text = dgvAnimaux.CurrentRow.Cells["Nom"].Value.ToString();
            txtEspece.Text = dgvAnimaux.CurrentRow.Cells["Espece"].Value?.ToString();
            txtRace.Text = dgvAnimaux.CurrentRow.Cells["Race"].Value?.ToString();
            dtpDateNaissance.Value = dgvAnimaux.CurrentRow.Cells["DateNaissance"].Value == DBNull.Value ? DateTime.Today : Convert.ToDateTime(dgvAnimaux.CurrentRow.Cells["DateNaissance"].Value);
            cmbSexe.SelectedItem = dgvAnimaux.CurrentRow.Cells["Sexe"].Value?.ToString();
            string proprietaire = dgvAnimaux.CurrentRow.Cells["Proprietaire"].Value.ToString();
            
            foreach (DataRowView row in cmbProprietaire.Items)
            {
                if (row["Proprietaire"].ToString() == proprietaire)
                {
                    cmbProprietaire.SelectedItem = row;
                    break;
                }
            }
            btnAdd.Text = "Modifier";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string espece = txtEspece.Text.Trim();
            string race = txtRace.Text.Trim();
            DateTime dateNaissance = dtpDateNaissance.Value;
            string sexe = cmbSexe.SelectedItem?.ToString();
            int? idProprietaire = (int?)cmbProprietaire.SelectedValue;

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(espece) || !idProprietaire.HasValue || string.IsNullOrEmpty(sexe))
            {
                MessageBox.Show("Nom, espèce, sexe et propriétaire sont obligatoires.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (editingAnimalId == -1) 
                    {
                        string insert = @"INSERT INTO Animal (Nom, Espece, Race, DateNaissance, Sexe, Id_Proprietaire)
                                          VALUES (@Nom, @Espece, @Race, @DateNaissance, @Sexe, @IdProp)";
                        using (SqlCommand cmd = new SqlCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nom", nom);
                            cmd.Parameters.AddWithValue("@Espece", espece);
                            cmd.Parameters.AddWithValue("@Race", string.IsNullOrEmpty(race) ? (object)DBNull.Value : race);
                            cmd.Parameters.AddWithValue("@DateNaissance", dateNaissance);
                            cmd.Parameters.AddWithValue("@Sexe", sexe);
                            cmd.Parameters.AddWithValue("@IdProp", idProprietaire.Value);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Animal ajouté.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else 
                    {
                        string update = @"UPDATE Animal SET Nom=@Nom, Espece=@Espece, Race=@Race, DateNaissance=@DateNaissance, Sexe=@Sexe, Id_Proprietaire=@IdProp
                                          WHERE Id_Animal=@Id";
                        using (SqlCommand cmd = new SqlCommand(update, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nom", nom);
                            cmd.Parameters.AddWithValue("@Espece", espece);
                            cmd.Parameters.AddWithValue("@Race", string.IsNullOrEmpty(race) ? (object)DBNull.Value : race);
                            cmd.Parameters.AddWithValue("@DateNaissance", dateNaissance);
                            cmd.Parameters.AddWithValue("@Sexe", sexe);
                            cmd.Parameters.AddWithValue("@IdProp", idProprietaire.Value);
                            cmd.Parameters.AddWithValue("@Id", editingAnimalId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Animal modifié.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                ResetForm();
                LoadAnimaux();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAnimaux.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvAnimaux.CurrentRow.Cells["Id_Animal"].Value);
            string nom = dgvAnimaux.CurrentRow.Cells["Nom"].Value.ToString();

            if (MessageBox.Show($"Supprimer l'animal '{nom}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string delete = "DELETE FROM Animal WHERE Id_Animal = @Id";
                        using (SqlCommand cmd = new SqlCommand(delete, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Animal supprimé.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetForm();
                            LoadAnimaux();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetForm()
        {
            editingAnimalId = -1;
            btnAdd.Text = "Ajouter";
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            txtNom.Clear();
            txtEspece.Clear();
            txtRace.Clear();
            dtpDateNaissance.Value = DateTime.Today;
            cmbSexe.SelectedIndex = -1;
            cmbProprietaire.SelectedIndex = -1;
        }
    }
}
