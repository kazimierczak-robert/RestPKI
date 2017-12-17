namespace ClientApp
{
    partial class CertificateRevocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BClose = new System.Windows.Forms.Button();
            this.BCertificateRevoke = new System.Windows.Forms.Button();
            this.CBRevocationReason = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BClose
            // 
            this.BClose.BackColor = System.Drawing.Color.Transparent;
            this.BClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BClose.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClose.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BClose.ForeColor = System.Drawing.Color.LightGray;
            this.BClose.Location = new System.Drawing.Point(373, 9);
            this.BClose.Margin = new System.Windows.Forms.Padding(0);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(28, 24);
            this.BClose.TabIndex = 29;
            this.BClose.Text = "X";
            this.BClose.UseVisualStyleBackColor = false;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // BCertificateRevoke
            // 
            this.BCertificateRevoke.BackColor = System.Drawing.Color.Gray;
            this.BCertificateRevoke.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BCertificateRevoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BCertificateRevoke.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BCertificateRevoke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCertificateRevoke.Location = new System.Drawing.Point(249, 195);
            this.BCertificateRevoke.Name = "BCertificateRevoke";
            this.BCertificateRevoke.Size = new System.Drawing.Size(82, 24);
            this.BCertificateRevoke.TabIndex = 36;
            this.BCertificateRevoke.Text = "Zmień";
            this.BCertificateRevoke.UseVisualStyleBackColor = false;
            this.BCertificateRevoke.Click += new System.EventHandler(this.BRevokeCertificate_Click);
            // 
            // CBRevocationReason
            // 
            this.CBRevocationReason.FormattingEnabled = true;
            this.CBRevocationReason.Location = new System.Drawing.Point(82, 127);
            this.CBRevocationReason.Name = "CBRevocationReason";
            this.CBRevocationReason.Size = new System.Drawing.Size(249, 21);
            this.CBRevocationReason.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(79, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Wybierz powód unieważnienia certyfikatu:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CertificateRevocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClientApp.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBRevocationReason);
            this.Controls.Add(this.BCertificateRevoke);
            this.Controls.Add(this.BClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(373, 9);
            this.Name = "CertificateRevocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CertificateRevocation";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CertificateRevocation_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Button BCertificateRevoke;
        private System.Windows.Forms.ComboBox CBRevocationReason;
        private System.Windows.Forms.Label label1;
    }
}