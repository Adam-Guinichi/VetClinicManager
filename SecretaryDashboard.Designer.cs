namespace projetVet
{
    partial class SecretaryDashboard
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnDeconnexion;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnGestionProprietaires;
        private System.Windows.Forms.Button btnGestionAnimaux;
        private System.Windows.Forms.Button btnGestionRendezVous;
        private System.Windows.Forms.Button btnFacturation;
        private System.Windows.Forms.Button btnRecherche;

        
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel cardProprietaires;
        private System.Windows.Forms.Label lblProprietaireIcon;
        private System.Windows.Forms.Label lblProprietaireTitle;
        private System.Windows.Forms.Label lblProprietaireCount;
        private System.Windows.Forms.Panel cardAnimaux;
        private System.Windows.Forms.Label lblAnimalIcon;
        private System.Windows.Forms.Label lblAnimalTitle;
        private System.Windows.Forms.Label lblAnimalCount;
        private System.Windows.Forms.Panel cardRdvToday;
        private System.Windows.Forms.Label lblRdvIcon;
        private System.Windows.Forms.Label lblRdvTodayTitle;
        private System.Windows.Forms.Label lblRdvTodayCount;
        private System.Windows.Forms.Panel cardUnpaid;
        private System.Windows.Forms.Label lblUnpaidIcon;
        private System.Windows.Forms.Label lblUnpaidTitle;
        private System.Windows.Forms.Label lblUnpaidCount;

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
            cardProprietaires = new Panel();
            lblProprietaireIcon = new Label();
            lblProprietaireTitle = new Label();
            lblProprietaireCount = new Label();
            cardAnimaux = new Panel();
            lblAnimalIcon = new Label();
            lblAnimalTitle = new Label();
            lblAnimalCount = new Label();
            cardRdvToday = new Panel();
            lblRdvIcon = new Label();
            lblRdvTodayTitle = new Label();
            lblRdvTodayCount = new Label();
            cardUnpaid = new Panel();
            lblUnpaidIcon = new Label();
            lblUnpaidTitle = new Label();
            lblUnpaidCount = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            btnGestionProprietaires = new Button();
            btnGestionAnimaux = new Button();
            btnGestionRendezVous = new Button();
            btnFacturation = new Button();
            btnRecherche = new Button();
            btnDeconnexion = new Button();
            headerPanel.SuspendLayout();
            statsPanel.SuspendLayout();
            cardProprietaires.SuspendLayout();
            cardAnimaux.SuspendLayout();
            cardRdvToday.SuspendLayout();
            cardUnpaid.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
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
            lblWelcome.Size = new Size(320, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Bienvenue, Secrétaire";
            
            
            
            statsPanel.AutoSize = true;
            statsPanel.BackColor = Color.Transparent;
            statsPanel.Controls.Add(cardProprietaires);
            statsPanel.Controls.Add(cardAnimaux);
            statsPanel.Controls.Add(cardRdvToday);
            statsPanel.Controls.Add(cardUnpaid);
            statsPanel.Location = new Point(23, 133);
            statsPanel.Margin = new Padding(3, 4, 3, 4);
            statsPanel.Name = "statsPanel";
            statsPanel.Padding = new Padding(11, 13, 11, 13);
            statsPanel.Size = new Size(1341, 200);
            statsPanel.TabIndex = 2;
            
            
            
            cardProprietaires.BackColor = Color.White;
            cardProprietaires.Controls.Add(lblProprietaireIcon);
            cardProprietaires.Controls.Add(lblProprietaireTitle);
            cardProprietaires.Controls.Add(lblProprietaireCount);
            cardProprietaires.Location = new Point(23, 27);
            cardProprietaires.Margin = new Padding(3, 4, 3, 4);
            cardProprietaires.Name = "cardProprietaires";
            cardProprietaires.Size = new Size(309, 147);
            cardProprietaires.TabIndex = 0;
            
            
            
            lblProprietaireIcon.AutoSize = true;
            lblProprietaireIcon.Font = new Font("Segoe UI", 24F);
            lblProprietaireIcon.Location = new Point(17, 20);
            lblProprietaireIcon.Name = "lblProprietaireIcon";
            lblProprietaireIcon.Size = new Size(78, 54);
            lblProprietaireIcon.TabIndex = 0;
            lblProprietaireIcon.Text = "👥";
            
            
            
            lblProprietaireTitle.AutoSize = true;
            lblProprietaireTitle.Font = new Font("Segoe UI", 12F);
            lblProprietaireTitle.Location = new Point(97, 33);
            lblProprietaireTitle.Name = "lblProprietaireTitle";
            lblProprietaireTitle.Size = new Size(123, 28);
            lblProprietaireTitle.TabIndex = 1;
            lblProprietaireTitle.Text = "Propriétaires";
            
            
            
            lblProprietaireCount.AutoSize = true;
            lblProprietaireCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblProprietaireCount.ForeColor = Color.FromArgb(0, 122, 204);
            lblProprietaireCount.Location = new Point(80, 73);
            lblProprietaireCount.Name = "lblProprietaireCount";
            lblProprietaireCount.Size = new Size(46, 54);
            lblProprietaireCount.TabIndex = 2;
            lblProprietaireCount.Text = "0";
            
            
            
            cardAnimaux.BackColor = Color.White;
            cardAnimaux.Controls.Add(lblAnimalIcon);
            cardAnimaux.Controls.Add(lblAnimalTitle);
            cardAnimaux.Controls.Add(lblAnimalCount);
            cardAnimaux.Location = new Point(354, 27);
            cardAnimaux.Margin = new Padding(3, 4, 3, 4);
            cardAnimaux.Name = "cardAnimaux";
            cardAnimaux.Size = new Size(309, 147);
            cardAnimaux.TabIndex = 1;
            
            
            
            lblAnimalIcon.AutoSize = true;
            lblAnimalIcon.Font = new Font("Segoe UI", 24F);
            lblAnimalIcon.Location = new Point(17, 20);
            lblAnimalIcon.Name = "lblAnimalIcon";
            lblAnimalIcon.Size = new Size(78, 54);
            lblAnimalIcon.TabIndex = 0;
            lblAnimalIcon.Text = "🐕";
            
            
            
            lblAnimalTitle.AutoSize = true;
            lblAnimalTitle.Font = new Font("Segoe UI", 12F);
            lblAnimalTitle.Location = new Point(91, 33);
            lblAnimalTitle.Name = "lblAnimalTitle";
            lblAnimalTitle.Size = new Size(88, 28);
            lblAnimalTitle.TabIndex = 1;
            lblAnimalTitle.Text = "Animaux";
            
            
            
            lblAnimalCount.AutoSize = true;
            lblAnimalCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblAnimalCount.ForeColor = Color.FromArgb(0, 122, 204);
            lblAnimalCount.Location = new Point(91, 73);
            lblAnimalCount.Name = "lblAnimalCount";
            lblAnimalCount.Size = new Size(46, 54);
            lblAnimalCount.TabIndex = 2;
            lblAnimalCount.Text = "0";
            
            
            
            cardRdvToday.BackColor = Color.White;
            cardRdvToday.Controls.Add(lblRdvIcon);
            cardRdvToday.Controls.Add(lblRdvTodayTitle);
            cardRdvToday.Controls.Add(lblRdvTodayCount);
            cardRdvToday.Location = new Point(686, 27);
            cardRdvToday.Margin = new Padding(3, 4, 3, 4);
            cardRdvToday.Name = "cardRdvToday";
            cardRdvToday.Size = new Size(309, 147);
            cardRdvToday.TabIndex = 2;
            
            
            
            lblRdvIcon.AutoSize = true;
            lblRdvIcon.Font = new Font("Segoe UI", 24F);
            lblRdvIcon.Location = new Point(3, 20);
            lblRdvIcon.Name = "lblRdvIcon";
            lblRdvIcon.Size = new Size(78, 54);
            lblRdvIcon.TabIndex = 0;
            lblRdvIcon.Text = "📅";
            
            
            
            lblRdvTodayTitle.AutoSize = true;
            lblRdvTodayTitle.Font = new Font("Segoe UI", 12F);
            lblRdvTodayTitle.Location = new Point(77, 33);
            lblRdvTodayTitle.Name = "lblRdvTodayTitle";
            lblRdvTodayTitle.Size = new Size(229, 28);
            lblRdvTodayTitle.TabIndex = 1;
            lblRdvTodayTitle.Text = "Rendez-vous aujourd'hui";
            
            
            
            lblRdvTodayCount.AutoSize = true;
            lblRdvTodayCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblRdvTodayCount.ForeColor = Color.FromArgb(0, 122, 204);
            lblRdvTodayCount.Location = new Point(86, 73);
            lblRdvTodayCount.Name = "lblRdvTodayCount";
            lblRdvTodayCount.Size = new Size(46, 54);
            lblRdvTodayCount.TabIndex = 2;
            lblRdvTodayCount.Text = "0";
            
            
            
            cardUnpaid.BackColor = Color.White;
            cardUnpaid.Controls.Add(lblUnpaidIcon);
            cardUnpaid.Controls.Add(lblUnpaidTitle);
            cardUnpaid.Controls.Add(lblUnpaidCount);
            cardUnpaid.Location = new Point(1017, 27);
            cardUnpaid.Margin = new Padding(3, 4, 3, 4);
            cardUnpaid.Name = "cardUnpaid";
            cardUnpaid.Size = new Size(309, 147);
            cardUnpaid.TabIndex = 3;
            
            
            
            lblUnpaidIcon.AutoSize = true;
            lblUnpaidIcon.Font = new Font("Segoe UI", 24F);
            lblUnpaidIcon.Location = new Point(3, 20);
            lblUnpaidIcon.Name = "lblUnpaidIcon";
            lblUnpaidIcon.Size = new Size(78, 54);
            lblUnpaidIcon.TabIndex = 0;
            lblUnpaidIcon.Text = "💰";
            
            
            
            lblUnpaidTitle.AutoSize = true;
            lblUnpaidTitle.Font = new Font("Segoe UI", 12F);
            lblUnpaidTitle.Location = new Point(86, 33);
            lblUnpaidTitle.Name = "lblUnpaidTitle";
            lblUnpaidTitle.Size = new Size(170, 28);
            lblUnpaidTitle.TabIndex = 1;
            lblUnpaidTitle.Text = "Factures impayées";
            
            
            
            lblUnpaidCount.AutoSize = true;
            lblUnpaidCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblUnpaidCount.ForeColor = Color.FromArgb(0, 122, 204);
            lblUnpaidCount.Location = new Point(86, 73);
            lblUnpaidCount.Name = "lblUnpaidCount";
            lblUnpaidCount.Size = new Size(46, 54);
            lblUnpaidCount.TabIndex = 2;
            lblUnpaidCount.Text = "0";
            
            
            
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Controls.Add(btnGestionProprietaires);
            flowLayoutPanel.Controls.Add(btnGestionAnimaux);
            flowLayoutPanel.Controls.Add(btnGestionRendezVous);
            flowLayoutPanel.Controls.Add(btnFacturation);
            flowLayoutPanel.Controls.Add(btnRecherche);
            flowLayoutPanel.Controls.Add(btnDeconnexion);
            flowLayoutPanel.Location = new Point(23, 360);
            flowLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Padding = new Padding(11, 13, 11, 13);
            flowLayoutPanel.Size = new Size(1326, 400);
            flowLayoutPanel.TabIndex = 3;
            
            
            
            btnGestionProprietaires.BackColor = Color.White;
            btnGestionProprietaires.FlatStyle = FlatStyle.Flat;
            btnGestionProprietaires.Font = new Font("Segoe UI", 14F);
            btnGestionProprietaires.ForeColor = Color.FromArgb(0, 122, 204);
            btnGestionProprietaires.Location = new Point(22, 26);
            btnGestionProprietaires.Margin = new Padding(11, 13, 11, 13);
            btnGestionProprietaires.Name = "btnGestionProprietaires";
            btnGestionProprietaires.Size = new Size(297, 160);
            btnGestionProprietaires.TabIndex = 0;
            btnGestionProprietaires.Text = "👥 Gestion des propriétaires";
            btnGestionProprietaires.UseVisualStyleBackColor = false;
            btnGestionProprietaires.Click += btnGestionProprietaires_Click;
            
            
            
            btnGestionAnimaux.BackColor = Color.White;
            btnGestionAnimaux.FlatStyle = FlatStyle.Flat;
            btnGestionAnimaux.Font = new Font("Segoe UI", 14F);
            btnGestionAnimaux.ForeColor = Color.FromArgb(0, 122, 204);
            btnGestionAnimaux.Location = new Point(341, 26);
            btnGestionAnimaux.Margin = new Padding(11, 13, 11, 13);
            btnGestionAnimaux.Name = "btnGestionAnimaux";
            btnGestionAnimaux.Size = new Size(297, 160);
            btnGestionAnimaux.TabIndex = 1;
            btnGestionAnimaux.Text = "🐕 Gestion des animaux";
            btnGestionAnimaux.UseVisualStyleBackColor = false;
            btnGestionAnimaux.Click += btnGestionAnimaux_Click;
            
            
            
            btnGestionRendezVous.BackColor = Color.White;
            btnGestionRendezVous.FlatStyle = FlatStyle.Flat;
            btnGestionRendezVous.Font = new Font("Segoe UI", 14F);
            btnGestionRendezVous.ForeColor = Color.FromArgb(0, 122, 204);
            btnGestionRendezVous.Location = new Point(660, 26);
            btnGestionRendezVous.Margin = new Padding(11, 13, 11, 13);
            btnGestionRendezVous.Name = "btnGestionRendezVous";
            btnGestionRendezVous.Size = new Size(297, 160);
            btnGestionRendezVous.TabIndex = 2;
            btnGestionRendezVous.Text = "📅 Gestion des rendez-vous";
            btnGestionRendezVous.UseVisualStyleBackColor = false;
            btnGestionRendezVous.Click += btnGestionRendezVous_Click;
            
            
            
            btnFacturation.BackColor = Color.White;
            btnFacturation.FlatStyle = FlatStyle.Flat;
            btnFacturation.Font = new Font("Segoe UI", 14F);
            btnFacturation.ForeColor = Color.FromArgb(0, 122, 204);
            btnFacturation.Location = new Point(979, 26);
            btnFacturation.Margin = new Padding(11, 13, 11, 13);
            btnFacturation.Name = "btnFacturation";
            btnFacturation.Size = new Size(297, 160);
            btnFacturation.TabIndex = 3;
            btnFacturation.Text = "💰 Facturation";
            btnFacturation.UseVisualStyleBackColor = false;
            btnFacturation.Click += btnFacturation_Click;
            
            
            
            btnRecherche.BackColor = Color.White;
            btnRecherche.FlatStyle = FlatStyle.Flat;
            btnRecherche.Font = new Font("Segoe UI", 14F);
            btnRecherche.ForeColor = Color.FromArgb(0, 122, 204);
            btnRecherche.Location = new Point(22, 212);
            btnRecherche.Margin = new Padding(11, 13, 11, 13);
            btnRecherche.Name = "btnRecherche";
            btnRecherche.Size = new Size(297, 160);
            btnRecherche.TabIndex = 4;
            btnRecherche.Text = "🔍 Recherche multicritères";
            btnRecherche.UseVisualStyleBackColor = false;
            btnRecherche.Click += btnRecherche_Click;
            
            
            
            btnDeconnexion.BackColor = Color.White;
            btnDeconnexion.FlatStyle = FlatStyle.Flat;
            btnDeconnexion.Font = new Font("Segoe UI", 14F);
            btnDeconnexion.ForeColor = Color.Red;
            btnDeconnexion.Location = new Point(341, 212);
            btnDeconnexion.Margin = new Padding(11, 13, 11, 13);
            btnDeconnexion.Name = "btnDeconnexion";
            btnDeconnexion.Size = new Size(297, 160);
            btnDeconnexion.TabIndex = 5;
            btnDeconnexion.Text = "🚪 Déconnexion";
            btnDeconnexion.UseVisualStyleBackColor = false;
            btnDeconnexion.Click += btnDeconnexion_Click;
            
            
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1371, 800);
            Controls.Add(flowLayoutPanel);
            Controls.Add(statsPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SecretaryDashboard";
            Text = "Tableau de bord - Secrétaire";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            statsPanel.ResumeLayout(false);
            cardProprietaires.ResumeLayout(false);
            cardProprietaires.PerformLayout();
            cardAnimaux.ResumeLayout(false);
            cardAnimaux.PerformLayout();
            cardRdvToday.ResumeLayout(false);
            cardRdvToday.PerformLayout();
            cardUnpaid.ResumeLayout(false);
            cardUnpaid.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
