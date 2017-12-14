namespace ClientApp
{
    partial class PanelChangePassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBCurrentPassword = new System.Windows.Forms.TextBox();
            this.TBNewPassword = new System.Windows.Forms.TextBox();
            this.TBNewPassword2 = new System.Windows.Forms.TextBox();
            this.BChangePassword = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(86, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 29;
            this.label1.Text = "Aktualne \r\nhasło:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(94, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nowe \r\nhasło:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(70, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 31;
            this.label3.Text = "Potwierdź \r\nnowe hasło:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TBCurrentPassword
            // 
            this.TBCurrentPassword.Location = new System.Drawing.Point(156, 84);
            this.TBCurrentPassword.Name = "TBCurrentPassword";
            this.TBCurrentPassword.Size = new System.Drawing.Size(175, 20);
            this.TBCurrentPassword.TabIndex = 32;
            this.TBCurrentPassword.UseSystemPasswordChar = true;
            this.TBCurrentPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterClicked);
            // 
            // TBNewPassword
            // 
            this.TBNewPassword.Location = new System.Drawing.Point(156, 120);
            this.TBNewPassword.Name = "TBNewPassword";
            this.TBNewPassword.Size = new System.Drawing.Size(175, 20);
            this.TBNewPassword.TabIndex = 33;
            this.TBNewPassword.UseSystemPasswordChar = true;
            this.TBNewPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterClicked);
            // 
            // TBNewPassword2
            // 
            this.TBNewPassword2.Location = new System.Drawing.Point(156, 160);
            this.TBNewPassword2.Name = "TBNewPassword2";
            this.TBNewPassword2.Size = new System.Drawing.Size(175, 20);
            this.TBNewPassword2.TabIndex = 34;
            this.TBNewPassword2.UseSystemPasswordChar = true;
            this.TBNewPassword2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterClicked);
            // 
            // BChangePassword
            // 
            this.BChangePassword.BackColor = System.Drawing.Color.Gray;
            this.BChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BChangePassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BChangePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BChangePassword.Location = new System.Drawing.Point(249, 195);
            this.BChangePassword.Name = "BChangePassword";
            this.BChangePassword.Size = new System.Drawing.Size(82, 24);
            this.BChangePassword.TabIndex = 35;
            this.BChangePassword.Text = "Zmień";
            this.BChangePassword.UseVisualStyleBackColor = false;
            this.BChangePassword.Click += new System.EventHandler(this.BChangePassword_Click);
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
            this.BClose.TabIndex = 28;
            this.BClose.Text = "X";
            this.BClose.UseVisualStyleBackColor = false;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // PanelChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::ClientApp.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 291);
            this.Controls.Add(this.BChangePassword);
            this.Controls.Add(this.TBNewPassword2);
            this.Controls.Add(this.TBNewPassword);
            this.Controls.Add(this.TBCurrentPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelChangePassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PanelChangePassword";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChangePassword_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBCurrentPassword;
        private System.Windows.Forms.TextBox TBNewPassword;
        private System.Windows.Forms.TextBox TBNewPassword2;
        private System.Windows.Forms.Button BChangePassword;
        private System.Windows.Forms.Button BClose;
    }
}