using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projetVet
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtPassword.PasswordChar = 'â€¢';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text; 

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez saisir votre identifiant et mot de passe.", "Champs vides", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT Id_Utilisateur, Nom, Prenom, Role FROM Utilisateur WHERE Login = @Login AND MotDePasse = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Login", login);
                        cmd.Parameters.AddWithValue("@Password", password); 

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32(0);
                                string nom = reader.GetString(1);
                                string prenom = reader.GetString(2);
                                string role = reader.GetString(3);
                                string fullName = $"{prenom} {nom}";

                                MessageBox.Show($"Connexion rÃ©ussie !\nBienvenue, {fullName} (RÃ´le : {role})", "SuccÃ¨s", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Hide();

                                switch (role)
                                {
                                    case "Administrateur":
                                        AdminDashboard adminDashboard = new AdminDashboard(userId, fullName, role);
                                        adminDashboard.ShowDialog();
                                        break;
                                    case "Secretaire":
                                        SecretaryDashboard secretaryDashboard = new SecretaryDashboard(userId, fullName, role);
                                        secretaryDashboard.ShowDialog();
                                        break;
                                    case "Veterinaire":
                                        VeterinaireDashboard veterinaireDashboard = new VeterinaireDashboard(userId, fullName, role);
                                        veterinaireDashboard.ShowDialog();
                                        break;
                                    default:
                                        MessageBox.Show("RÃ´le non reconnu.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        this.Show();
                                        break;
                                }
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur de connexion Ã  la base de donnÃ©es : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            inscri registrationForm = new inscri();
            registrationForm.ShowDialog();
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}
