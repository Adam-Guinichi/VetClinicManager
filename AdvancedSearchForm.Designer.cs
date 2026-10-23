namespace projetVet
{
    partial class AdvancedSearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAnimaux;
        private System.Windows.Forms.TabPage tabConsultations;
        private System.Windows.Forms.TabPage tabFactures;

        
        private System.Windows.Forms.Label lblNomAnimal;
        private System.Windows.Forms.TextBox txtNomAnimal;
        private System.Windows.Forms.Label lblProprietaireAnimal;
        private System.Windows.Forms.ComboBox cmbProprietaireAnimal;
        private System.Windows.Forms.Label lblEspece;
        private System.Windows.Forms.TextBox txtEspece;
        private System.Windows.Forms.Button btnSearchAnimal;
        private System.Windows.Forms.DataGridView dgvAnimalResult;

        
        private System.Windows.Forms.CheckBox chkDateCons;
        private System.Windows.Forms.Label lblStartCons;
        private System.Windows.Forms.DateTimePicker dtpStartCons;
        private System.Windows.Forms.Label lblEndCons;
        private System.Windows.Forms.DateTimePicker dtpEndCons;
        private System.Windows.Forms.Label lblVetCons;
        private System.Windows.Forms.ComboBox cmbVetCons;
        private System.Windows.Forms.Label lblDiagnostic;
        private System.Windows.Forms.TextBox txtDiagnostic;
        private System.Windows.Forms.Button btnSearchConsultation;
        private System.Windows.Forms.DataGridView dgvConsultationResult;

        
        private System.Windows.Forms.CheckBox chkDateFacture;
        private System.Windows.Forms.Label lblStartFacture;
        private System.Windows.Forms.DateTimePicker dtpStartFacture;
        private System.Windows.Forms.Label lblEndFacture;
        private System.Windows.Forms.DateTimePicker dtpEndFacture;
        private System.Windows.Forms.Label lblProprietaireFacture;
        private System.Windows.Forms.ComboBox cmbProprietaireFacture;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.ComboBox cmbStatut;
        private System.Windows.Forms.Button btnSearchFacture;
        private System.Windows.Forms.DataGridView dgvFactureResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAnimaux = new System.Windows.Forms.TabPage();
            this.tabConsultations = new System.Windows.Forms.TabPage();
            this.tabFactures = new System.Windows.Forms.TabPage();

            
            this.lblNomAnimal = new System.Windows.Forms.Label();
            this.txtNomAnimal = new System.Windows.Forms.TextBox();
            this.lblProprietaireAnimal = new System.Windows.Forms.Label();
            this.cmbProprietaireAnimal = new System.Windows.Forms.ComboBox();
            this.lblEspece = new System.Windows.Forms.Label();
            this.txtEspece = new System.Windows.Forms.TextBox();
            this.btnSearchAnimal = new System.Windows.Forms.Button();
            this.dgvAnimalResult = new System.Windows.Forms.DataGridView();

            
            this.chkDateCons = new System.Windows.Forms.CheckBox();
            this.lblStartCons = new System.Windows.Forms.Label();
            this.dtpStartCons = new System.Windows.Forms.DateTimePicker();
            this.lblEndCons = new System.Windows.Forms.Label();
            this.dtpEndCons = new System.Windows.Forms.DateTimePicker();
            this.lblVetCons = new System.Windows.Forms.Label();
            this.cmbVetCons = new System.Windows.Forms.ComboBox();
            this.lblDiagnostic = new System.Windows.Forms.Label();
            this.txtDiagnostic = new System.Windows.Forms.TextBox();
            this.btnSearchConsultation = new System.Windows.Forms.Button();
            this.dgvConsultationResult = new System.Windows.Forms.DataGridView();

            
            this.chkDateFacture = new System.Windows.Forms.CheckBox();
            this.lblStartFacture = new System.Windows.Forms.Label();
            this.dtpStartFacture = new System.Windows.Forms.DateTimePicker();
            this.lblEndFacture = new System.Windows.Forms.Label();
            this.dtpEndFacture = new System.Windows.Forms.DateTimePicker();
            this.lblProprietaireFacture = new System.Windows.Forms.Label();
            this.cmbProprietaireFacture = new System.Windows.Forms.ComboBox();
            this.lblStatut = new System.Windows.Forms.Label();
            this.cmbStatut = new System.Windows.Forms.ComboBox();
            this.btnSearchFacture = new System.Windows.Forms.Button();
            this.dgvFactureResult = new System.Windows.Forms.DataGridView();

            
            
            
            this.tabControl.Controls.Add(this.tabAnimaux);
            this.tabControl.Controls.Add(this.tabConsultations);
            this.tabControl.Controls.Add(this.tabFactures);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1000, 600);
            this.tabControl.TabIndex = 0;

            
            
            
            this.tabAnimaux.Controls.Add(this.lblNomAnimal);
            this.tabAnimaux.Controls.Add(this.txtNomAnimal);
            this.tabAnimaux.Controls.Add(this.lblProprietaireAnimal);
            this.tabAnimaux.Controls.Add(this.cmbProprietaireAnimal);
            this.tabAnimaux.Controls.Add(this.lblEspece);
            this.tabAnimaux.Controls.Add(this.txtEspece);
            this.tabAnimaux.Controls.Add(this.btnSearchAnimal);
            this.tabAnimaux.Controls.Add(this.dgvAnimalResult);
            this.tabAnimaux.Location = new System.Drawing.Point(4, 24);
            this.tabAnimaux.Name = "tabAnimaux";
            this.tabAnimaux.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnimaux.Size = new System.Drawing.Size(992, 572);
            this.tabAnimaux.TabIndex = 0;
            this.tabAnimaux.Text = "Animaux";
            this.tabAnimaux.UseVisualStyleBackColor = true;

            
            
            
            this.tabConsultations.Controls.Add(this.chkDateCons);
            this.tabConsultations.Controls.Add(this.lblStartCons);
            this.tabConsultations.Controls.Add(this.dtpStartCons);
            this.tabConsultations.Controls.Add(this.lblEndCons);
            this.tabConsultations.Controls.Add(this.dtpEndCons);
            this.tabConsultations.Controls.Add(this.lblVetCons);
            this.tabConsultations.Controls.Add(this.cmbVetCons);
            this.tabConsultations.Controls.Add(this.lblDiagnostic);
            this.tabConsultations.Controls.Add(this.txtDiagnostic);
            this.tabConsultations.Controls.Add(this.btnSearchConsultation);
            this.tabConsultations.Controls.Add(this.dgvConsultationResult);
            this.tabConsultations.Location = new System.Drawing.Point(4, 24);
            this.tabConsultations.Name = "tabConsultations";
            this.tabConsultations.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultations.Size = new System.Drawing.Size(992, 572);
            this.tabConsultations.TabIndex = 1;
            this.tabConsultations.Text = "Consultations";
            this.tabConsultations.UseVisualStyleBackColor = true;

            
            
            
            this.tabFactures.Controls.Add(this.chkDateFacture);
            this.tabFactures.Controls.Add(this.lblStartFacture);
            this.tabFactures.Controls.Add(this.dtpStartFacture);
            this.tabFactures.Controls.Add(this.lblEndFacture);
            this.tabFactures.Controls.Add(this.dtpEndFacture);
            this.tabFactures.Controls.Add(this.lblProprietaireFacture);
            this.tabFactures.Controls.Add(this.cmbProprietaireFacture);
            this.tabFactures.Controls.Add(this.lblStatut);
            this.tabFactures.Controls.Add(this.cmbStatut);
            this.tabFactures.Controls.Add(this.btnSearchFacture);
            this.tabFactures.Controls.Add(this.dgvFactureResult);
            this.tabFactures.Location = new System.Drawing.Point(4, 24);
            this.tabFactures.Name = "tabFactures";
            this.tabFactures.Padding = new System.Windows.Forms.Padding(3);
            this.tabFactures.Size = new System.Drawing.Size(992, 572);
            this.tabFactures.TabIndex = 2;
            this.tabFactures.Text = "Factures";
            this.tabFactures.UseVisualStyleBackColor = true;

            
            
            
            
            this.lblNomAnimal.AutoSize = true;
            this.lblNomAnimal.Location = new System.Drawing.Point(20, 20);
            this.lblNomAnimal.Name = "lblNomAnimal";
            this.lblNomAnimal.Size = new System.Drawing.Size(34, 15);
            this.lblNomAnimal.TabIndex = 0;
            this.lblNomAnimal.Text = "Nom :";
            
            
            this.txtNomAnimal.Location = new System.Drawing.Point(120, 17);
            this.txtNomAnimal.Name = "txtNomAnimal";
            this.txtNomAnimal.Size = new System.Drawing.Size(200, 23);
            this.txtNomAnimal.TabIndex = 1;
            
            
            this.lblProprietaireAnimal.AutoSize = true;
            this.lblProprietaireAnimal.Location = new System.Drawing.Point(20, 60);
            this.lblProprietaireAnimal.Name = "lblProprietaireAnimal";
            this.lblProprietaireAnimal.Size = new System.Drawing.Size(69, 15);
            this.lblProprietaireAnimal.TabIndex = 2;
            this.lblProprietaireAnimal.Text = "Propriétaire :";
            
            
            this.cmbProprietaireAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProprietaireAnimal.Location = new System.Drawing.Point(120, 57);
            this.cmbProprietaireAnimal.Name = "cmbProprietaireAnimal";
            this.cmbProprietaireAnimal.Size = new System.Drawing.Size(200, 23);
            this.cmbProprietaireAnimal.TabIndex = 3;
            
            
            this.lblEspece.AutoSize = true;
            this.lblEspece.Location = new System.Drawing.Point(20, 100);
            this.lblEspece.Name = "lblEspece";
            this.lblEspece.Size = new System.Drawing.Size(48, 15);
            this.lblEspece.TabIndex = 4;
            this.lblEspece.Text = "Espèce :";
            
            
            this.txtEspece.Location = new System.Drawing.Point(120, 97);
            this.txtEspece.Name = "txtEspece";
            this.txtEspece.Size = new System.Drawing.Size(200, 23);
            this.txtEspece.TabIndex = 5;
            
            
            this.btnSearchAnimal.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnSearchAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAnimal.ForeColor = System.Drawing.Color.White;
            this.btnSearchAnimal.Location = new System.Drawing.Point(120, 140);
            this.btnSearchAnimal.Name = "btnSearchAnimal";
            this.btnSearchAnimal.Size = new System.Drawing.Size(100, 30);
            this.btnSearchAnimal.TabIndex = 6;
            this.btnSearchAnimal.Text = "Rechercher";
            this.btnSearchAnimal.UseVisualStyleBackColor = false;
            this.btnSearchAnimal.Click += new System.EventHandler(this.btnSearchAnimal_Click);
            
            
            this.dgvAnimalResult.AllowUserToAddRows = false;
            this.dgvAnimalResult.AllowUserToDeleteRows = false;
            this.dgvAnimalResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnimalResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimalResult.Location = new System.Drawing.Point(20, 190);
            this.dgvAnimalResult.Name = "dgvAnimalResult";
            this.dgvAnimalResult.ReadOnly = true;
            this.dgvAnimalResult.Size = new System.Drawing.Size(950, 360);
            this.dgvAnimalResult.TabIndex = 7;

            
            
            
            
            this.chkDateCons.AutoSize = true;
            this.chkDateCons.Location = new System.Drawing.Point(20, 20);
            this.chkDateCons.Name = "chkDateCons";
            this.chkDateCons.Size = new System.Drawing.Size(54, 19);
            this.chkDateCons.TabIndex = 0;
            this.chkDateCons.Text = "Date :";
            this.chkDateCons.UseVisualStyleBackColor = true;
            this.chkDateCons.CheckedChanged += new System.EventHandler(this.chkDateCons_CheckedChanged);
            
            
            this.lblStartCons.AutoSize = true;
            this.lblStartCons.Location = new System.Drawing.Point(80, 22);
            this.lblStartCons.Name = "lblStartCons";
            this.lblStartCons.Size = new System.Drawing.Size(27, 15);
            this.lblStartCons.TabIndex = 1;
            this.lblStartCons.Text = "Du :";
            
            
            this.dtpStartCons.Enabled = false;
            this.dtpStartCons.Location = new System.Drawing.Point(120, 18);
            this.dtpStartCons.Name = "dtpStartCons";
            this.dtpStartCons.Size = new System.Drawing.Size(120, 23);
            this.dtpStartCons.TabIndex = 2;
            
            
            this.lblEndCons.AutoSize = true;
            this.lblEndCons.Location = new System.Drawing.Point(260, 22);
            this.lblEndCons.Name = "lblEndCons";
            this.lblEndCons.Size = new System.Drawing.Size(29, 15);
            this.lblEndCons.TabIndex = 3;
            this.lblEndCons.Text = "Au :";
            
            
            this.dtpEndCons.Enabled = false;
            this.dtpEndCons.Location = new System.Drawing.Point(300, 18);
            this.dtpEndCons.Name = "dtpEndCons";
            this.dtpEndCons.Size = new System.Drawing.Size(120, 23);
            this.dtpEndCons.TabIndex = 4;
            
            
            this.lblVetCons.AutoSize = true;
            this.lblVetCons.Location = new System.Drawing.Point(20, 60);
            this.lblVetCons.Name = "lblVetCons";
            this.lblVetCons.Size = new System.Drawing.Size(68, 15);
            this.lblVetCons.TabIndex = 5;
            this.lblVetCons.Text = "Vétérinaire :";
            
            
            this.cmbVetCons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVetCons.Location = new System.Drawing.Point(120, 57);
            this.cmbVetCons.Name = "cmbVetCons";
            this.cmbVetCons.Size = new System.Drawing.Size(200, 23);
            this.cmbVetCons.TabIndex = 6;
            
            
            this.lblDiagnostic.AutoSize = true;
            this.lblDiagnostic.Location = new System.Drawing.Point(20, 100);
            this.lblDiagnostic.Name = "lblDiagnostic";
            this.lblDiagnostic.Size = new System.Drawing.Size(65, 15);
            this.lblDiagnostic.TabIndex = 7;
            this.lblDiagnostic.Text = "Diagnostic :";
            
            
            this.txtDiagnostic.Location = new System.Drawing.Point(120, 97);
            this.txtDiagnostic.Name = "txtDiagnostic";
            this.txtDiagnostic.Size = new System.Drawing.Size(300, 23);
            this.txtDiagnostic.TabIndex = 8;
            
            
            this.btnSearchConsultation.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnSearchConsultation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchConsultation.ForeColor = System.Drawing.Color.White;
            this.btnSearchConsultation.Location = new System.Drawing.Point(120, 140);
            this.btnSearchConsultation.Name = "btnSearchConsultation";
            this.btnSearchConsultation.Size = new System.Drawing.Size(100, 30);
            this.btnSearchConsultation.TabIndex = 9;
            this.btnSearchConsultation.Text = "Rechercher";
            this.btnSearchConsultation.UseVisualStyleBackColor = false;
            this.btnSearchConsultation.Click += new System.EventHandler(this.btnSearchConsultation_Click);
            
            
            this.dgvConsultationResult.AllowUserToAddRows = false;
            this.dgvConsultationResult.AllowUserToDeleteRows = false;
            this.dgvConsultationResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultationResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultationResult.Location = new System.Drawing.Point(20, 190);
            this.dgvConsultationResult.Name = "dgvConsultationResult";
            this.dgvConsultationResult.ReadOnly = true;
            this.dgvConsultationResult.Size = new System.Drawing.Size(950, 360);
            this.dgvConsultationResult.TabIndex = 10;

            
            
            
            
            this.chkDateFacture.AutoSize = true;
            this.chkDateFacture.Location = new System.Drawing.Point(20, 20);
            this.chkDateFacture.Name = "chkDateFacture";
            this.chkDateFacture.Size = new System.Drawing.Size(54, 19);
            this.chkDateFacture.TabIndex = 0;
            this.chkDateFacture.Text = "Date :";
            this.chkDateFacture.UseVisualStyleBackColor = true;
            this.chkDateFacture.CheckedChanged += new System.EventHandler(this.chkDateFacture_CheckedChanged);
            
            
            this.lblStartFacture.AutoSize = true;
            this.lblStartFacture.Location = new System.Drawing.Point(80, 22);
            this.lblStartFacture.Name = "lblStartFacture";
            this.lblStartFacture.Size = new System.Drawing.Size(27, 15);
            this.lblStartFacture.TabIndex = 1;
            this.lblStartFacture.Text = "Du :";
            
            
            this.dtpStartFacture.Enabled = false;
            this.dtpStartFacture.Location = new System.Drawing.Point(120, 18);
            this.dtpStartFacture.Name = "dtpStartFacture";
            this.dtpStartFacture.Size = new System.Drawing.Size(120, 23);
            this.dtpStartFacture.TabIndex = 2;
            
            
            this.lblEndFacture.AutoSize = true;
            this.lblEndFacture.Location = new System.Drawing.Point(260, 22);
            this.lblEndFacture.Name = "lblEndFacture";
            this.lblEndFacture.Size = new System.Drawing.Size(29, 15);
            this.lblEndFacture.TabIndex = 3;
            this.lblEndFacture.Text = "Au :";
            
            
            this.dtpEndFacture.Enabled = false;
            this.dtpEndFacture.Location = new System.Drawing.Point(300, 18);
            this.dtpEndFacture.Name = "dtpEndFacture";
            this.dtpEndFacture.Size = new System.Drawing.Size(120, 23);
            this.dtpEndFacture.TabIndex = 4;
            
            
            this.lblProprietaireFacture.AutoSize = true;
            this.lblProprietaireFacture.Location = new System.Drawing.Point(20, 60);
            this.lblProprietaireFacture.Name = "lblProprietaireFacture";
            this.lblProprietaireFacture.Size = new System.Drawing.Size(69, 15);
            this.lblProprietaireFacture.TabIndex = 5;
            this.lblProprietaireFacture.Text = "Propriétaire :";
            
            
            this.cmbProprietaireFacture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProprietaireFacture.Location = new System.Drawing.Point(120, 57);
            this.cmbProprietaireFacture.Name = "cmbProprietaireFacture";
            this.cmbProprietaireFacture.Size = new System.Drawing.Size(200, 23);
            this.cmbProprietaireFacture.TabIndex = 6;
            
            
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(20, 100);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(45, 15);
            this.lblStatut.TabIndex = 7;
            this.lblStatut.Text = "Statut :";
            
            
            this.cmbStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatut.Items.AddRange(new object[] { "Paye", "Impaye" });
            this.cmbStatut.Location = new System.Drawing.Point(120, 97);
            this.cmbStatut.Name = "cmbStatut";
            this.cmbStatut.Size = new System.Drawing.Size(120, 23);
            this.cmbStatut.TabIndex = 8;
            
            
            this.btnSearchFacture.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnSearchFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchFacture.ForeColor = System.Drawing.Color.White;
            this.btnSearchFacture.Location = new System.Drawing.Point(120, 140);
            this.btnSearchFacture.Name = "btnSearchFacture";
            this.btnSearchFacture.Size = new System.Drawing.Size(100, 30);
            this.btnSearchFacture.TabIndex = 9;
            this.btnSearchFacture.Text = "Rechercher";
            this.btnSearchFacture.UseVisualStyleBackColor = false;
            this.btnSearchFacture.Click += new System.EventHandler(this.btnSearchFacture_Click);
            
            
            this.dgvFactureResult.AllowUserToAddRows = false;
            this.dgvFactureResult.AllowUserToDeleteRows = false;
            this.dgvFactureResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFactureResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactureResult.Location = new System.Drawing.Point(20, 190);
            this.dgvFactureResult.Name = "dgvFactureResult";
            this.dgvFactureResult.ReadOnly = true;
            this.dgvFactureResult.Size = new System.Drawing.Size(950, 360);
            this.dgvFactureResult.TabIndex = 10;

            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabControl);
            this.Name = "AdvancedSearchForm";
            this.Text = "Recherche avancée";
            this.tabControl.ResumeLayout(false);
            this.tabAnimaux.ResumeLayout(false);
            this.tabAnimaux.PerformLayout();
            this.tabConsultations.ResumeLayout(false);
            this.tabConsultations.PerformLayout();
            this.tabFactures.ResumeLayout(false);
            this.tabFactures.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
