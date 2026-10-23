using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class UserManagementForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";
        private int editingUserId = -1;

        public UserManagementForm()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers(string searchTerm = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id_Utilisateur, Nom, Prenom, Login, Role FROM Utilisateur";
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += " WHERE Nom LIKE @Search OR Prenom LIKE @Search OR Login LIKE @Search OR Role LIKE @Search";
                    }
                    query += " ORDER BY Id_Utilisateur";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvUsers.DataSource = dt;
                        dgvUsers.Columns["Id_Utilisateur"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des utilisateurs : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadUsers(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            editingUserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["Id_Utilisateur"].Value);
            txtNom.Text = dgvUsers.CurrentRow.Cells["Nom"].Value.ToString();
            txtPrenom.Text = dgvUsers.CurrentRow.Cells["Prenom"].Value.ToString();
            txtLogin.Text = dgvUsers.CurrentRow.Cells["Login"].Value.ToString();
            string role = dgvUsers.CurrentRow.Cells["Role"].Value.ToString();
            cmbRole.SelectedItem = role;

            txtPassword.Clear();
            btnAdd.Text = "Modifier";
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string prenom = txtPrenom.Text.Trim();
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(prenom) || string.IsNullOrEmpty(login) ||
                string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Le nom, prénom, login et rôle sont obligatoires.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    if (editingUserId == -1) 
                    {
                        if (string.IsNullOrEmpty(password))
                        {
                            MessageBox.Show("Le mot de passe est obligatoire pour un nouvel utilisateur.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        
                        string check = "SELECT COUNT(*) FROM Utilisateur WHERE Login = @Login";
                        using (SqlCommand cmd = new SqlCommand(check, conn))
                        {
                            cmd.Parameters.AddWithValue("@Login", login);
                            int count = (int)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("Ce login existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        string insert = @"INSERT INTO Utilisateur (Nom, Prenom, Login, MotDePasse, Role, DateCreation)
                                          VALUES (@Nom, @Prenom, @Login, @Password, @Role, GETDATE())";
                        using (SqlCommand cmd = new SqlCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nom", nom);
                            cmd.Parameters.AddWithValue("@Prenom", prenom);
                            cmd.Parameters.AddWithValue("@Login", login);
                            cmd.Parameters.AddWithValue("@Password", password);
                            cmd.Parameters.AddWithValue("@Role", role);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Utilisateur ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else 
                    {
                        
                        string check = "SELECT COUNT(*) FROM Utilisateur WHERE Login = @Login AND Id_Utilisateur != @Id";
                        using (SqlCommand cmd = new SqlCommand(check, conn))
                        {
                            cmd.Parameters.AddWithValue("@Login", login);
                            cmd.Parameters.AddWithValue("@Id", editingUserId);
                            int count = (int)cmd.ExecuteScalar();
                            if (count > 0)
                            {
                                MessageBox.Show("Ce login existe déjà.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }

                        string updateQuery = @"UPDATE Utilisateur SET Nom=@Nom, Prenom=@Prenom, Login=@Login, Role=@Role";
                        if (!string.IsNullOrEmpty(password))
                        {
                            updateQuery += ", MotDePasse=@Password";
                        }
                        updateQuery += " WHERE Id_Utilisateur=@Id";

                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nom", nom);
                            cmd.Parameters.AddWithValue("@Prenom", prenom);
                            cmd.Parameters.AddWithValue("@Login", login);
                            cmd.Parameters.AddWithValue("@Role", role);
                            if (!string.IsNullOrEmpty(password))
                                cmd.Parameters.AddWithValue("@Password", password);
                            cmd.Parameters.AddWithValue("@Id", editingUserId);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Utilisateur modifié avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                ResetEditingState();
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;
            int userId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["Id_Utilisateur"].Value);
            string login = dgvUsers.CurrentRow.Cells["Login"].Value.ToString();

            if (MessageBox.Show($"Supprimer l'utilisateur '{login}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string delete = "DELETE FROM Utilisateur WHERE Id_Utilisateur = @Id";
                        using (SqlCommand cmd = new SqlCommand(delete, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", userId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Utilisateur supprimé.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ResetEditingState()
        {
            editingUserId = -1;
            btnAdd.Text = "Ajouter";
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            ClearFields();
        }

        private void ClearFields()
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtLogin.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }
    }
}
