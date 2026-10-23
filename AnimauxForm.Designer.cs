namespace projetVet
{
    partial class AnimauxForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAnimaux;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblEspece;
        private System.Windows.Forms.TextBox txtEspece;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.TextBox txtRace;
        private System.Windows.Forms.Label lblDateNaissance;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.ComboBox cmbSexe;
        private System.Windows.Forms.Label lblProprietaire;
        private System.Windows.Forms.ComboBox cmbProprietaire;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvAnimaux = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblEspece = new System.Windows.Forms.Label();
            this.txtEspece = new System.Windows.Forms.TextBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.txtRace = new System.Windows.Forms.TextBox();
            this.lblDateNaissance = new System.Windows.Forms.Label();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.lblSexe = new System.Windows.Forms.Label();
            this.cmbSexe = new System.Windows.Forms.ComboBox();
            this.lblProprietaire = new System.Windows.Forms.Label();
            this.cmbProprietaire = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaux)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            
            
            
            this.dgvAnimaux.AllowUserToAddRows = false;
            this.dgvAnimaux.AllowUserToDeleteRows = false;
            this.dgvAnimaux.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnimaux.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimaux.Location = new System.Drawing.Point(12, 50);
            this.dgvAnimaux.Name = "dgvAnimaux";
            this.dgvAnimaux.ReadOnly = true;
            this.dgvAnimaux.Size = new System.Drawing.Size(600, 400);
            this.dgvAnimaux.TabIndex = 0;
            
            
            
            this.txtSearch.Location = new System.Drawing.Point(12, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 23);
            this.txtSearch.TabIndex = 1;
            
            
            
            this.btnSearch.Location = new System.Drawing.Point(318, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Rechercher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            
            
            
            this.btnClear.Location = new System.Drawing.Point(424, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Effacer";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            
            
            
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 2);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(135, 15);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Rechercher (nom, espèce) :";
            
            
            
            this.groupBox.Controls.Add(this.lblProprietaire);
            this.groupBox.Controls.Add(this.cmbProprietaire);
            this.groupBox.Controls.Add(this.lblSexe);
            this.groupBox.Controls.Add(this.cmbSexe);
            this.groupBox.Controls.Add(this.lblDateNaissance);
            this.groupBox.Controls.Add(this.dtpDateNaissance);
            this.groupBox.Controls.Add(this.lblRace);
            this.groupBox.Controls.Add(this.txtRace);
            this.groupBox.Controls.Add(this.lblEspece);
            this.groupBox.Controls.Add(this.txtEspece);
            this.groupBox.Controls.Add(this.lblNom);
            this.groupBox.Controls.Add(this.txtNom);
            this.groupBox.Controls.Add(this.btnDelete);
            this.groupBox.Controls.Add(this.btnEdit);
            this.groupBox.Controls.Add(this.btnAdd);
            this.groupBox.Location = new System.Drawing.Point(620, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(350, 438);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Formulaire animal";
            
            
            
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(20, 30);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 15);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom *";
            
            
            
            this.txtNom.Location = new System.Drawing.Point(20, 50);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(310, 23);
            this.txtNom.TabIndex = 1;
            
            
            
            this.lblEspece.AutoSize = true;
            this.lblEspece.Location = new System.Drawing.Point(20, 80);
            this.lblEspece.Name = "lblEspece";
            this.lblEspece.Size = new System.Drawing.Size(48, 15);
            this.lblEspece.TabIndex = 2;
            this.lblEspece.Text = "Espèce *";
            
            
            
            this.txtEspece.Location = new System.Drawing.Point(20, 100);
            this.txtEspece.Name = "txtEspece";
            this.txtEspece.Size = new System.Drawing.Size(310, 23);
            this.txtEspece.TabIndex = 3;
            
            
            
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(20, 130);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(41, 15);
            this.lblRace.TabIndex = 4;
            this.lblRace.Text = "Race :";
            
            
            
            this.txtRace.Location = new System.Drawing.Point(20, 150);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(310, 23);
            this.txtRace.TabIndex = 5;
            
            
            
            this.lblDateNaissance.AutoSize = true;
            this.lblDateNaissance.Location = new System.Drawing.Point(20, 180);
            this.lblDateNaissance.Name = "lblDateNaissance";
            this.lblDateNaissance.Size = new System.Drawing.Size(100, 15);
            this.lblDateNaissance.TabIndex = 6;
            this.lblDateNaissance.Text = "Date de naissance :";
            
            
            
            this.dtpDateNaissance.Location = new System.Drawing.Point(20, 200);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(200, 23);
            this.dtpDateNaissance.TabIndex = 7;
            
            
            
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(20, 230);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(38, 15);
            this.lblSexe.TabIndex = 8;
            this.lblSexe.Text = "Sexe *";
            
            
            
            this.cmbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexe.Items.AddRange(new object[] { "M", "F" });
            this.cmbSexe.Location = new System.Drawing.Point(20, 250);
            this.cmbSexe.Name = "cmbSexe";
            this.cmbSexe.Size = new System.Drawing.Size(100, 23);
            this.cmbSexe.TabIndex = 9;
            
            
            
            this.lblProprietaire.AutoSize = true;
            this.lblProprietaire.Location = new System.Drawing.Point(20, 280);
            this.lblProprietaire.Name = "lblProprietaire";
            this.lblProprietaire.Size = new System.Drawing.Size(69, 15);
            this.lblProprietaire.TabIndex = 10;
            this.lblProprietaire.Text = "Propriétaire *";
            
            
            
            this.cmbProprietaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProprietaire.Location = new System.Drawing.Point(20, 300);
            this.cmbProprietaire.Name = "cmbProprietaire";
            this.cmbProprietaire.Size = new System.Drawing.Size(310, 23);
            this.cmbProprietaire.TabIndex = 11;
            
            
            
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            
            
            
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(120, 340);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            
            
            
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(220, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 462);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvAnimaux);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "AnimauxForm";
            this.Text = "Gestion des animaux";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimaux)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
