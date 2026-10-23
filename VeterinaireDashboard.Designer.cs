namespace projetVet
{
    partial class VeterinaireDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label lblRdvTodayTitle;
        private System.Windows.Forms.Label lblRdvTodayCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutButtons;
        private System.Windows.Forms.Button btnPlanning;
        private System.Windows.Forms.Button btnDossierMedical;
        private System.Windows.Forms.Button btnGestionVaccins;
        private System.Windows.Forms.Button btnStockMedicaments;
        private System.Windows.Forms.Button btnDeconnexion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            lblWelcome = new Label();
            statsPanel = new Panel();
            lblRdvTodayTitle = new Label();
            lblRdvTodayCount = new Label();
            tableLayoutButtons = new TableLayoutPanel();
            btnPlanning = new Button();
            btnDossierMedical = new Button();
            btnGestionVaccins = new Button();
            btnStockMedicaments = new Button();
            btnDeconnexion = new Button();
            headerPanel.SuspendLayout();
            statsPanel.SuspendLayout();
            tableLayoutButtons.SuspendLayout();
            SuspendLayout();
            
            
            
            headerPanel.BackColor = Color.FromArgb(0, 122, 204);
            headerPanel.Controls.Add(lblWelcome);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1371, 107);
            headerPanel.TabIndex = 0;
            
            
            
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(34, 33);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(334, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bienvenue, Vétérinaire";
            
            
            
            statsPanel.BackColor = Color.White;
            statsPanel.Controls.Add(lblRdvTodayTitle);
            statsPanel.Controls.Add(lblRdvTodayCount);
            statsPanel.Location = new Point(23, 133);
            statsPanel.Margin = new Padding(3, 4, 3, 4);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(1326, 107);
            statsPanel.TabIndex = 2;
            
            
            
            lblRdvTodayTitle.AutoSize = true;
            lblRdvTodayTitle.Font = new Font("Segoe UI", 12F);
            lblRdvTodayTitle.Location = new Point(23, 40);
            lblRdvTodayTitle.Name = "lblRdvTodayTitle";
            lblRdvTodayTitle.Size = new Size(238, 28);
            lblRdvTodayTitle.TabIndex = 0;
            lblRdvTodayTitle.Text = "Rendez-vous aujourd'hui :";
            
            
            
            lblRdvTodayCount.AutoSize = true;
            lblRdvTodayCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblRdvTodayCount.ForeColor = Color.FromArgb(0, 122, 204);
            lblRdvTodayCount.Location = new Point(262, 29);
            lblRdvTodayCount.Name = "lblRdvTodayCount";
            lblRdvTodayCount.Size = new Size(46, 54);
            lblRdvTodayCount.TabIndex = 1;
            lblRdvTodayCount.Text = "0";
            
            
            
            tableLayoutButtons.ColumnCount = 3;
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutButtons.Controls.Add(btnPlanning, 0, 0);
            tableLayoutButtons.Controls.Add(btnDossierMedical, 1, 0);
            tableLayoutButtons.Controls.Add(btnGestionVaccins, 2, 0);
            tableLayoutButtons.Controls.Add(btnStockMedicaments, 0, 1);
            tableLayoutButtons.Controls.Add(btnDeconnexion, 1, 1);
            tableLayoutButtons.Location = new Point(23, 267);
            tableLayoutButtons.Margin = new Padding(3, 4, 3, 4);
            tableLayoutButtons.Name = "tableLayoutButtons";
            tableLayoutButtons.Padding = new Padding(11, 13, 11, 13);
            tableLayoutButtons.RowCount = 2;
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutButtons.Size = new Size(1326, 467);
            tableLayoutButtons.TabIndex = 3;
            
            
            
            btnPlanning.BackColor = Color.White;
            btnPlanning.FlatStyle = FlatStyle.Flat;
            btnPlanning.Font = new Font("Segoe UI", 14F);
            btnPlanning.ForeColor = Color.FromArgb(0, 122, 204);
            btnPlanning.Location = new Point(22, 26);
            btnPlanning.Margin = new Padding(11, 13, 11, 13);
            btnPlanning.Name = "btnPlanning";
            btnPlanning.Size = new Size(286, 160);
            btnPlanning.TabIndex = 0;
            btnPlanning.Text = "📅 Mon Planning";
            btnPlanning.UseVisualStyleBackColor = false;
            btnPlanning.Click += btnPlanning_Click;
            
            
            
            btnDossierMedical.BackColor = Color.White;
            btnDossierMedical.FlatStyle = FlatStyle.Flat;
            btnDossierMedical.Font = new Font("Segoe UI", 14F);
            btnDossierMedical.ForeColor = Color.FromArgb(0, 122, 204);
            btnDossierMedical.Location = new Point(456, 26);
            btnDossierMedical.Margin = new Padding(11, 13, 11, 13);
            btnDossierMedical.Name = "btnDossierMedical";
            btnDossierMedical.Size = new Size(286, 160);
            btnDossierMedical.TabIndex = 1;
            btnDossierMedical.Text = "📋 Dossier Médical";
            btnDossierMedical.UseVisualStyleBackColor = false;
            btnDossierMedical.Click += btnDossierMedical_Click;
            
            
            
            btnGestionVaccins.BackColor = Color.White;
            btnGestionVaccins.FlatStyle = FlatStyle.Flat;
            btnGestionVaccins.Font = new Font("Segoe UI", 14F);
            btnGestionVaccins.ForeColor = Color.FromArgb(0, 122, 204);
            btnGestionVaccins.Location = new Point(890, 26);
            btnGestionVaccins.Margin = new Padding(11, 13, 11, 13);
            btnGestionVaccins.Name = "btnGestionVaccins";
            btnGestionVaccins.Size = new Size(286, 160);
            btnGestionVaccins.TabIndex = 2;
            btnGestionVaccins.Text = "💉 Vaccinations";
            btnGestionVaccins.UseVisualStyleBackColor = false;
            btnGestionVaccins.Click += btnGestionVaccins_Click;
            
            
            
            btnStockMedicaments.BackColor = Color.White;
            btnStockMedicaments.FlatStyle = FlatStyle.Flat;
            btnStockMedicaments.Font = new Font("Segoe UI", 14F);
            btnStockMedicaments.ForeColor = Color.FromArgb(0, 122, 204);
            btnStockMedicaments.Location = new Point(22, 246);
            btnStockMedicaments.Margin = new Padding(11, 13, 11, 13);
            btnStockMedicaments.Name = "btnStockMedicaments";
            btnStockMedicaments.Size = new Size(286, 160);
            btnStockMedicaments.TabIndex = 3;
            btnStockMedicaments.Text = "💊 Stock Médicaments";
            btnStockMedicaments.UseVisualStyleBackColor = false;
            btnStockMedicaments.Click += btnStockMedicaments_Click;
            
            
            
            btnDeconnexion.BackColor = Color.White;
            btnDeconnexion.FlatStyle = FlatStyle.Flat;
            btnDeconnexion.Font = new Font("Segoe UI", 14F);
            btnDeconnexion.ForeColor = Color.Red;
            btnDeconnexion.Location = new Point(456, 246);
            btnDeconnexion.Margin = new Padding(11, 13, 11, 13);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(286, 160);
            btnDeconnexion.TabIndex = 4;
            btnDeconnexion.Text = "🚪 Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            
            
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1371, 800);
            Controls.Add(tableLayoutButtons);
            Controls.Add(statsPanel);
            Controls.Add(headerPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "VeterinaireDashboard";
            Text = "Tableau de bord - Vétérinaire";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            statsPanel.ResumeLayout(false);
            statsPanel.PerformLayout();
            tableLayoutButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
