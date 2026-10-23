namespace projetVet
{
    partial class RendezVousForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvRendezVous;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.Label lblVeterinaire;
        private System.Windows.Forms.ComboBox cmbVeterinaire;
        private System.Windows.Forms.Label lblHeure;
        private System.Windows.Forms.DateTimePicker dtpHeure;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.ComboBox cmbStatut;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvRendezVous = new System.Windows.Forms.DataGridView();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cmbStatut = new System.Windows.Forms.ComboBox();
            this.lblStatut = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.dtpHeure = new System.Windows.Forms.DateTimePicker();
            this.lblHeure = new System.Windows.Forms.Label();
            this.cmbVeterinaire = new System.Windows.Forms.ComboBox();
            this.lblVeterinaire = new System.Windows.Forms.Label();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendezVous)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            
            
            
            this.dgvRendezVous.AllowUserToAddRows = false;
            this.dgvRendezVous.AllowUserToDeleteRows = false;
            this.dgvRendezVous.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRendezVous.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRendezVous.Location = new System.Drawing.Point(12, 50);
            this.dgvRendezVous.Name = "dgvRendezVous";
            this.dgvRendezVous.ReadOnly = true;
            this.dgvRendezVous.Size = new System.Drawing.Size(600, 400);
            this.dgvRendezVous.TabIndex = 0;
            this.dgvRendezVous.SelectionChanged += new System.EventHandler(this.dgvRendezVous_SelectionChanged);
            
            
            
            this.dtpDate.Location = new System.Drawing.Point(70, 15);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            
            
            
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 19);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date :";
            
            
            
            this.groupBox.Controls.Add(this.cmbStatut);
            this.groupBox.Controls.Add(this.lblStatut);
            this.groupBox.Controls.Add(this.txtMotif);
            this.groupBox.Controls.Add(this.lblMotif);
            this.groupBox.Controls.Add(this.dtpHeure);
            this.groupBox.Controls.Add(this.lblHeure);
            this.groupBox.Controls.Add(this.cmbVeterinaire);
            this.groupBox.Controls.Add(this.lblVeterinaire);
            this.groupBox.Controls.Add(this.cmbAnimal);
            this.groupBox.Controls.Add(this.lblAnimal);
            this.groupBox.Controls.Add(this.btnDelete);
            this.groupBox.Controls.Add(this.btnEdit);
            this.groupBox.Controls.Add(this.btnAdd);
            this.groupBox.Location = new System.Drawing.Point(620, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(350, 438);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Formulaire rendez-vous";
            
            
            
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(20, 30);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(53, 15);
            this.lblAnimal.TabIndex = 0;
            this.lblAnimal.Text = "Animal *";
            
            
            
            this.cmbAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimal.Location = new System.Drawing.Point(20, 50);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(310, 23);
            this.cmbAnimal.TabIndex = 1;
            
            
            
            this.lblVeterinaire.AutoSize = true;
            this.lblVeterinaire.Location = new System.Drawing.Point(20, 80);
            this.lblVeterinaire.Name = "lblVeterinaire";
            this.lblVeterinaire.Size = new System.Drawing.Size(68, 15);
            this.lblVeterinaire.TabIndex = 2;
            this.lblVeterinaire.Text = "Vétérinaire *";
            
            
            
            this.cmbVeterinaire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVeterinaire.Location = new System.Drawing.Point(20, 100);
            this.cmbVeterinaire.Name = "cmbVeterinaire";
            this.cmbVeterinaire.Size = new System.Drawing.Size(310, 23);
            this.cmbVeterinaire.TabIndex = 3;
            
            
            
            this.lblHeure.AutoSize = true;
            this.lblHeure.Location = new System.Drawing.Point(20, 130);
            this.lblHeure.Name = "lblHeure";
            this.lblHeure.Size = new System.Drawing.Size(44, 15);
            this.lblHeure.TabIndex = 4;
            this.lblHeure.Text = "Heure *";
            
            
            
            this.dtpHeure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHeure.Location = new System.Drawing.Point(20, 150);
            this.dtpHeure.Name = "dtpHeure";
            this.dtpHeure.Size = new System.Drawing.Size(100, 23);
            this.dtpHeure.TabIndex = 5;
            this.dtpHeure.ShowUpDown = true;
            
            
            
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(20, 180);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(40, 15);
            this.lblMotif.TabIndex = 6;
            this.lblMotif.Text = "Motif :";
            
            
            
            this.txtMotif.Location = new System.Drawing.Point(20, 200);
            this.txtMotif.Multiline = true;
            this.txtMotif.Name = "txtMotif";
            this.txtMotif.Size = new System.Drawing.Size(310, 60);
            this.txtMotif.TabIndex = 7;
            
            
            
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(20, 270);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(45, 15);
            this.lblStatut.TabIndex = 8;
            this.lblStatut.Text = "Statut :";
            
            
            
            this.cmbStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatut.Items.AddRange(new object[] { "Planifie", "Modifie", "Annule" });
            this.cmbStatut.Location = new System.Drawing.Point(20, 290);
            this.cmbStatut.Name = "cmbStatut";
            this.cmbStatut.Size = new System.Drawing.Size(150, 23);
            this.cmbStatut.TabIndex = 9;
            
            
            
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(20, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            
            
            
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(120, 340);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 30);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Modifier";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            
            
            
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(220, 340);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 462);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.dgvRendezVous);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "RendezVousForm";
            this.Text = "Gestion des rendez-vous";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendezVous)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
