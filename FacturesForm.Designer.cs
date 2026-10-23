namespace projetVet
{
    partial class FacturesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvFactures;
        private System.Windows.Forms.GroupBox groupBoxGenerer;
        private System.Windows.Forms.Label lblConsultation;
        private System.Windows.Forms.ComboBox cmbConsultation;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.NumericUpDown numMontant;
        private System.Windows.Forms.Button btnGenererFacture;
        private System.Windows.Forms.GroupBox groupBoxPayer;
        private System.Windows.Forms.Label lblModePaiement;
        private System.Windows.Forms.TextBox txtModePaiement;
        private System.Windows.Forms.Button btnPayer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvFactures = new DataGridView();
            groupBoxGenerer = new GroupBox();
            btnGenererFacture = new Button();
            numMontant = new NumericUpDown();
            lblMontant = new Label();
            cmbConsultation = new ComboBox();
            lblConsultation = new Label();
            groupBoxPayer = new GroupBox();
            btnPayer = new Button();
            txtModePaiement = new TextBox();
            lblModePaiement = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFactures).BeginInit();
            groupBoxGenerer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMontant).BeginInit();
            groupBoxPayer.SuspendLayout();
            SuspendLayout();
            
            
            
            dgvFactures.AllowUserToAddRows = false;
            dgvFactures.AllowUserToDeleteRows = false;
            dgvFactures.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFactures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFactures.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFactures.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFactures.Location = new Point(14, 16);
            dgvFactures.Margin = new Padding(3, 4, 3, 4);
            dgvFactures.Name = "dgvFactures";
            dgvFactures.ReadOnly = true;
            dgvFactures.RowHeadersWidth = 51;
            dgvFactures.Size = new Size(686, 533);
            dgvFactures.TabIndex = 0;
            
            
            
            groupBoxGenerer.Controls.Add(btnGenererFacture);
            groupBoxGenerer.Controls.Add(numMontant);
            groupBoxGenerer.Controls.Add(lblMontant);
            groupBoxGenerer.Controls.Add(cmbConsultation);
            groupBoxGenerer.Controls.Add(lblConsultation);
            groupBoxGenerer.Location = new Point(709, 16);
            groupBoxGenerer.Margin = new Padding(3, 4, 3, 4);
            groupBoxGenerer.Name = "groupBoxGenerer";
            groupBoxGenerer.Padding = new Padding(3, 4, 3, 4);
            groupBoxGenerer.Size = new Size(400, 200);
            groupBoxGenerer.TabIndex = 1;
            groupBoxGenerer.TabStop = false;
            groupBoxGenerer.Text = "Générer une facture";
            
            
            
            btnGenererFacture.BackColor = Color.FromArgb(0, 122, 204);
            btnGenererFacture.FlatStyle = FlatStyle.Flat;
            btnGenererFacture.ForeColor = Color.White;
            btnGenererFacture.Location = new Point(23, 160);
            btnGenererFacture.Margin = new Padding(3, 4, 3, 4);
            btnGenererFacture.Name = "btnGenererFacture";
            btnGenererFacture.Size = new Size(137, 40);
            btnGenererFacture.TabIndex = 4;
            btnGenererFacture.Text = "Générer facture";
            btnGenererFacture.UseVisualStyleBackColor = false;
            btnGenererFacture.Click += btnGenererFacture_Click;
            
            
            
            numMontant.DecimalPlaces = 2;
            numMontant.Location = new Point(23, 127);
            numMontant.Margin = new Padding(3, 4, 3, 4);
            numMontant.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numMontant.Name = "numMontant";
            numMontant.Size = new Size(137, 27);
            numMontant.TabIndex = 3;
            
            
            
            lblMontant.AutoSize = true;
            lblMontant.Location = new Point(23, 100);
            lblMontant.Name = "lblMontant";
            lblMontant.Size = new Size(72, 20);
            lblMontant.TabIndex = 2;
            lblMontant.Text = "Montant :";
            
            
            
            cmbConsultation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConsultation.Location = new Point(23, 60);
            cmbConsultation.Margin = new Padding(3, 4, 3, 4);
            cmbConsultation.Name = "cmbConsultation";
            cmbConsultation.Size = new Size(354, 28);
            cmbConsultation.TabIndex = 1;
            
            
            
            lblConsultation.AutoSize = true;
            lblConsultation.Location = new Point(23, 33);
            lblConsultation.Name = "lblConsultation";
            lblConsultation.Size = new Size(99, 20);
            lblConsultation.TabIndex = 0;
            lblConsultation.Text = "Consultation :";
            
            
            
            groupBoxPayer.Controls.Add(btnPayer);
            groupBoxPayer.Controls.Add(txtModePaiement);
            groupBoxPayer.Controls.Add(lblModePaiement);
            groupBoxPayer.Location = new Point(709, 227);
            groupBoxPayer.Margin = new Padding(3, 4, 3, 4);
            groupBoxPayer.Name = "groupBoxPayer";
            groupBoxPayer.Padding = new Padding(3, 4, 3, 4);
            groupBoxPayer.Size = new Size(400, 160);
            groupBoxPayer.TabIndex = 2;
            groupBoxPayer.TabStop = false;
            groupBoxPayer.Text = "Enregistrer un paiement";
            
            
            
            btnPayer.BackColor = Color.FromArgb(40, 167, 69);
            btnPayer.FlatStyle = FlatStyle.Flat;
            btnPayer.ForeColor = Color.White;
            btnPayer.Location = new Point(23, 107);
            btnPayer.Margin = new Padding(3, 4, 3, 4);
            btnPayer.Name = "btnPayer";
            btnPayer.Size = new Size(137, 40);
            btnPayer.TabIndex = 2;
            btnPayer.Text = "Marquer payé";
            btnPayer.UseVisualStyleBackColor = false;
            btnPayer.Click += btnPayer_Click;
            
            
            
            txtModePaiement.Location = new Point(23, 60);
            txtModePaiement.Margin = new Padding(3, 4, 3, 4);
            txtModePaiement.Name = "txtModePaiement";
            txtModePaiement.Size = new Size(228, 27);
            txtModePaiement.TabIndex = 1;
            
            
            
            lblModePaiement.AutoSize = true;
            lblModePaiement.Location = new Point(23, 33);
            lblModePaiement.Name = "lblModePaiement";
            lblModePaiement.Size = new Size(143, 20);
            lblModePaiement.TabIndex = 0;
            lblModePaiement.Text = "Mode de paiement :";
            
            
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 616);
            Controls.Add(groupBoxPayer);
            Controls.Add(groupBoxGenerer);
            Controls.Add(dgvFactures);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FacturesForm";
            Text = "Gestion des factures";
            ((System.ComponentModel.ISupportInitialize)dgvFactures).EndInit();
            groupBoxGenerer.ResumeLayout(false);
            groupBoxGenerer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMontant).EndInit();
            groupBoxPayer.ResumeLayout(false);
            groupBoxPayer.PerformLayout();
            ResumeLayout(false);
        }
    }
}
