namespace projetVet
{
    partial class VaccinationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblProprietaire;
        private System.Windows.Forms.ComboBox cmbProprietaire;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.Label lblVaccin;
        private System.Windows.Forms.TextBox txtVaccin;
        private System.Windows.Forms.Label lblDateAdmin;
        private System.Windows.Forms.DateTimePicker dtpDateAdmin;
        private System.Windows.Forms.Label lblDateRappel;
        private System.Windows.Forms.DateTimePicker dtpDateRappel;
        private System.Windows.Forms.Button btnAjouterVaccin;
        private System.Windows.Forms.Button btnAnnuler;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblProprietaire = new System.Windows.Forms.Label();
            this.cmbProprietaire = new System.Windows.Forms.ComboBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.lblVaccin = new System.Windows.Forms.Label();
            this.txtVaccin = new System.Windows.Forms.TextBox();
            this.lblDateAdmin = new System.Windows.Forms.Label();
            this.dtpDateAdmin = new System.Windows.Forms.DateTimePicker();
            this.lblDateRappel = new System.Windows.Forms.Label();
            this.dtpDateRappel = new System.Windows.Forms.DateTimePicker();
            this.btnAjouterVaccin = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();

            
            
            
            this.lblProprietaire.AutoSize = true;
            this.lblProprietaire.Location = new System.Drawing.Point(30, 30);
            this.lblProprietaire.Name = "lblProprietaire";
            this.lblProprietaire.Size = new System.Drawing.Size(69, 15);
            this.lblProprietaire.TabIndex = 0;
            this.lblProprietaire.Text = "Propriétaire :";
            
            
            
            this.cmbProprietaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProprietaire.Location = new System.Drawing.Point(120, 27);
            this.cmbProprietaire.Name = "cmbProprietaire";
            this.cmbProprietaire.Size = new System.Drawing.Size(250, 23);
            this.cmbProprietaire.TabIndex = 1;
            this.cmbProprietaire.SelectedIndexChanged += new System.EventHandler(this.cmbProprietaire_SelectedIndexChanged);
            
            
            
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(30, 70);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(53, 15);
            this.lblAnimal.TabIndex = 2;
            this.lblAnimal.Text = "Animal :";
            
            
            
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimal.Location = new System.Drawing.Point(120, 67);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(250, 23);
            this.cmbAnimal.TabIndex = 3;
            
            
            
            this.lblVaccin.AutoSize = true;
            this.lblVaccin.Location = new System.Drawing.Point(30, 110);
            this.lblVaccin.Name = "lblVaccin";
            this.lblVaccin.Size = new System.Drawing.Size(49, 15);
            this.lblVaccin.TabIndex = 4;
            this.lblVaccin.Text = "Vaccin :";
            
            
            
            this.txtVaccin.Location = new System.Drawing.Point(120, 107);
            this.txtVaccin.Name = "txtVaccin";
            this.txtVaccin.Size = new System.Drawing.Size(250, 23);
            this.txtVaccin.TabIndex = 5;
            
            
            
            this.lblDateAdmin.AutoSize = true;
            this.lblDateAdmin.Location = new System.Drawing.Point(30, 150);
            this.lblDateAdmin.Name = "lblDateAdmin";
            this.lblDateAdmin.Size = new System.Drawing.Size(103, 15);
            this.lblDateAdmin.TabIndex = 6;
            this.lblDateAdmin.Text = "Date administration :";
            
            
            
            this.dtpDateAdmin.Location = new System.Drawing.Point(140, 147);
            this.dtpDateAdmin.Name = "dtpDateAdmin";
            this.dtpDateAdmin.Size = new System.Drawing.Size(200, 23);
            this.dtpDateAdmin.TabIndex = 7;
            
            
            
            this.lblDateRappel.AutoSize = true;
            this.lblDateRappel.Location = new System.Drawing.Point(30, 190);
            this.lblDateRappel.Name = "lblDateRappel";
            this.lblDateRappel.Size = new System.Drawing.Size(72, 15);
            this.lblDateRappel.TabIndex = 8;
            this.lblDateRappel.Text = "Date rappel :";
            
            
            
            this.dtpDateRappel.Location = new System.Drawing.Point(140, 187);
            this.dtpDateRappel.Name = "dtpDateRappel";
            this.dtpDateRappel.Size = new System.Drawing.Size(200, 23);
            this.dtpDateRappel.TabIndex = 9;
            
            
            
            this.btnAjouterVaccin.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnAjouterVaccin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterVaccin.ForeColor = System.Drawing.Color.White;
            this.btnAjouterVaccin.Location = new System.Drawing.Point(120, 240);
            this.btnAjouterVaccin.Name = "btnAjouterVaccin";
            this.btnAjouterVaccin.Size = new System.Drawing.Size(120, 30);
            this.btnAjouterVaccin.TabIndex = 10;
            this.btnAjouterVaccin.Text = "Enregistrer";
            this.btnAjouterVaccin.UseVisualStyleBackColor = false;
            this.btnAjouterVaccin.Click += new System.EventHandler(this.btnAjouterVaccin_Click);
            
            
            
            this.btnAnnuler.Location = new System.Drawing.Point(250, 240);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 30);
            this.btnAnnuler.TabIndex = 11;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouterVaccin);
            this.Controls.Add(this.dtpDateRappel);
            this.Controls.Add(this.lblDateRappel);
            this.Controls.Add(this.dtpDateAdmin);
            this.Controls.Add(this.lblDateAdmin);
            this.Controls.Add(this.txtVaccin);
            this.Controls.Add(this.lblVaccin);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.cmbProprietaire);
            this.Controls.Add(this.lblProprietaire);
            this.Name = "VaccinationForm";
            this.Text = "Gestion des vaccinations";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
