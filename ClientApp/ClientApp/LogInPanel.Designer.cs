using System.Windows.Forms;

namespace ClientApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPanel));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BLogIn = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(74, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(76, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Login:";
            // 
            // TBLogin
            // 
            this.TBLogin.Location = new System.Drawing.Point(121, 102);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(203, 20);
            this.TBLogin.TabIndex = 22;
            this.TBLogin.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterClicked);
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(121, 135);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(203, 20);
            this.TBPassword.TabIndex = 23;
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.EnterClicked);
            // 
            // BLogIn
            // 
            this.BLogIn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BLogIn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BLogIn.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BLogIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BLogIn.Location = new System.Drawing.Point(242, 169);
            this.BLogIn.Name = "BLogIn";
            this.BLogIn.Size = new System.Drawing.Size(82, 24);
            this.BLogIn.TabIndex = 24;
            this.BLogIn.Text = "Zaloguj";
            this.BLogIn.UseVisualStyleBackColor = false;
            this.BLogIn.Click += new System.EventHandler(this.BLogIn_Click);
            // 
            // BClose
            // 
            this.BClose.BackColor = System.Drawing.Color.Transparent;
            this.BClose.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BClose.ForeColor = System.Drawing.Color.LightGray;
            this.BClose.Location = new System.Drawing.Point(373, 9);
            this.BClose.Margin = new System.Windows.Forms.Padding(0);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(28, 25);
            this.BClose.TabIndex = 25;
            this.BClose.Text = "X";
            this.BClose.UseVisualStyleBackColor = false;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // LogInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 291);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.BLogIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBLogin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LogInPanel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klient PKI";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChangePassword_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BLogIn;
        private Button BClose;
    }
}