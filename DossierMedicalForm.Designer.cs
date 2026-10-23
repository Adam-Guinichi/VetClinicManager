namespace projetVet
{
    partial class DossierMedicalForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblProprietaire;
        private System.Windows.Forms.ComboBox cmbProprietaire;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConsultations;
        private System.Windows.Forms.TabPage tabVaccinations;
        private System.Windows.Forms.DataGridView dgvConsultations;
        private System.Windows.Forms.DataGridView dgvVaccinations;
        private System.Windows.Forms.Button btnAjouterConsultation;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblProprietaire = new Label();
            cmbProprietaire = new ComboBox();
            lblAnimal = new Label();
            cmbAnimal = new ComboBox();
            tabControl = new TabControl();
            tabConsultations = new TabPage();
            dgvConsultations = new DataGridView();
            tabVaccinations = new TabPage();
            dgvVaccinations = new DataGridView();
            btnAjouterConsultation = new Button();
            tabControl.SuspendLayout();
            tabConsultations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultations).BeginInit();
            tabVaccinations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVaccinations).BeginInit();
            SuspendLayout();
            
            
            
            lblProprietaire.AutoSize = true;
            lblProprietaire.Location = new Point(23, 27);
            lblProprietaire.Name = "lblProprietaire";
            lblProprietaire.Size = new Size(94, 20);
            lblProprietaire.TabIndex = 7;
            lblProprietaire.Text = "Propriétaire :";
            
            
            
            cmbProprietaire.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProprietaire.Location = new Point(137, 23);
            cmbProprietaire.Margin = new Padding(3, 4, 3, 4);
            cmbProprietaire.Name = "cmbProprietaire";
            cmbProprietaire.Size = new Size(285, 28);
            cmbProprietaire.TabIndex = 6;
            cmbProprietaire.SelectedIndexChanged += cmbProprietaire_SelectedIndexChanged;
            
            
            
            lblAnimal.AutoSize = true;
            lblAnimal.Location = new Point(23, 80);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(63, 20);
            lblAnimal.TabIndex = 5;
            lblAnimal.Text = "Animal :";
            
            
            
            cmbAnimal.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAnimal.Location = new Point(137, 76);
            cmbAnimal.Margin = new Padding(3, 4, 3, 4);
            cmbAnimal.Name = "cmbAnimal";
            cmbAnimal.Size = new Size(285, 28);
            cmbAnimal.TabIndex = 4;
            cmbAnimal.SelectedIndexChanged += cmbAnimal_SelectedIndexChanged;
            
            
            
            tabControl.Controls.Add(tabConsultations);
            tabControl.Controls.Add(tabVaccinations);
            tabControl.Location = new Point(23, 133);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1097, 533);
            tabControl.TabIndex = 3;
            
            
            
            tabConsultations.Controls.Add(dgvConsultations);
            tabConsultations.Location = new Point(4, 29);
            tabConsultations.Margin = new Padding(3, 4, 3, 4);
            tabConsultations.Name = "tabConsultations";
            tabConsultations.Size = new Size(1089, 500);
            tabConsultations.TabIndex = 0;
            tabConsultations.Text = "Consultations";
            
            
            
            dgvConsultations.AllowUserToAddRows = false;
            dgvConsultations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultations.ColumnHeadersHeight = 29;
            dgvConsultations.Dock = DockStyle.Fill;
            dgvConsultations.Location = new Point(0, 0);
            dgvConsultations.Margin = new Padding(3, 4, 3, 4);
            dgvConsultations.Name = "dgvConsultations";
            dgvConsultations.ReadOnly = true;
            dgvConsultations.RowHeadersWidth = 51;
            dgvConsultations.Size = new Size(1089, 500);
            dgvConsultations.TabIndex = 0;
            
            
            
            tabVaccinations.Controls.Add(dgvVaccinations);
            tabVaccinations.Location = new Point(4, 29);
            tabVaccinations.Margin = new Padding(3, 4, 3, 4);
            tabVaccinations.Name = "tabVaccinations";
            tabVaccinations.Size = new Size(1089, 500);
            tabVaccinations.TabIndex = 1;
            tabVaccinations.Text = "Vaccinations";
            
            
            
            dgvVaccinations.AllowUserToAddRows = false;
            dgvVaccinations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVaccinations.ColumnHeadersHeight = 29;
            dgvVaccinations.Dock = DockStyle.Fill;
            dgvVaccinations.Location = new Point(0, 0);
            dgvVaccinations.Margin = new Padding(3, 4, 3, 4);
            dgvVaccinations.Name = "dgvVaccinations";
            dgvVaccinations.ReadOnly = true;
            dgvVaccinations.RowHeadersWidth = 51;
            dgvVaccinations.Size = new Size(1089, 500);
            dgvVaccinations.TabIndex = 0;
            
            
            
            btnAjouterConsultation.BackColor = Color.FromArgb(0, 122, 204);
            btnAjouterConsultation.FlatStyle = FlatStyle.Flat;
            btnAjouterConsultation.ForeColor = Color.White;
            btnAjouterConsultation.Location = new Point(474, 674);
            btnAjouterConsultation.Margin = new Padding(3, 4, 3, 4);
            btnAjouterConsultation.Name = "btnAjouterConsultation";
            btnAjouterConsultation.Size = new Size(171, 40);
            btnAjouterConsultation.TabIndex = 0;
            btnAjouterConsultation.Text = "Nouvelle consultation";
            btnAjouterConsultation.UseVisualStyleBackColor = false;
            btnAjouterConsultation.Click += btnAjouterConsultation_Click;
            
            
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 800);
            Controls.Add(btnAjouterConsultation);
            Controls.Add(tabControl);
            Controls.Add(cmbAnimal);
            Controls.Add(lblAnimal);
            Controls.Add(cmbProprietaire);
            Controls.Add(lblProprietaire);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DossierMedicalForm";
            Text = "Dossier Médical";
            tabControl.ResumeLayout(false);
            tabConsultations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConsultations).EndInit();
            tabVaccinations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVaccinations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
