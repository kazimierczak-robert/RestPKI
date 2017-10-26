namespace ClientApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DGVMessagesR = new System.Windows.Forms.DataGridView();
            this.PSendMessage = new System.Windows.Forms.Panel();
            this.LTopicR = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.CBRecNames = new System.Windows.Forms.ComboBox();
            this.LRecipient = new System.Windows.Forms.Label();
            this.LSender = new System.Windows.Forms.Label();
            this.PGetMessage = new System.Windows.Forms.Panel();
            this.LTopicS = new System.Windows.Forms.Label();
            this.TBTopicS = new System.Windows.Forms.TextBox();
            this.TBRecipient = new System.Windows.Forms.TextBox();
            this.TBMessageS = new System.Windows.Forms.TextBox();
            this.BSend = new System.Windows.Forms.Button();
            this.TBMessageR = new System.Windows.Forms.TextBox();
            this.BGetMessagess = new System.Windows.Forms.Button();
            this.BSendMessages = new System.Windows.Forms.Button();
            this.BRevokeTheCertificate = new System.Windows.Forms.Button();
            this.BGetTheCertificate = new System.Windows.Forms.Button();
            this.BApplyForTheCertificate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMessagesR)).BeginInit();
            this.PSendMessage.SuspendLayout();
            this.PGetMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVMessagesR
            // 
            this.DGVMessagesR.BackgroundColor = System.Drawing.Color.White;
            this.DGVMessagesR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVMessagesR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMessagesR.Location = new System.Drawing.Point(106, 98);
            this.DGVMessagesR.Name = "DGVMessagesR";
            this.DGVMessagesR.Size = new System.Drawing.Size(305, 338);
            this.DGVMessagesR.TabIndex = 9;
            this.toolTip.SetToolTip(this.DGVMessagesR, "Kliknij dwukrotnie na wiadomość, by odczytać");
            this.DGVMessagesR.Visible = false;
            // 
            // PSendMessage
            // 
            this.PSendMessage.Controls.Add(this.LTopicR);
            this.PSendMessage.Controls.Add(this.textBox2);
            this.PSendMessage.Controls.Add(this.BSend);
            this.PSendMessage.Controls.Add(this.CBRecNames);
            this.PSendMessage.Controls.Add(this.LRecipient);
            this.PSendMessage.Location = new System.Drawing.Point(106, 12);
            this.PSendMessage.Name = "PSendMessage";
            this.PSendMessage.Size = new System.Drawing.Size(630, 80);
            this.PSendMessage.TabIndex = 5;
            // 
            // LTopicR
            // 
            this.LTopicR.AutoSize = true;
            this.LTopicR.Location = new System.Drawing.Point(26, 46);
            this.LTopicR.Name = "LTopicR";
            this.LTopicR.Size = new System.Drawing.Size(40, 13);
            this.LTopicR.TabIndex = 5;
            this.LTopicR.Text = "Temat:";
            this.LTopicR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(69, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(474, 20);
            this.textBox2.TabIndex = 4;
            // 
            // CBRecNames
            // 
            this.CBRecNames.FormattingEnabled = true;
            this.CBRecNames.Location = new System.Drawing.Point(69, 15);
            this.CBRecNames.Name = "CBRecNames";
            this.CBRecNames.Size = new System.Drawing.Size(474, 21);
            this.CBRecNames.TabIndex = 1;
            // 
            // LRecipient
            // 
            this.LRecipient.AutoSize = true;
            this.LRecipient.Location = new System.Drawing.Point(13, 18);
            this.LRecipient.Name = "LRecipient";
            this.LRecipient.Size = new System.Drawing.Size(52, 13);
            this.LRecipient.TabIndex = 1;
            this.LRecipient.Text = "Wyślij do:";
            this.LRecipient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LSender
            // 
            this.LSender.AutoSize = true;
            this.LSender.Location = new System.Drawing.Point(10, 18);
            this.LSender.Name = "LSender";
            this.LSender.Size = new System.Drawing.Size(56, 13);
            this.LSender.TabIndex = 0;
            this.LSender.Text = "Nadawca:";
            this.LSender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PGetMessage
            // 
            this.PGetMessage.Controls.Add(this.LTopicS);
            this.PGetMessage.Controls.Add(this.TBTopicS);
            this.PGetMessage.Controls.Add(this.LSender);
            this.PGetMessage.Controls.Add(this.TBRecipient);
            this.PGetMessage.Location = new System.Drawing.Point(106, 12);
            this.PGetMessage.Name = "PGetMessage";
            this.PGetMessage.Size = new System.Drawing.Size(630, 80);
            this.PGetMessage.TabIndex = 6;
            // 
            // LTopicS
            // 
            this.LTopicS.AutoSize = true;
            this.LTopicS.Location = new System.Drawing.Point(26, 46);
            this.LTopicS.Name = "LTopicS";
            this.LTopicS.Size = new System.Drawing.Size(40, 13);
            this.LTopicS.TabIndex = 4;
            this.LTopicS.Text = "Temat:";
            this.LTopicS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBTopicS
            // 
            this.TBTopicS.Location = new System.Drawing.Point(69, 44);
            this.TBTopicS.Name = "TBTopicS";
            this.TBTopicS.ReadOnly = true;
            this.TBTopicS.Size = new System.Drawing.Size(547, 20);
            this.TBTopicS.TabIndex = 3;
            // 
            // TBRecipient
            // 
            this.TBRecipient.Location = new System.Drawing.Point(69, 15);
            this.TBRecipient.Name = "TBRecipient";
            this.TBRecipient.ReadOnly = true;
            this.TBRecipient.Size = new System.Drawing.Size(547, 20);
            this.TBRecipient.TabIndex = 2;
            // 
            // TBMessageS
            // 
            this.TBMessageS.Location = new System.Drawing.Point(106, 98);
            this.TBMessageS.Multiline = true;
            this.TBMessageS.Name = "TBMessageS";
            this.TBMessageS.Size = new System.Drawing.Size(616, 338);
            this.TBMessageS.TabIndex = 7;
            // 
            // BSend
            // 
            this.BSend.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BSend.Location = new System.Drawing.Point(554, 15);
            this.BSend.Name = "BSend";
            this.BSend.Size = new System.Drawing.Size(63, 49);
            this.BSend.TabIndex = 8;
            this.BSend.Text = "Wyślij";
            this.BSend.UseVisualStyleBackColor = false;
            // 
            // TBMessageR
            // 
            this.TBMessageR.Enabled = false;
            this.TBMessageR.Location = new System.Drawing.Point(417, 98);
            this.TBMessageR.Multiline = true;
            this.TBMessageR.Name = "TBMessageR";
            this.TBMessageR.ReadOnly = true;
            this.TBMessageR.Size = new System.Drawing.Size(305, 338);
            this.TBMessageR.TabIndex = 10;
            this.TBMessageR.Visible = false;
            this.TBMessageR.WordWrap = false;
            // 
            // BGetMessagess
            // 
            this.BGetMessagess.BackgroundImage = global::ClientApp.Properties.Resources.SOdbiorcza;
            this.BGetMessagess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BGetMessagess.Location = new System.Drawing.Point(12, 356);
            this.BGetMessagess.Name = "BGetMessagess";
            this.BGetMessagess.Size = new System.Drawing.Size(80, 80);
            this.BGetMessagess.TabIndex = 4;
            this.toolTip.SetToolTip(this.BGetMessagess, "Skrzynka odbiorcza");
            this.BGetMessagess.UseVisualStyleBackColor = true;
            this.BGetMessagess.Click += new System.EventHandler(this.BGetMessagess_Click);
            // 
            // BSendMessages
            // 
            this.BSendMessages.BackgroundImage = global::ClientApp.Properties.Resources.SNadawcza;
            this.BSendMessages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSendMessages.Location = new System.Drawing.Point(12, 270);
            this.BSendMessages.Name = "BSendMessages";
            this.BSendMessages.Size = new System.Drawing.Size(80, 80);
            this.BSendMessages.TabIndex = 3;
            this.toolTip.SetToolTip(this.BSendMessages, "Skrzynka nadawcza");
            this.BSendMessages.UseVisualStyleBackColor = true;
            this.BSendMessages.Click += new System.EventHandler(this.BSendMessages_Click);
            // 
            // BRevokeTheCertificate
            // 
            this.BRevokeTheCertificate.BackgroundImage = global::ClientApp.Properties.Resources.UniewaznijCert;
            this.BRevokeTheCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BRevokeTheCertificate.Location = new System.Drawing.Point(12, 184);
            this.BRevokeTheCertificate.Name = "BRevokeTheCertificate";
            this.BRevokeTheCertificate.Size = new System.Drawing.Size(80, 80);
            this.BRevokeTheCertificate.TabIndex = 2;
            this.toolTip.SetToolTip(this.BRevokeTheCertificate, "Unieważnij certyfikat");
            this.BRevokeTheCertificate.UseVisualStyleBackColor = true;
            this.BRevokeTheCertificate.Click += new System.EventHandler(this.BRevokeTheCertificate_Click);
            // 
            // BGetTheCertificate
            // 
            this.BGetTheCertificate.BackgroundImage = global::ClientApp.Properties.Resources.PobierzCert;
            this.BGetTheCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BGetTheCertificate.Location = new System.Drawing.Point(12, 98);
            this.BGetTheCertificate.Name = "BGetTheCertificate";
            this.BGetTheCertificate.Size = new System.Drawing.Size(80, 80);
            this.BGetTheCertificate.TabIndex = 1;
            this.toolTip.SetToolTip(this.BGetTheCertificate, "Pobierz certyfikat");
            this.BGetTheCertificate.UseVisualStyleBackColor = true;
            this.BGetTheCertificate.Click += new System.EventHandler(this.BGetTheCertificate_Click);
            // 
            // BApplyForTheCertificate
            // 
            this.BApplyForTheCertificate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BApplyForTheCertificate.BackgroundImage")));
            this.BApplyForTheCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BApplyForTheCertificate.Location = new System.Drawing.Point(12, 12);
            this.BApplyForTheCertificate.Name = "BApplyForTheCertificate";
            this.BApplyForTheCertificate.Size = new System.Drawing.Size(80, 80);
            this.BApplyForTheCertificate.TabIndex = 0;
            this.toolTip.SetToolTip(this.BApplyForTheCertificate, "Złóż wniosek o wydanie certyfikatu");
            this.BApplyForTheCertificate.UseVisualStyleBackColor = true;
            this.BApplyForTheCertificate.Click += new System.EventHandler(this.BApplyForTheCertificate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 449);
            this.Controls.Add(this.TBMessageR);
            this.Controls.Add(this.DGVMessagesR);
            this.Controls.Add(this.PSendMessage);
            this.Controls.Add(this.TBMessageS);
            this.Controls.Add(this.PGetMessage);
            this.Controls.Add(this.BGetMessagess);
            this.Controls.Add(this.BSendMessages);
            this.Controls.Add(this.BRevokeTheCertificate);
            this.Controls.Add(this.BGetTheCertificate);
            this.Controls.Add(this.BApplyForTheCertificate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klient PKI";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMessagesR)).EndInit();
            this.PSendMessage.ResumeLayout(false);
            this.PSendMessage.PerformLayout();
            this.PGetMessage.ResumeLayout(false);
            this.PGetMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BApplyForTheCertificate;
        private System.Windows.Forms.Button BGetTheCertificate;
        private System.Windows.Forms.Button BRevokeTheCertificate;
        private System.Windows.Forms.Button BSendMessages;
        private System.Windows.Forms.Button BGetMessagess;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel PSendMessage;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox CBRecNames;
        private System.Windows.Forms.Label LSender;
        private System.Windows.Forms.Panel PGetMessage;
        private System.Windows.Forms.Label LTopicS;
        private System.Windows.Forms.TextBox TBTopicS;
        private System.Windows.Forms.TextBox TBRecipient;
        private System.Windows.Forms.Label LRecipient;
        private System.Windows.Forms.TextBox TBMessageS;
        private System.Windows.Forms.Button BSend;
        private System.Windows.Forms.Label LTopicR;
        private System.Windows.Forms.DataGridView DGVMessagesR;
        private System.Windows.Forms.TextBox TBMessageR;
    }
}

