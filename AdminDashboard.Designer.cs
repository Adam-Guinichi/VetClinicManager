namespace projetVet
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnGestionUtilisateurs;
        private System.Windows.Forms.Button btnStockMedicaments;
        private System.Windows.Forms.Button btnTableauBord;
        private System.Windows.Forms.Button btnRechercheAvancee;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.Label lblUserTitle;
        private System.Windows.Forms.Label lblUserCount;
        private System.Windows.Forms.Label lblProprietaireTitle;
        private System.Windows.Forms.Label lblProprietaireCount;
        private System.Windows.Forms.Label lblAnimalTitle;
        private System.Windows.Forms.Label lblAnimalCount;
        private System.Windows.Forms.Label lblMedicamentTitle;
        private System.Windows.Forms.Label lblMedicamentCount;
        private System.Windows.Forms.Panel alertsPanel;
        private System.Windows.Forms.Label lblAlertsTitle;
        private System.Windows.Forms.Label lblLowStockAlert;
        private System.Windows.Forms.Label lblExpiringAlert;

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
            flowLayoutPanel = new FlowLayoutPanel();
            btnGestionUtilisateurs = new Button();
            btnStockMedicaments = new Button();
            btnTableauBord = new Button();
            btnRechercheAvancee = new Button();
            btnDeconnexion = new Button();
            statsPanel = new Panel();
            lblStatsTitle = new Label();
            lblUserTitle = new Label();
            lblUserCount = new Label();
            lblProprietaireTitle = new Label();
            lblProprietaireCount = new Label();
            lblAnimalTitle = new Label();
            lblAnimalCount = new Label();
            lblMedicamentTitle = new Label();
            lblMedicamentCount = new Label();
            alertsPanel = new Panel();
            lblAlertsTitle = new Label();
            lblLowStockAlert = new Label();
            lblExpiringAlert = new Label();
            headerPanel.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            statsPanel.SuspendLayout();
            alertsPanel.SuspendLayout();
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
            lblWelcome.Size = new Size(274, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bienvenue, Admin";
            
            
            
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Controls.Add(btnGestionUtilisateurs);
            flowLayoutPanel.Controls.Add(btnStockMedicaments);
            flowLayoutPanel.Controls.Add(btnTableauBord);
            flowLayoutPanel.Controls.Add(btnRechercheAvancee);
            flowLayoutPanel.Controls.Add(btnDeconnexion);
            flowLayoutPanel.Dock = DockStyle.Bottom;
            flowLayoutPanel.Location = new Point(0, 400);
            flowLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(34, 40, 34, 40);
            flowLayoutPanel.Size = new Size(1371, 400);
            flowLayoutPanel.TabIndex = 1;
            
            
            
            btnGestionUtilisateurs.BackColor = Color.White;
            btnGestionUtilisateurs.FlatStyle = FlatStyle.Flat;
            btnGestionUtilisateurs.Font = new Font("Segoe UI", 14F);
            btnGestionUtilisateurs.ForeColor = Color.FromArgb(0, 122, 204);
            btnGestionUtilisateurs.Location = new Point(34, 40);
            btnGestionUtilisateurs.Margin = new Padding(0, 0, 34, 40);
            btnGestionUtilisateurs.Name = "btnGestionUtilisateurs";
            btnGestionUtilisateurs.Size = new Size(286, 160);
            btnGestionUtilisateurs.TabIndex = 0;
            btnGestionUtilisateurs.Text = "👥 Gestion des utilisateurs";
            btnGestionUtilisateurs.UseVisualStyleBackColor = false;
            btnGestionUtilisateurs.Click += btnGestionUtilisateurs_Click;
            
            
            
            btnStockMedicaments.BackColor = Color.White;
            btnStockMedicaments.FlatStyle = FlatStyle.Flat;
            btnStockMedicaments.Font = new Font("Segoe UI", 14F);
            btnStockMedicaments.ForeColor = Color.FromArgb(0, 122, 204);
            btnStockMedicaments.Location = new Point(354, 40);
            btnStockMedicaments.Margin = new Padding(0, 0, 34, 40);
            btnStockMedicaments.Name = "btnStockMedicaments";
            btnStockMedicaments.Size = new Size(286, 160);
            btnStockMedicaments.TabIndex = 1;
            btnStockMedicaments.Text = "💊 Stock de médicaments";
            btnStockMedicaments.UseVisualStyleBackColor = false;
            btnStockMedicaments.Click += btnStockMedicaments_Click;
            
            
            
            btnTableauBord.BackColor = Color.White;
            btnTableauBord.FlatStyle = FlatStyle.Flat;
            btnTableauBord.Font = new Font("Segoe UI", 14F);
            btnTableauBord.ForeColor = Color.FromArgb(0, 122, 204);
            btnTableauBord.Location = new Point(674, 40);
            btnTableauBord.Margin = new Padding(0, 0, 34, 40);
            btnTableauBord.Name = "btnTableauBord";
            btnTableauBord.Size = new Size(286, 160);
            btnTableauBord.TabIndex = 2;
            btnTableauBord.Text = "📊 Tableau de bord";
            btnTableauBord.UseVisualStyleBackColor = false;
            btnTableauBord.Click += btnTableauBord_Click;
            
            
            
            btnRechercheAvancee.BackColor = Color.White;
            btnRechercheAvancee.FlatStyle = FlatStyle.Flat;
            btnRechercheAvancee.Font = new Font("Segoe UI", 14F);
            btnRechercheAvancee.ForeColor = Color.FromArgb(0, 122, 204);
            btnRechercheAvancee.Location = new Point(994, 40);
            btnRechercheAvancee.Margin = new Padding(0, 0, 34, 40);
            btnRechercheAvancee.Name = "btnRechercheAvancee";
            btnRechercheAvancee.Size = new Size(286, 160);
            btnRechercheAvancee.TabIndex = 3;
            btnRechercheAvancee.Text = "🔍 Recherche avancée";
            btnRechercheAvancee.UseVisualStyleBackColor = false;
            btnRechercheAvancee.Click += btnRechercheAvancee_Click;
            
            
            
            btnDeconnexion.BackColor = Color.White;
            btnDeconnexion.FlatStyle = FlatStyle.Flat;
            btnDeconnexion.Font = new Font("Segoe UI", 14F);
            btnDeconnexion.ForeColor = Color.Red;
            btnDeconnexion.Location = new Point(34, 240);
            btnDeconnexion.Margin = new Padding(0, 0, 34, 40);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(286, 160);
            btnDeconnexion.TabIndex = 4;
            btnDeconnexion.Text = "🚪 Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            
            
            
            statsPanel.BackColor = Color.White;
            statsPanel.Controls.Add(lblStatsTitle);
            statsPanel.Controls.Add(lblUserTitle);
            statsPanel.Controls.Add(lblUserCount);
            statsPanel.Controls.Add(lblProprietaireTitle);
            statsPanel.Controls.Add(lblProprietaireCount);
            statsPanel.Controls.Add(lblAnimalTitle);
            statsPanel.Controls.Add(lblAnimalCount);
            statsPanel.Controls.Add(lblMedicamentTitle);
            statsPanel.Controls.Add(lblMedicamentCount);
            statsPanel.Location = new Point(23, 133);
            statsPanel.Margin = new Padding(3, 4, 3, 4);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(1326, 160);
            statsPanel.TabIndex = 2;
            
            
            
            lblStatsTitle.AutoSize = true;
            lblStatsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblStatsTitle.Location = new Point(17, 13);
            lblStatsTitle.Name = "lblStatsTitle";
            lblStatsTitle.Size = new Size(145, 32);
            lblStatsTitle.TabIndex = 0;
            lblStatsTitle.Text = "Statistiques";
            
            
            
            lblUserTitle.AutoSize = true;
            lblUserTitle.Font = new Font("Segoe UI", 12F);
            lblUserTitle.Location = new Point(17, 67);
            lblUserTitle.Name = "lblUserTitle";
            lblUserTitle.Size = new Size(109, 28);
            lblUserTitle.TabIndex = 1;
            lblUserTitle.Text = "Utilisateurs";
            
            
            
            lblUserCount.AutoSize = true;
            lblUserCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblUserCount.ForeColor = Color.FromArgb(0, 122, 204);
            lblUserCount.Location = new Point(17, 100);
            lblUserCount.Name = "lblUserCount";
            lblUserCount.Size = new Size(40, 46);
            lblUserCount.TabIndex = 2;
            lblUserCount.Text = "0";
            
            
            
            lblProprietaireTitle.AutoSize = true;
            lblProprietaireTitle.Font = new Font("Segoe UI", 12F);
            lblProprietaireTitle.Location = new Point(149, 67);
            lblProprietaireTitle.Name = "lblProprietaireTitle";
            lblProprietaireTitle.Size = new Size(123, 28);
            lblProprietaireTitle.TabIndex = 3;
            lblProprietaireTitle.Text = "Propriétaires";
            
            
            
            lblProprietaireCount.AutoSize = true;
            lblProprietaireCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblProprietaireCount.ForeColor = Color.FromArgb(0, 122, 204);
            lblProprietaireCount.Location = new Point(149, 100);
            lblProprietaireCount.Name = "lblProprietaireCount";
            lblProprietaireCount.Size = new Size(40, 46);
            lblProprietaireCount.TabIndex = 4;
            lblProprietaireCount.Text = "0";
            
            
            
            lblAnimalTitle.AutoSize = true;
            lblAnimalTitle.Font = new Font("Segoe UI", 12F);
            lblAnimalTitle.Location = new Point(297, 67);
            lblAnimalTitle.Name = "lblAnimalTitle";
            lblAnimalTitle.Size = new Size(88, 28);
            lblAnimalTitle.TabIndex = 5;
            lblAnimalTitle.Text = "Animaux";
            
            
            
            lblAnimalCount.AutoSize = true;
            lblAnimalCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblAnimalCount.ForeColor = Color.FromArgb(0, 122, 204);
            lblAnimalCount.Location = new Point(297, 100);
            lblAnimalCount.Name = "lblAnimalCount";
            lblAnimalCount.Size = new Size(40, 46);
            lblAnimalCount.TabIndex = 6;
            lblAnimalCount.Text = "0";
            
            
            
            lblMedicamentTitle.AutoSize = true;
            lblMedicamentTitle.Font = new Font("Segoe UI", 12F);
            lblMedicamentTitle.Location = new Point(446, 67);
            lblMedicamentTitle.Name = "lblMedicamentTitle";
            lblMedicamentTitle.Size = new Size(129, 28);
            lblMedicamentTitle.TabIndex = 7;
            lblMedicamentTitle.Text = "Médicaments";
            
            
            
            lblMedicamentCount.AutoSize = true;
            lblMedicamentCount.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMedicamentCount.ForeColor = Color.FromArgb(0, 122, 204);
            lblMedicamentCount.Location = new Point(446, 100);
            lblMedicamentCount.Name = "lblMedicamentCount";
            lblMedicamentCount.Size = new Size(40, 46);
            lblMedicamentCount.TabIndex = 8;
            lblMedicamentCount.Text = "0";
            
            
            
            alertsPanel.BackColor = Color.FromArgb(255, 245, 225);
            alertsPanel.Controls.Add(lblAlertsTitle);
            alertsPanel.Controls.Add(lblLowStockAlert);
            alertsPanel.Controls.Add(lblExpiringAlert);
            alertsPanel.Location = new Point(23, 307);
            alertsPanel.Margin = new Padding(3, 4, 3, 4);
            alertsPanel.Name = "alertsPanel";
            alertsPanel.Size = new Size(1326, 80);
            alertsPanel.TabIndex = 3;
            
            
            
            lblAlertsTitle.AutoSize = true;
            lblAlertsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAlertsTitle.ForeColor = Color.OrangeRed;
            lblAlertsTitle.Location = new Point(17, 13);
            lblAlertsTitle.Name = "lblAlertsTitle";
            lblAlertsTitle.Size = new Size(80, 28);
            lblAlertsTitle.TabIndex = 0;
            lblAlertsTitle.Text = "Alertes";
            
            
            
            lblLowStockAlert.AutoSize = true;
            lblLowStockAlert.Font = new Font("Segoe UI", 10F);
            lblLowStockAlert.Location = new Point(17, 47);
            lblLowStockAlert.Name = "lblLowStockAlert";
            lblLowStockAlert.Size = new Size(263, 23);
            lblLowStockAlert.TabIndex = 1;
            lblLowStockAlert.Text = "⚠️ 0 médicament(s) en stock bas";
            
            
            
            lblExpiringAlert.AutoSize = true;
            lblExpiringAlert.Font = new Font("Segoe UI", 10F);
            lblExpiringAlert.Location = new Point(286, 47);
            lblExpiringAlert.Name = "lblExpiringAlert";
            lblExpiringAlert.Size = new Size(337, 23);
            lblExpiringAlert.TabIndex = 2;
            lblExpiringAlert.Text = "⚠️ 0 médicament(s) expirent dans 30 jours";
            
            
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1371, 800);
            Controls.Add(alertsPanel);
            Controls.Add(statsPanel);
            Controls.Add(flowLayoutPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminDashboard";
            Text = "Tableau de bord - Administrateur";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            statsPanel.ResumeLayout(false);
            statsPanel.PerformLayout();
            alertsPanel.ResumeLayout(false);
            alertsPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
