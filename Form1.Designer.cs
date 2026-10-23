namespace projetVet
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnInscription = new Button();
            lblLogin = new Label();
            lblPassword = new Label();
            lblTitle = new Label();

            SuspendLayout();

            
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(500, 550);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(450, 500);
            Text = "Connexion - Clinique Vétérinaire";

            
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 45, 45);
            lblTitle.Text = "Clinique Vétérinaire";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.Location = new Point((ClientSize.Width / 2) - 180, 50);

            
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 11F);
            lblLogin.Text = "Identifiant";
            lblLogin.Location = new Point(80, 150);
            lblLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            
            txtLogin.Font = new Font("Segoe UI", 11F);
            txtLogin.Location = new Point(80, 180);
            txtLogin.Size = new Size(340, 30);
            txtLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLogin.KeyPress += txtLogin_KeyPress;

            
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F);
            lblPassword.Text = "Mot de passe";
            lblPassword.Location = new Point(80, 240);
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(80, 270);
            txtPassword.Size = new Size(340, 30);
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.KeyPress += txtPassword_KeyPress;
            txtPassword.UseSystemPasswordChar = true;

            
            btnLogin.Text = "Se connecter";
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.BackColor = Color.FromArgb(0, 122, 204);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Location = new Point(80, 340);
            btnLogin.Size = new Size(160, 45);
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnLogin.Click += btnLogin_Click;

            
            btnInscription.Text = "S'inscrire";
            btnInscription.Font = new Font("Segoe UI", 11F);
            btnInscription.BackColor = Color.White;
            btnInscription.ForeColor = Color.FromArgb(0, 122, 204);
            btnInscription.FlatStyle = FlatStyle.Flat;
            btnInscription.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            btnInscription.Location = new Point(260, 340);
            btnInscription.Size = new Size(160, 45);
            btnInscription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnInscription.Click += btnInscription_Click;

            
            Controls.Add(lblTitle);
            Controls.Add(lblLogin);
            Controls.Add(txtLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnInscription);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
