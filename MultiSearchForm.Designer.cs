namespace projetVet
{
    partial class MultiSearchForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabProprietaires;
        private System.Windows.Forms.TabPage tabAnimaux;
        private System.Windows.Forms.TabPage tabRendezVous;
        private System.Windows.Forms.TabPage tabFactures;

        
        private System.Windows.Forms.Label lblSearchProprietaires;
        private System.Windows.Forms.TextBox txtSearchProprietaires;
        private System.Windows.Forms.Button btnSearchProprietaires;
        private System.Windows.Forms.Button btnClearProprietaires;
        private System.Windows.Forms.DataGridView dgvProprietaires;

        
        private System.Windows.Forms.Label lblSearchAnimaux;
        private System.Windows.Forms.TextBox txtSearchAnimaux;
        private System.Windows.Forms.Button btnSearchAnimaux;
        private System.Windows.Forms.Button btnClearAnimaux;
        private System.Windows.Forms.DataGridView dgvAnimaux;

        
        private System.Windows.Forms.Label lblSearchRendezVous;
        private System.Windows.Forms.TextBox txtSearchRendezVous;
        private System.Windows.Forms.Button btnSearchRendezVous;
        private System.Windows.Forms.Button btnClearRendezVous;
        private System.Windows.Forms.DataGridView dgvRendezVous;

        
        private System.Windows.Forms.Label lblSearchFactures;
        private System.Windows.Forms.TextBox txtSearchFactures;
        private System.Windows.Forms.Button btnSearchFactures;
        private System.Windows.Forms.Button btnClearFactures;
        private System.Windows.Forms.DataGridView dgvFactures;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabProprietaires = new TabPage();
            lblSearchProprietaires = new Label();
            txtSearchProprietaires = new TextBox();
            btnSearchProprietaires = new Button();
            btnClearProprietaires = new Button();
            dgvProprietaires = new DataGridView();
            tabAnimaux = new TabPage();
            lblSearchAnimaux = new Label();
            txtSearchAnimaux = new TextBox();
            btnSearchAnimaux = new Button();
            btnClearAnimaux = new Button();
            dgvAnimaux = new DataGridView();
            tabRendezVous = new TabPage();
            lblSearchRendezVous = new Label();
            txtSearchRendezVous = new TextBox();
            btnSearchRendezVous = new Button();
            btnClearRendezVous = new Button();
            dgvRendezVous = new DataGridView();
            tabFactures = new TabPage();
            lblSearchFactures = new Label();
            txtSearchFactures = new TextBox();
            btnSearchFactures = new Button();
            btnClearFactures = new Button();
            dgvFactures = new DataGridView();
            tabControl.SuspendLayout();
            tabProprietaires.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProprietaires).BeginInit();
            tabAnimaux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimaux).BeginInit();
            tabRendezVous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRendezVous).BeginInit();
            tabFactures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFactures).BeginInit();
            SuspendLayout();
            
            
            
            tabControl.Controls.Add(tabProprietaires);
            tabControl.Controls.Add(tabAnimaux);
            tabControl.Controls.Add(tabRendezVous);
            tabControl.Controls.Add(tabFactures);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1143, 800);
            tabControl.TabIndex = 0;
            
            
            
            tabProprietaires.Controls.Add(lblSearchProprietaires);
            tabProprietaires.Controls.Add(txtSearchProprietaires);
            tabProprietaires.Controls.Add(btnSearchProprietaires);
            tabProprietaires.Controls.Add(btnClearProprietaires);
            tabProprietaires.Controls.Add(dgvProprietaires);
            tabProprietaires.Location = new Point(4, 29);
            tabProprietaires.Margin = new Padding(3, 4, 3, 4);
            tabProprietaires.Name = "tabProprietaires";
            tabProprietaires.Padding = new Padding(3, 4, 3, 4);
            tabProprietaires.Size = new Size(1135, 767);
            tabProprietaires.TabIndex = 0;
            tabProprietaires.Text = "Propriétaires";
            tabProprietaires.UseVisualStyleBackColor = true;
            
            
            
            lblSearchProprietaires.AutoSize = true;
            lblSearchProprietaires.Location = new Point(8, 19);
            lblSearchProprietaires.Name = "lblSearchProprietaires";
            lblSearchProprietaires.Size = new Size(160, 20);
            lblSearchProprietaires.TabIndex = 0;
            lblSearchProprietaires.Text = "Rechercher (nom, tél.) :";
            
            
            
            txtSearchProprietaires.Location = new Point(171, 16);
            txtSearchProprietaires.Margin = new Padding(3, 4, 3, 4);
            txtSearchProprietaires.Name = "txtSearchProprietaires";
            txtSearchProprietaires.Size = new Size(342, 27);
            txtSearchProprietaires.TabIndex = 1;
            
            
            
            btnSearchProprietaires.Location = new Point(526, 15);
            btnSearchProprietaires.Margin = new Padding(3, 4, 3, 4);
            btnSearchProprietaires.Name = "btnSearchProprietaires";
            btnSearchProprietaires.Size = new Size(114, 33);
            btnSearchProprietaires.TabIndex = 2;
            btnSearchProprietaires.Text = "Rechercher";
            btnSearchProprietaires.Click += btnSearchProprietaires_Click;
            
            
            
            btnClearProprietaires.Location = new Point(651, 15);
            btnClearProprietaires.Margin = new Padding(3, 4, 3, 4);
            btnClearProprietaires.Name = "btnClearProprietaires";
            btnClearProprietaires.Size = new Size(91, 33);
            btnClearProprietaires.TabIndex = 3;
            btnClearProprietaires.Text = "Effacer";
            btnClearProprietaires.Click += btnClearProprietaires_Click;
            
            
            
            dgvProprietaires.AllowUserToAddRows = false;
            dgvProprietaires.AllowUserToDeleteRows = false;
            dgvProprietaires.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProprietaires.ColumnHeadersHeight = 29;
            dgvProprietaires.Location = new Point(17, 60);
            dgvProprietaires.Margin = new Padding(3, 4, 3, 4);
            dgvProprietaires.Name = "dgvProprietaires";
            dgvProprietaires.ReadOnly = true;
            dgvProprietaires.RowHeadersWidth = 51;
            dgvProprietaires.Size = new Size(1097, 667);
            dgvProprietaires.TabIndex = 4;
            
            
            
            tabAnimaux.Controls.Add(lblSearchAnimaux);
            tabAnimaux.Controls.Add(txtSearchAnimaux);
            tabAnimaux.Controls.Add(btnSearchAnimaux);
            tabAnimaux.Controls.Add(btnClearAnimaux);
            tabAnimaux.Controls.Add(dgvAnimaux);
            tabAnimaux.Location = new Point(4, 29);
            tabAnimaux.Margin = new Padding(3, 4, 3, 4);
            tabAnimaux.Name = "tabAnimaux";
            tabAnimaux.Padding = new Padding(3, 4, 3, 4);
            tabAnimaux.Size = new Size(1135, 767);
            tabAnimaux.TabIndex = 1;
            tabAnimaux.Text = "Animaux";
            tabAnimaux.UseVisualStyleBackColor = true;
            
            
            
            lblSearchAnimaux.AutoSize = true;
            lblSearchAnimaux.Location = new Point(17, 20);
            lblSearchAnimaux.Name = "lblSearchAnimaux";
            lblSearchAnimaux.Size = new Size(93, 20);
            lblSearchAnimaux.TabIndex = 0;
            lblSearchAnimaux.Text = "Rechercher  :";
            lblSearchAnimaux.Click += lblSearchAnimaux_Click;
            
            
            
            txtSearchAnimaux.Location = new Point(171, 16);
            txtSearchAnimaux.Margin = new Padding(3, 4, 3, 4);
            txtSearchAnimaux.Name = "txtSearchAnimaux";
            txtSearchAnimaux.Size = new Size(342, 27);
            txtSearchAnimaux.TabIndex = 1;
            
            
            
            btnSearchAnimaux.Location = new Point(526, 15);
            btnSearchAnimaux.Margin = new Padding(3, 4, 3, 4);
            btnSearchAnimaux.Name = "btnSearchAnimaux";
            btnSearchAnimaux.Size = new Size(114, 33);
            btnSearchAnimaux.TabIndex = 2;
            btnSearchAnimaux.Text = "Rechercher";
            btnSearchAnimaux.Click += btnSearchAnimaux_Click;
            
            
            
            btnClearAnimaux.Location = new Point(651, 15);
            btnClearAnimaux.Margin = new Padding(3, 4, 3, 4);
            btnClearAnimaux.Name = "btnClearAnimaux";
            btnClearAnimaux.Size = new Size(91, 33);
            btnClearAnimaux.TabIndex = 3;
            btnClearAnimaux.Text = "Effacer";
            btnClearAnimaux.Click += btnClearAnimaux_Click;
            
            
            
            dgvAnimaux.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAnimaux.ColumnHeadersHeight = 29;
            dgvAnimaux.Location = new Point(17, 60);
            dgvAnimaux.Margin = new Padding(3, 4, 3, 4);
            dgvAnimaux.Name = "dgvAnimaux";
            dgvAnimaux.ReadOnly = true;
            dgvAnimaux.RowHeadersWidth = 51;
            dgvAnimaux.Size = new Size(1097, 667);
            dgvAnimaux.TabIndex = 4;
            
            
            
            tabRendezVous.Controls.Add(lblSearchRendezVous);
            tabRendezVous.Controls.Add(txtSearchRendezVous);
            tabRendezVous.Controls.Add(btnSearchRendezVous);
            tabRendezVous.Controls.Add(btnClearRendezVous);
            tabRendezVous.Controls.Add(dgvRendezVous);
            tabRendezVous.Location = new Point(4, 29);
            tabRendezVous.Margin = new Padding(3, 4, 3, 4);
            tabRendezVous.Name = "tabRendezVous";
            tabRendezVous.Padding = new Padding(3, 4, 3, 4);
            tabRendezVous.Size = new Size(1135, 767);
            tabRendezVous.TabIndex = 2;
            tabRendezVous.Text = "Rendez-vous";
            tabRendezVous.UseVisualStyleBackColor = true;
            
            
            
            lblSearchRendezVous.AutoSize = true;
            lblSearchRendezVous.Location = new Point(17, 20);
            lblSearchRendezVous.Name = "lblSearchRendezVous";
            lblSearchRendezVous.Size = new Size(86, 20);
            lblSearchRendezVous.TabIndex = 0;
            lblSearchRendezVous.Text = "Rechercher ";
            
            
            
            txtSearchRendezVous.Location = new Point(171, 16);
            txtSearchRendezVous.Margin = new Padding(3, 4, 3, 4);
            txtSearchRendezVous.Name = "txtSearchRendezVous";
            txtSearchRendezVous.Size = new Size(342, 27);
            txtSearchRendezVous.TabIndex = 1;
            
            
            
            btnSearchRendezVous.Location = new Point(526, 15);
            btnSearchRendezVous.Margin = new Padding(3, 4, 3, 4);
            btnSearchRendezVous.Name = "btnSearchRendezVous";
            btnSearchRendezVous.Size = new Size(114, 33);
            btnSearchRendezVous.TabIndex = 2;
            btnSearchRendezVous.Text = "Rechercher";
            btnSearchRendezVous.Click += btnSearchRendezVous_Click;
            
            
            
            btnClearRendezVous.Location = new Point(651, 15);
            btnClearRendezVous.Margin = new Padding(3, 4, 3, 4);
            btnClearRendezVous.Name = "btnClearRendezVous";
            btnClearRendezVous.Size = new Size(91, 33);
            btnClearRendezVous.TabIndex = 3;
            btnClearRendezVous.Text = "Effacer";
            btnClearRendezVous.Click += btnClearRendezVous_Click;
            
            
            
            dgvRendezVous.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRendezVous.ColumnHeadersHeight = 29;
            dgvRendezVous.Location = new Point(17, 60);
            dgvRendezVous.Margin = new Padding(3, 4, 3, 4);
            dgvRendezVous.Name = "dgvRendezVous";
            dgvRendezVous.ReadOnly = true;
            dgvRendezVous.RowHeadersWidth = 51;
            dgvRendezVous.Size = new Size(1097, 667);
            dgvRendezVous.TabIndex = 4;
            
            
            
            tabFactures.Controls.Add(lblSearchFactures);
            tabFactures.Controls.Add(txtSearchFactures);
            tabFactures.Controls.Add(btnSearchFactures);
            tabFactures.Controls.Add(btnClearFactures);
            tabFactures.Controls.Add(dgvFactures);
            tabFactures.Location = new Point(4, 29);
            tabFactures.Margin = new Padding(3, 4, 3, 4);
            tabFactures.Name = "tabFactures";
            tabFactures.Padding = new Padding(3, 4, 3, 4);
            tabFactures.Size = new Size(1135, 767);
            tabFactures.TabIndex = 3;
            tabFactures.Text = "Factures";
            tabFactures.UseVisualStyleBackColor = true;
            
            
            
            lblSearchFactures.AutoSize = true;
            lblSearchFactures.Location = new Point(17, 20);
            lblSearchFactures.Name = "lblSearchFactures";
            lblSearchFactures.Size = new Size(93, 20);
            lblSearchFactures.TabIndex = 0;
            lblSearchFactures.Text = "Rechercher  :";
            lblSearchFactures.Click += lblSearchFactures_Click;
            
            
            
            txtSearchFactures.Location = new Point(171, 16);
            txtSearchFactures.Margin = new Padding(3, 4, 3, 4);
            txtSearchFactures.Name = "txtSearchFactures";
            txtSearchFactures.Size = new Size(342, 27);
            txtSearchFactures.TabIndex = 1;
            
            
            
            btnSearchFactures.Location = new Point(526, 15);
            btnSearchFactures.Margin = new Padding(3, 4, 3, 4);
            btnSearchFactures.Name = "btnSearchFactures";
            btnSearchFactures.Size = new Size(114, 33);
            btnSearchFactures.TabIndex = 2;
            btnSearchFactures.Text = "Rechercher";
            btnSearchFactures.Click += btnSearchFactures_Click;
            
            
            
            btnClearFactures.Location = new Point(651, 15);
            btnClearFactures.Margin = new Padding(3, 4, 3, 4);
            btnClearFactures.Name = "btnClearFactures";
            btnClearFactures.Size = new Size(91, 33);
            btnClearFactures.TabIndex = 3;
            btnClearFactures.Text = "Effacer";
            btnClearFactures.Click += btnClearFactures_Click;
            
            
            
            dgvFactures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFactures.ColumnHeadersHeight = 29;
            dgvFactures.Location = new Point(17, 60);
            dgvFactures.Margin = new Padding(3, 4, 3, 4);
            dgvFactures.Name = "dgvFactures";
            dgvFactures.ReadOnly = true;
            dgvFactures.RowHeadersWidth = 51;
            dgvFactures.Size = new Size(1097, 667);
            dgvFactures.TabIndex = 4;
            
            
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 800);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MultiSearchForm";
            Text = "Recherche multicritères";
            tabControl.ResumeLayout(false);
            tabProprietaires.ResumeLayout(false);
            tabProprietaires.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProprietaires).EndInit();
            tabAnimaux.ResumeLayout(false);
            tabAnimaux.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimaux).EndInit();
            tabRendezVous.ResumeLayout(false);
            tabRendezVous.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRendezVous).EndInit();
            tabFactures.ResumeLayout(false);
            tabFactures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFactures).EndInit();
            ResumeLayout(false);
        }
    }
}
