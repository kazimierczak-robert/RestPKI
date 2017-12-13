namespace AdminApp
{
    partial class LogInPanel
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Login:";
            // 
            // TBLogin
            // 
            this.TBLogin.Location = new System.Drawing.Point(59, 22);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(154, 20);
            this.TBLogin.TabIndex = 22;
            this.TBLogin.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterClicked);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(59, 48);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(154, 20);
            this.TBPassword.TabIndex = 23;
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterClicked);
            // 
            // BLogIn
            // 
            this.BLogIn.BackColor = System.Drawing.Color.SkyBlue;
            this.BLogIn.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.BLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLogIn.Location = new System.Drawing.Point(59, 74);
            this.BLogIn.Name = "BLogIn";
            this.BLogIn.Size = new System.Drawing.Size(154, 24);
            this.BLogIn.TabIndex = 24;
            this.BLogIn.Text = "Zaloguj";
            this.BLogIn.UseVisualStyleBackColor = false;
            this.BLogIn.Click += new System.EventHandler(this.BLogIn_Click);
            // 
            // LogInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 120);
            this.Controls.Add(this.BLogIn);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LogInPanel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrator PKI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BLogIn;
    }
}