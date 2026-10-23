using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace projetVet
{
    public partial class MedicamentManagement : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\potat\OneDrive\Documents\projet frame\projetVet\db.mdf"";Integrated Security=True";
        private int selectedMedicamentId = -1;

        

        private void LoadMedicaments(string searchTerm = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"SELECT Id_Medicament, Nom, Description, QuantiteStock, SeuilAlerte, DateExpiration, Unite 
                                     FROM Medicament";
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        query += " WHERE Nom LIKE @Search OR Description LIKE @Search OR Unite LIKE @Search";
                    }
                    query += " ORDER BY Nom";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchTerm))
                        {
                            cmd.Parameters.AddWithValue("@Search", "%" + searchTerm + "%");
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMedicaments.DataSource = dt;

                        
                        dgvMedicaments.Columns["Id_Medicament"].Visible = false;

                        
                        foreach (DataGridViewRow row in dgvMedicaments.Rows)
                        {
                            int stock = Convert.ToInt32(row.Cells["QuantiteStock"].Value);
                            int seuil = Convert.ToInt32(row.Cells["SeuilAlerte"].Value);
                            DateTime? expiration = row.Cells["DateExpiration"].Value as DateTime?;

                            if (stock <= seuil)
                                row.DefaultCellStyle.BackColor = Color.LightCoral;
                            else if (expiration.HasValue && expiration.Value <= DateTime.Now.AddDays(30))
                                row.DefaultCellStyle.BackColor = Color.LightSalmon;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des médicaments : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadMedicaments(txtSearch.Text.Trim());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadMedicaments();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
            selectedMedicamentId = -1;
            btnSave.Text = "Ajouter";
            tabControl.SelectedTab = tabForm;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvMedicaments.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner un médicament à modifier.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            selectedMedicamentId = Convert.ToInt32(dgvMedicaments.CurrentRow.Cells["Id_Medicament"].Value);
            txtNom.Text = dgvMedicaments.CurrentRow.Cells["Nom"].Value.ToString();
            txtDescription.Text = dgvMedicaments.CurrentRow.Cells["Description"].Value?.ToString();
            numQuantite.Value = Convert.ToDecimal(dgvMedicaments.CurrentRow.Cells["QuantiteStock"].Value);
            numSeuil.Value = Convert.ToDecimal(dgvMedicaments.CurrentRow.Cells["SeuilAlerte"].Value);
            dtpExpiration.Value = dgvMedicaments.CurrentRow.Cells["DateExpiration"].Value == DBNull.Value ? DateTime.Today.AddMonths(12) : Convert.ToDateTime(dgvMedicaments.CurrentRow.Cells["DateExpiration"].Value);
            txtUnite.Text = dgvMedicaments.CurrentRow.Cells["Unite"].Value?.ToString();

            btnSave.Text = "Modifier";
            tabControl.SelectedTab = tabForm;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMedicaments.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvMedicaments.CurrentRow.Cells["Id_Medicament"].Value);
            string nom = dgvMedicaments.CurrentRow.Cells["Nom"].Value.ToString();

            if (MessageBox.Show($"Supprimer le médicament '{nom}' ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string delete = "DELETE FROM Medicament WHERE Id_Medicament = @Id";
                        using (SqlCommand cmd = new SqlCommand(delete, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Médicament supprimé.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadMedicaments();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text.Trim();
            string description = txtDescription.Text.Trim();
            int quantite = (int)numQuantite.Value;
            int seuil = (int)numSeuil.Value;
            DateTime expiration = dtpExpiration.Value;
            string unite = txtUnite.Text.Trim();

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(unite))
            {
                MessageBox.Show("Le nom et l'unité sont obligatoires.", "Champs manquants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (selectedMedicamentId == -1) 
                    {
                        string insert = @"INSERT INTO Medicament (Nom, Description, QuantiteStock, SeuilAlerte, DateExpiration, Unite)
                                          VALUES (@Nom, @Description, @Quantite, @Seuil, @Expiration, @Unite)";
                        using (SqlCommand cmd = new SqlCommand(insert, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nom", nom);
                            cmd.Parameters.AddWithValue("@Description", description);
                            cmd.Parameters.AddWithValue("@Quantite", quantite);
                            cmd.Parameters.AddWithValue("@Seuil", seuil);
                            cmd.Parameters.AddWithValue("@Expiration", expiration);
                            cmd.Parameters.AddWithValue("@Unite", unite);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Médicament ajouté.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else 
                    {
                        string update = @"UPDATE Medicament SET Nom=@Nom, Description=@Description, QuantiteStock=@Quantite,
                                          SeuilAlerte=@Seuil, DateExpiration=@Expiration, Unite=@Unite
                                          WHERE Id_Medicament=@Id";
                        using (SqlCommand cmd = new SqlCommand(update, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nom", nom);
                            cmd.Parameters.AddWithValue("@Description", description);
                            cmd.Parameters.AddWithValue("@Quantite", quantite);
                            cmd.Parameters.AddWithValue("@Seuil", seuil);
                            cmd.Parameters.AddWithValue("@Expiration", expiration);
                            cmd.Parameters.AddWithValue("@Unite", unite);
                            cmd.Parameters.AddWithValue("@Id", selectedMedicamentId);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Médicament modifié.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    LoadMedicaments();
                    ClearForm();
                    tabControl.SelectedTab = tabList;
                    selectedMedicamentId = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
            tabControl.SelectedTab = tabList;
            selectedMedicamentId = -1;
        }

        private void ClearForm()
        {
            txtNom.Clear();
            txtDescription.Clear();
            numQuantite.Value = 0;
            numSeuil.Value = 5;
            dtpExpiration.Value = DateTime.Today.AddMonths(12);
            txtUnite.Clear();
        }
        private bool readOnly = false;

        public MedicamentManagement(bool readOnly = false)
        {
            InitializeComponent();
            this.readOnly = readOnly;
            if (readOnly)
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                tabControl.TabPages.Remove(tabForm); 
            }
            LoadMedicaments();
        }
    }
}
