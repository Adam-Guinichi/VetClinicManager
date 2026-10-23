namespace projetVet
{
    partial class PlanningVetForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dgvRendezVous;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.dgvRendezVous = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendezVous)).BeginInit();
            this.SuspendLayout();
            
            
            this.dtpDate.Location = new System.Drawing.Point(60, 20);
            this.dtpDate.Size = new System.Drawing.Size(200, 23);
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            
            
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 24);
            this.lblDate.Text = "Date :";
            
            
            this.dgvRendezVous.AllowUserToAddRows = false;
            this.dgvRendezVous.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRendezVous.Location = new System.Drawing.Point(12, 60);
            this.dgvRendezVous.Size = new System.Drawing.Size(860, 400);
            this.dgvRendezVous.ReadOnly = true;
            
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 481);
            this.Controls.Add(this.dgvRendezVous);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Text = "Mon Planning";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRendezVous)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
