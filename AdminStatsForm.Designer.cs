namespace projetVet
{
    partial class AdminStatsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblRdv;
        private System.Windows.Forms.Label lblRdvCount;
        private System.Windows.Forms.Label lblCons;
        private System.Windows.Forms.Label lblConsCount;
        private System.Windows.Forms.Label lblRevenueLabel;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.DataGridView dgvRecent;
        private System.Windows.Forms.Label lblRecent;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblRdv = new System.Windows.Forms.Label();
            this.lblRdvCount = new System.Windows.Forms.Label();
            this.lblCons = new System.Windows.Forms.Label();
            this.lblConsCount = new System.Windows.Forms.Label();
            this.lblRevenueLabel = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            this.lblRecent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
            this.SuspendLayout();
            
            
            
            this.dtpStart.Location = new System.Drawing.Point(80, 30);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(150, 23);
            this.dtpStart.TabIndex = 0;
            
            
            
            this.dtpEnd.Location = new System.Drawing.Point(280, 30);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(150, 23);
            this.dtpEnd.TabIndex = 1;
            
            
            
            this.btnSearch.Location = new System.Drawing.Point(450, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Afficher";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            
            
            
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(20, 35);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(54, 15);
            this.lblStart.TabIndex = 3;
            this.lblStart.Text = "Du :";
            
            
            
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(245, 35);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(29, 15);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "Au :";
            
            
            
            this.lblRdv.AutoSize = true;
            this.lblRdv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRdv.Location = new System.Drawing.Point(20, 80);
            this.lblRdv.Name = "lblRdv";
            this.lblRdv.Size = new System.Drawing.Size(120, 21);
            this.lblRdv.TabIndex = 5;
            this.lblRdv.Text = "Rendez-vous :";
            
            
            
            this.lblRdvCount.AutoSize = true;
            this.lblRdvCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRdvCount.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.lblRdvCount.Location = new System.Drawing.Point(150, 80);
            this.lblRdvCount.Name = "lblRdvCount";
            this.lblRdvCount.Size = new System.Drawing.Size(19, 21);
            this.lblRdvCount.TabIndex = 6;
            this.lblRdvCount.Text = "0";
            
            
            
            this.lblCons.AutoSize = true;
            this.lblCons.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCons.Location = new System.Drawing.Point(20, 110);
            this.lblCons.Name = "lblCons";
            this.lblCons.Size = new System.Drawing.Size(115, 21);
            this.lblCons.TabIndex = 7;
            this.lblCons.Text = "Consultations :";
            
            
            
            this.lblConsCount.AutoSize = true;
            this.lblConsCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblConsCount.ForeColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.lblConsCount.Location = new System.Drawing.Point(150, 110);
            this.lblConsCount.Name = "lblConsCount";
            this.lblConsCount.Size = new System.Drawing.Size(19, 21);
            this.lblConsCount.TabIndex = 8;
            this.lblConsCount.Text = "0";
            
            
            
            this.lblRevenueLabel.AutoSize = true;
            this.lblRevenueLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRevenueLabel.Location = new System.Drawing.Point(20, 140);
            this.lblRevenueLabel.Name = "lblRevenueLabel";
            this.lblRevenueLabel.Size = new System.Drawing.Size(80, 21);
            this.lblRevenueLabel.TabIndex = 9;
            this.lblRevenueLabel.Text = "Revenus :";
            
            
            
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.Green;
            this.lblRevenue.Location = new System.Drawing.Point(150, 140);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(28, 21);
            this.lblRevenue.TabIndex = 10;
            this.lblRevenue.Text = "0 €";
            
            
            
            this.lblRecent.AutoSize = true;
            this.lblRecent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRecent.Location = new System.Drawing.Point(20, 180);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(206, 19);
            this.lblRecent.TabIndex = 11;
            this.lblRecent.Text = "Dernières consultations :";
            
            
            
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecent.Location = new System.Drawing.Point(20, 210);
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.Size = new System.Drawing.Size(760, 250);
            this.dgvRecent.TabIndex = 12;
            
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.dgvRecent);
            this.Controls.Add(this.lblRecent);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.lblRevenueLabel);
            this.Controls.Add(this.lblConsCount);
            this.Controls.Add(this.lblCons);
            this.Controls.Add(this.lblRdvCount);
            this.Controls.Add(this.lblRdv);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Name = "AdminStatsForm";
            this.Text = "Tableau de bord détaillé";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
