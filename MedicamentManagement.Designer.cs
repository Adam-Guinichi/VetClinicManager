namespace projetVet
{
    partial class MedicamentManagement
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvMedicaments;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.TabPage tabForm;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown numQuantite;
        private System.Windows.Forms.NumericUpDown numSeuil;
        private System.Windows.Forms.DateTimePicker dtpExpiration;
        private System.Windows.Forms.TextBox txtUnite;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblSeuil;
        private System.Windows.Forms.Label lblExpiration;
        private System.Windows.Forms.Label lblUnite;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvMedicaments = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClear = new Button();
            lblSearch = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            tabControl = new TabControl();
            tabList = new TabPage();
            tabForm = new TabPage();
            btnCancel = new Button();
            btnSave = new Button();
            txtUnite = new TextBox();
            lblUnite = new Label();
            dtpExpiration = new DateTimePicker();
            lblExpiration = new Label();
            numSeuil = new NumericUpDown();
            lblSeuil = new Label();
            numQuantite = new NumericUpDown();
            lblQuantite = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            txtNom = new TextBox();
            lblNom = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).BeginInit();
            tabControl.SuspendLayout();
            tabList.SuspendLayout();
            tabForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSeuil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantite).BeginInit();
            SuspendLayout();
            
            
            
            dgvMedicaments.AllowUserToAddRows = false;
            dgvMedicaments.AllowUserToDeleteRows = false;
            dgvMedicaments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicaments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicaments.Location = new Point(7, 53);
            dgvMedicaments.Margin = new Padding(3, 4, 3, 4);
            dgvMedicaments.Name = "dgvMedicaments";
            dgvMedicaments.ReadOnly = true;
            dgvMedicaments.RowHeadersWidth = 51;
            dgvMedicaments.Size = new Size(891, 533);
            dgvMedicaments.TabIndex = 0;
            
            
            
            txtSearch.Location = new Point(6, 18);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(342, 27);
            txtSearch.TabIndex = 1;
            
            
            
            btnSearch.Location = new Point(357, 12);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 33);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Rechercher";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            
            
            
            btnClear.Location = new Point(478, 12);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 33);
            btnClear.TabIndex = 3;
            btnClear.Text = "Effacer";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            
            
            
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(8, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(214, 20);
            lblSearch.TabIndex = 4;
            lblSearch.Text = "Rechercher (nom, description) :";
            
            
            
            btnAdd.BackColor = Color.FromArgb(0, 122, 204);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(7, 600);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Ajouter";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            
            
            
            btnEdit.Location = new Point(128, 600);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(114, 40);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Modifier";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            
            
            
            btnDelete.BackColor = Color.Red;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(249, 600);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 40);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Supprimer";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            
            
            
            tabControl.Controls.Add(tabList);
            tabControl.Controls.Add(tabForm);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(914, 667);
            tabControl.TabIndex = 8;
            
            
            
            tabList.Controls.Add(dgvMedicaments);
            tabList.Controls.Add(btnDelete);
            tabList.Controls.Add(txtSearch);
            tabList.Controls.Add(btnEdit);
            tabList.Controls.Add(btnSearch);
            tabList.Controls.Add(btnAdd);
            tabList.Controls.Add(btnClear);
            tabList.Controls.Add(lblSearch);
            tabList.Location = new Point(4, 29);
            tabList.Margin = new Padding(3, 4, 3, 4);
            tabList.Name = "tabList";
            tabList.Padding = new Padding(3, 4, 3, 4);
            tabList.Size = new Size(906, 634);
            tabList.TabIndex = 0;
            tabList.Text = "Liste des médicaments";
            tabList.UseVisualStyleBackColor = true;
            
            
            
            tabForm.Controls.Add(btnCancel);
            tabForm.Controls.Add(btnSave);
            tabForm.Controls.Add(txtUnite);
            tabForm.Controls.Add(lblUnite);
            tabForm.Controls.Add(dtpExpiration);
            tabForm.Controls.Add(lblExpiration);
            tabForm.Controls.Add(numSeuil);
            tabForm.Controls.Add(lblSeuil);
            tabForm.Controls.Add(numQuantite);
            tabForm.Controls.Add(lblQuantite);
            tabForm.Controls.Add(txtDescription);
            tabForm.Controls.Add(lblDescription);
            tabForm.Controls.Add(txtNom);
            tabForm.Controls.Add(lblNom);
            tabForm.Location = new Point(4, 29);
            tabForm.Margin = new Padding(3, 4, 3, 4);
            tabForm.Name = "tabForm";
            tabForm.Padding = new Padding(3, 4, 3, 4);
            tabForm.Size = new Size(906, 634);
            tabForm.TabIndex = 1;
            tabForm.Text = "Formulaire";
            tabForm.UseVisualStyleBackColor = true;
            
            
            
            btnCancel.Location = new Point(149, 573);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(114, 40);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Annuler";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            
            
            
            btnSave.BackColor = Color.FromArgb(0, 122, 204);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(23, 573);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 40);
            btnSave.TabIndex = 7;
            btnSave.Text = "Enregistrer";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            
            
            
            txtUnite.Location = new Point(23, 507);
            txtUnite.Margin = new Padding(3, 4, 3, 4);
            txtUnite.Name = "txtUnite";
            txtUnite.Size = new Size(137, 27);
            txtUnite.TabIndex = 6;
            
            
            
            lblUnite.AutoSize = true;
            lblUnite.Location = new Point(19, 483);
            lblUnite.Name = "lblUnite";
            lblUnite.Size = new Size(54, 20);
            lblUnite.TabIndex = 0;
            lblUnite.Text = "Unité *";
            
            
            
            dtpExpiration.Location = new Point(23, 427);
            dtpExpiration.Margin = new Padding(3, 4, 3, 4);
            dtpExpiration.Name = "dtpExpiration";
            dtpExpiration.Size = new Size(228, 27);
            dtpExpiration.TabIndex = 5;
            
            
            
            lblExpiration.AutoSize = true;
            lblExpiration.Location = new Point(19, 403);
            lblExpiration.Name = "lblExpiration";
            lblExpiration.Size = new Size(124, 20);
            lblExpiration.TabIndex = 0;
            lblExpiration.Text = "Date d'expiration";
            
            
            
            numSeuil.Location = new Point(23, 347);
            numSeuil.Margin = new Padding(3, 4, 3, 4);
            numSeuil.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSeuil.Name = "numSeuil";
            numSeuil.Size = new Size(137, 27);
            numSeuil.TabIndex = 4;
            
            
            
            lblSeuil.AutoSize = true;
            lblSeuil.Location = new Point(19, 323);
            lblSeuil.Name = "lblSeuil";
            lblSeuil.Size = new Size(105, 20);
            lblSeuil.TabIndex = 0;
            lblSeuil.Text = "Seuil d'alerte *";
            
            
            
            numQuantite.Location = new Point(23, 267);
            numQuantite.Margin = new Padding(3, 4, 3, 4);
            numQuantite.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantite.Name = "numQuantite";
            numQuantite.Size = new Size(137, 27);
            numQuantite.TabIndex = 3;
            
            
            
            lblQuantite.AutoSize = true;
            lblQuantite.Location = new Point(19, 243);
            lblQuantite.Name = "lblQuantite";
            lblQuantite.Size = new Size(124, 20);
            lblQuantite.TabIndex = 0;
            lblQuantite.Text = "Quantité en stock";
            
            
            
            txtDescription.Location = new Point(23, 133);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(571, 105);
            txtDescription.TabIndex = 2;
            
            
            
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(19, 109);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Description";
            
            
            
            txtNom.Location = new Point(23, 53);
            txtNom.Margin = new Padding(3, 4, 3, 4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(342, 27);
            txtNom.TabIndex = 1;
            
            
            
            lblNom.AutoSize = true;
            lblNom.Location = new Point(19, 29);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(52, 20);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom *";
            
            
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 667);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MedicamentManagement";
            Text = "Gestion des médicaments";
            ((System.ComponentModel.ISupportInitialize)dgvMedicaments).EndInit();
            tabControl.ResumeLayout(false);
            tabList.ResumeLayout(false);
            tabList.PerformLayout();
            tabForm.ResumeLayout(false);
            tabForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSeuil).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantite).EndInit();
            ResumeLayout(false);
        }
    }
}
