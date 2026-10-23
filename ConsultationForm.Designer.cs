namespace projetVet
{
    partial class ConsultationForm
    {
        
        
        
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox cmbMedicament;
        private System.Windows.Forms.NumericUpDown numQuantite;
        private System.Windows.Forms.Button btnAjouterMedicament;
        private System.Windows.Forms.ListBox lstMedicaments;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.TextBox txtTraitement;
        private System.Windows.Forms.TextBox txtRemarques;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label lblMedicament;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblMedicamentsList;
        private System.Windows.Forms.Label lblDiagnostic;
        private System.Windows.Forms.Label lblTraitement;
        private System.Windows.Forms.Label lblRemarques;

        
        
        
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        
        
        
        private void InitializeComponent()
        {
            cmbMedicament = new ComboBox();
            numQuantite = new NumericUpDown();
            btnAjouterMedicament = new Button();
            lstMedicaments = new ListBox();
            txtDiagnostic = new TextBox();
            txtTraitement = new TextBox();
            txtRemarques = new TextBox();
            btnEnregistrer = new Button();
            btnAnnuler = new Button();
            lblMedicament = new Label();
            lblQuantite = new Label();
            lblMedicamentsList = new Label();
            lblDiagnostic = new Label();
            lblTraitement = new Label();
            lblRemarques = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantite).BeginInit();
            SuspendLayout();
            
            
            
            cmbMedicament.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedicament.FormattingEnabled = true;
            cmbMedicament.Location = new Point(20, 29);
            cmbMedicament.Name = "cmbMedicament";
            cmbMedicament.Size = new Size(260, 28);
            cmbMedicament.TabIndex = 0;
            
            
            
            numQuantite.Location = new Point(300, 40);
            numQuantite.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantite.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantite.Name = "numQuantite";
            numQuantite.Size = new Size(80, 27);
            numQuantite.TabIndex = 1;
            numQuantite.Value = new decimal(new int[] { 1, 0, 0, 0 });
            
            
            
            btnAjouterMedicament.Location = new Point(400, 38);
            btnAjouterMedicament.Name = "btnAjouterMedicament";
            btnAjouterMedicament.Size = new Size(120, 26);
            btnAjouterMedicament.TabIndex = 2;
            btnAjouterMedicament.Text = "Ajouter médicament";
            btnAjouterMedicament.UseVisualStyleBackColor = true;
            btnAjouterMedicament.Click += btnAjouterMedicament_Click;
            
            
            
            lstMedicaments.FormattingEnabled = true;
            lstMedicaments.Location = new Point(20, 80);
            lstMedicaments.Name = "lstMedicaments";
            lstMedicaments.Size = new Size(500, 84);
            lstMedicaments.TabIndex = 3;
            
            
            
            txtDiagnostic.Location = new Point(20, 200);
            txtDiagnostic.Multiline = true;
            txtDiagnostic.Name = "txtDiagnostic";
            txtDiagnostic.Size = new Size(500, 60);
            txtDiagnostic.TabIndex = 4;
            
            
            
            txtTraitement.Location = new Point(20, 290);
            txtTraitement.Multiline = true;
            txtTraitement.Name = "txtTraitement";
            txtTraitement.Size = new Size(500, 60);
            txtTraitement.TabIndex = 5;
            
            
            
            txtRemarques.Location = new Point(20, 380);
            txtRemarques.Multiline = true;
            txtRemarques.Name = "txtRemarques";
            txtRemarques.Size = new Size(500, 60);
            txtRemarques.TabIndex = 6;
            
            
            
            btnEnregistrer.Location = new Point(360, 460);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(75, 30);
            btnEnregistrer.TabIndex = 7;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += btnEnregistrer_Click;
            
            
            
            btnAnnuler.Location = new Point(445, 460);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(75, 30);
            btnAnnuler.TabIndex = 8;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            
            
            
            lblMedicament.AutoSize = true;
            lblMedicament.Location = new Point(20, 9);
            lblMedicament.Name = "lblMedicament";
            lblMedicament.Size = new Size(92, 20);
            lblMedicament.TabIndex = 0;
            lblMedicament.Text = "Médicament";
            
            
            
            lblQuantite.AutoSize = true;
            lblQuantite.Location = new Point(300, 20);
            lblQuantite.Name = "lblQuantite";
            lblQuantite.Size = new Size(66, 20);
            lblQuantite.TabIndex = 1;
            lblQuantite.Text = "Quantité";
            
            
            
            lblMedicamentsList.AutoSize = true;
            lblMedicamentsList.Location = new Point(20, 60);
            lblMedicamentsList.Name = "lblMedicamentsList";
            lblMedicamentsList.Size = new Size(98, 20);
            lblMedicamentsList.TabIndex = 3;
            lblMedicamentsList.Text = "Médicaments";
            
            
            
            lblDiagnostic.AutoSize = true;
            lblDiagnostic.Location = new Point(20, 180);
            lblDiagnostic.Name = "lblDiagnostic";
            lblDiagnostic.Size = new Size(80, 20);
            lblDiagnostic.TabIndex = 4;
            lblDiagnostic.Text = "Diagnostic";
            
            
            
            lblTraitement.AutoSize = true;
            lblTraitement.Location = new Point(20, 270);
            lblTraitement.Name = "lblTraitement";
            lblTraitement.Size = new Size(80, 20);
            lblTraitement.TabIndex = 5;
            lblTraitement.Text = "Traitement";
            
            
            
            lblRemarques.AutoSize = true;
            lblRemarques.Location = new Point(20, 360);
            lblRemarques.Name = "lblRemarques";
            lblRemarques.Size = new Size(83, 20);
            lblRemarques.TabIndex = 6;
            lblRemarques.Text = "Remarques";
            
            
            
            ClientSize = new Size(560, 510);
            Controls.Add(lblMedicament);
            Controls.Add(cmbMedicament);
            Controls.Add(lblQuantite);
            Controls.Add(numQuantite);
            Controls.Add(btnAjouterMedicament);
            Controls.Add(lblMedicamentsList);
            Controls.Add(lstMedicaments);
            Controls.Add(lblDiagnostic);
            Controls.Add(txtDiagnostic);
            Controls.Add(lblTraitement);
            Controls.Add(txtTraitement);
            Controls.Add(lblRemarques);
            Controls.Add(txtRemarques);
            Controls.Add(btnEnregistrer);
            Controls.Add(btnAnnuler);
            Name = "ConsultationForm";
            Text = "Consultation";
            ((System.ComponentModel.ISupportInitialize)numQuantite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

