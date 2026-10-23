using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class ProprietairesForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";
        private int editingProprietaireId = -1;

        public ProprietairesForm()
        {
            InitializeComponent();
            LoadProprietaires();
        }

        private void LoadProprietaires(string searchTerm = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id_Proprietaire, Nom, Prenom, Adresse, Telephone, Email FROM Proprietaire";
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += " WHERE Nom LIKE @Search OR Prenom LIKE @Search OR Telephone LIKE @Search OR Email LIKE @Search";
                    }
                    query += " ORDER BY Nom, Prenom";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");
                        }

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
                MessageBox.Show($"Erreur chargement propriétaires : {ex.Message}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadProprietaires(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadProprietaires();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProprietaires.CurrentRow == null) return;
            editingProprietaireId = Convert.ToInt32(dgvProprietaires.CurrentRow.Cells["Id_Proprietaire"].Value);
            txtNom.Text = dgvProprietaires.CurrentRow.Cells["Nom"].Value.ToString();
            txtPrenom.Text = dgvProprietaires.CurrentRow.Cells["Prenom"].Value.ToString();
            txtAdresse.Text = dgvProprietaires.CurrentRow.Cells["Adresse"].Value?.ToString();
            txtTelephone.Text = dgvProprietaires.CurrentRow.Cells["Telephone"].Value?.ToString();
            txtEmail.Text = dgvProprietaires.CurrentRow.Cells["Email"].Value?.ToString();
            btnAdd.Text = "Modifier";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string adresse = txtAdresse.Text.Trim();
            string telephone = txtTelephone.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom))
            {
                MessageBox.Show("Nom et prénom sont obligatoires.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (editingProprietaireId == -1) 
                    {
                        string insert = @"INSERT INTO Proprietaire (Nom, Prenom, Adresse, Telephone, Email, DateInscription)
                                          VALUES (@Nom, @Prenom, @Adresse, @Telephone, @Email, GETDATE())";
                        using (SqlCommand cmd = new SqlCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nom", nom);
                            cmd.Parameters.AddWithValue("@Prenom", prenom);
                            cmd.Parameters.AddWithValue("@Adresse", string.IsNullOrEmpty(adresse) ? (object)DBNull.Value : adresse);
                            cmd.Parameters.AddWithValue("@Telephone", string.IsNullOrEmpty(telephone) ? (object)DBNull.Value : telephone);
                            cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Propriétaire ajouté.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else 
                    {
                        string update = @"UPDATE Proprietaire SET Nom=@Nom, Prenom=@Prenom, Adresse=@Adresse, Telephone=@Telephone, Email=@Email
                                          WHERE Id_Proprietaire=@Id";
                        using (SqlCommand cmd = new SqlCommand(update, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nom", nom);
                            cmd.Parameters.AddWithValue("@Prenom", prenom);
                            cmd.Parameters.AddWithValue("@Adresse", string.IsNullOrEmpty(adresse) ? (object)DBNull.Value : adresse);
                            cmd.Parameters.AddWithValue("@Telephone", string.IsNullOrEmpty(telephone) ? (object)DBNull.Value : telephone);
                            cmd.Parameters.AddWithValue("@Email", string.IsNullOrEmpty(email) ? (object)DBNull.Value : email);
                            cmd.Parameters.AddWithValue("@Id", editingProprietaireId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Propriétaire modifié.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                ResetForm();
                LoadProprietaires();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProprietaires.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvProprietaires.CurrentRow.Cells["Id_Proprietaire"].Value);
            string nom = dgvProprietaires.CurrentRow.Cells["Nom"].Value.ToString();
            string prenom = dgvProprietaires.CurrentRow.Cells["Prenom"].Value.ToString();

            if (MessageBox.Show($"Supprimer le propriétaire {prenom} {nom} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string delete = "DELETE FROM Proprietaire WHERE Id_Proprietaire = @Id";
                        using (SqlCommand cmd = new SqlCommand(delete, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Propriétaire supprimé.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetForm();
                            LoadProprietaires();
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
            editingProprietaireId = -1;
            btnAdd.Text = "Ajouter";
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            txtNom.Clear();
            txtPrenom.Clear();
            txtAdresse.Clear();
            txtTelephone.Clear();
            txtEmail.Clear();
        }
    }
}
