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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.DGVMessagesR = new System.Windows.Forms.DataGridView();
            this.BGetMessagess = new System.Windows.Forms.Button();
            this.BSendMessages = new System.Windows.Forms.Button();
            this.BRevokeTheCertificate = new System.Windows.Forms.Button();
            this.BApplyForTheCertificate = new System.Windows.Forms.Button();
            this.PSendMessage = new System.Windows.Forms.Panel();
            this.LTopicR = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BSend = new System.Windows.Forms.Button();
            this.CBRecNames = new System.Windows.Forms.ComboBox();
            this.LRecipient = new System.Windows.Forms.Label();
            this.LSender = new System.Windows.Forms.Label();
            this.PGetMessage = new System.Windows.Forms.Panel();
            this.LTopicS = new System.Windows.Forms.Label();
            this.TBTopicS = new System.Windows.Forms.TextBox();
            this.TBSender = new System.Windows.Forms.TextBox();
            this.TBMessageS = new System.Windows.Forms.TextBox();
            this.TBMessageR = new System.Windows.Forms.TextBox();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyEMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMessagesR)).BeginInit();
            this.PSendMessage.SuspendLayout();
            this.PGetMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVMessagesR
            // 
            this.DGVMessagesR.AllowUserToAddRows = false;
            this.DGVMessagesR.AllowUserToDeleteRows = false;
            this.DGVMessagesR.AllowUserToResizeColumns = false;
            this.DGVMessagesR.AllowUserToResizeRows = false;
            this.DGVMessagesR.BackgroundColor = System.Drawing.Color.White;
            this.DGVMessagesR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVMessagesR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMessagesR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MessageID,
            this.CompanyEMail,
            this.Topic});
            this.DGVMessagesR.Location = new System.Drawing.Point(35, 154);
            this.DGVMessagesR.MultiSelect = false;
            this.DGVMessagesR.Name = "DGVMessagesR";
            this.DGVMessagesR.ReadOnly = true;
            this.DGVMessagesR.RowHeadersVisible = false;
            this.DGVMessagesR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVMessagesR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMessagesR.Size = new System.Drawing.Size(265, 282);
            this.DGVMessagesR.TabIndex = 9;
            this.toolTip.SetToolTip(this.DGVMessagesR, "\r\n");
            this.DGVMessagesR.Visible = false;
            this.DGVMessagesR.SelectionChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // BGetMessagess
            // 
            this.BGetMessagess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BGetMessagess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BGetMessagess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BGetMessagess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGetMessagess.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.BGetMessagess.ForeColor = System.Drawing.Color.Black;
            this.BGetMessagess.Location = new System.Drawing.Point(34, 98);
            this.BGetMessagess.Name = "BGetMessagess";
            this.BGetMessagess.Size = new System.Drawing.Size(131, 40);
            this.BGetMessagess.TabIndex = 1;
            this.BGetMessagess.Text = "Skrzynka odbiorcza";
            this.toolTip.SetToolTip(this.BGetMessagess, "Skrzynka odbiorcza");
            this.BGetMessagess.UseVisualStyleBackColor = false;
            this.BGetMessagess.Click += new System.EventHandler(this.BGetMessagess_Click);
            // 
            // BSendMessages
            // 
            this.BSendMessages.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BSendMessages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSendMessages.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.BSendMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSendMessages.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.BSendMessages.ForeColor = System.Drawing.Color.Black;
            this.BSendMessages.Location = new System.Drawing.Point(173, 97);
            this.BSendMessages.Name = "BSendMessages";
            this.BSendMessages.Size = new System.Drawing.Size(131, 41);
            this.BSendMessages.TabIndex = 2;
            this.BSendMessages.Text = "Nowa wiadomość";
            this.toolTip.SetToolTip(this.BSendMessages, "Skrzynka nadawcza");
            this.BSendMessages.UseVisualStyleBackColor = false;
            this.BSendMessages.Click += new System.EventHandler(this.BSendMessages_Click);
            // 
            // BRevokeTheCertificate
            // 
            this.BRevokeTheCertificate.BackColor = System.Drawing.Color.Tomato;
            this.BRevokeTheCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BRevokeTheCertificate.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.BRevokeTheCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRevokeTheCertificate.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.BRevokeTheCertificate.ForeColor = System.Drawing.Color.Black;
            this.BRevokeTheCertificate.Location = new System.Drawing.Point(450, 97);
            this.BRevokeTheCertificate.Name = "BRevokeTheCertificate";
            this.BRevokeTheCertificate.Size = new System.Drawing.Size(131, 40);
            this.BRevokeTheCertificate.TabIndex = 4;
            this.BRevokeTheCertificate.Text = "Unieważnij certyfikat";
            this.toolTip.SetToolTip(this.BRevokeTheCertificate, "Unieważnij certyfikat");
            this.BRevokeTheCertificate.UseVisualStyleBackColor = false;
            this.BRevokeTheCertificate.Click += new System.EventHandler(this.BRevokeTheCertificate_Click);
            // 
            // BApplyForTheCertificate
            // 
            this.BApplyForTheCertificate.BackColor = System.Drawing.Color.Gold;
            this.BApplyForTheCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BApplyForTheCertificate.FlatAppearance.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.BApplyForTheCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BApplyForTheCertificate.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BApplyForTheCertificate.ForeColor = System.Drawing.Color.Black;
            this.BApplyForTheCertificate.Location = new System.Drawing.Point(311, 97);
            this.BApplyForTheCertificate.Name = "BApplyForTheCertificate";
            this.BApplyForTheCertificate.Size = new System.Drawing.Size(131, 40);
            this.BApplyForTheCertificate.TabIndex = 3;
            this.BApplyForTheCertificate.Text = "Złóż wniosek \r\no wydanie certyfikatu";
            this.toolTip.SetToolTip(this.BApplyForTheCertificate, "Złóż wniosek o wydanie certyfikatu");
            this.BApplyForTheCertificate.UseVisualStyleBackColor = false;
            this.BApplyForTheCertificate.Click += new System.EventHandler(this.BApplyForTheCertificate_Click);
            // 
            // PSendMessage
            // 
            this.PSendMessage.BackColor = System.Drawing.Color.Transparent;
            this.PSendMessage.Controls.Add(this.LTopicR);
            this.PSendMessage.Controls.Add(this.textBox2);
            this.PSendMessage.Controls.Add(this.BSend);
            this.PSendMessage.Controls.Add(this.CBRecNames);
            this.PSendMessage.Controls.Add(this.LRecipient);
            this.PSendMessage.Location = new System.Drawing.Point(34, 12);
            this.PSendMessage.Name = "PSendMessage";
            this.PSendMessage.Size = new System.Drawing.Size(559, 80);
            this.PSendMessage.TabIndex = 5;
            // 
            // LTopicR
            // 
            this.LTopicR.AutoSize = true;
            this.LTopicR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTopicR.Location = new System.Drawing.Point(22, 46);
            this.LTopicR.Name = "LTopicR";
            this.LTopicR.Size = new System.Drawing.Size(40, 13);
            this.LTopicR.TabIndex = 5;
            this.LTopicR.Text = "Temat:";
            this.LTopicR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(68, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(393, 20);
            this.textBox2.TabIndex = 4;
            // 
            // BSend
            // 
            this.BSend.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BSend.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSend.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BSend.ForeColor = System.Drawing.Color.White;
            this.BSend.Location = new System.Drawing.Point(474, 15);
            this.BSend.Name = "BSend";
            this.BSend.Size = new System.Drawing.Size(72, 49);
            this.BSend.TabIndex = 8;
            this.BSend.Text = "Wyślij";
            this.BSend.UseVisualStyleBackColor = false;
            // 
            // CBRecNames
            // 
            this.CBRecNames.FormattingEnabled = true;
            this.CBRecNames.Location = new System.Drawing.Point(68, 15);
            this.CBRecNames.Name = "CBRecNames";
            this.CBRecNames.Size = new System.Drawing.Size(393, 21);
            this.CBRecNames.TabIndex = 1;
            // 
            // LRecipient
            // 
            this.LRecipient.AutoSize = true;
            this.LRecipient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LRecipient.Location = new System.Drawing.Point(10, 18);
            this.LRecipient.Name = "LRecipient";
            this.LRecipient.Size = new System.Drawing.Size(52, 13);
            this.LRecipient.TabIndex = 1;
            this.LRecipient.Text = "Wyślij do:";
            this.LRecipient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LSender
            // 
            this.LSender.AutoSize = true;
            this.LSender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LSender.Location = new System.Drawing.Point(5, 18);
            this.LSender.Name = "LSender";
            this.LSender.Size = new System.Drawing.Size(56, 13);
            this.LSender.TabIndex = 0;
            this.LSender.Text = "Nadawca:";
            this.LSender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PGetMessage
            // 
            this.PGetMessage.BackColor = System.Drawing.Color.Transparent;
            this.PGetMessage.Controls.Add(this.LTopicS);
            this.PGetMessage.Controls.Add(this.TBTopicS);
            this.PGetMessage.Controls.Add(this.LSender);
            this.PGetMessage.Controls.Add(this.TBSender);
            this.PGetMessage.Location = new System.Drawing.Point(34, 12);
            this.PGetMessage.Name = "PGetMessage";
            this.PGetMessage.Size = new System.Drawing.Size(559, 80);
            this.PGetMessage.TabIndex = 6;
            // 
            // LTopicS
            // 
            this.LTopicS.AutoSize = true;
            this.LTopicS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTopicS.Location = new System.Drawing.Point(21, 46);
            this.LTopicS.Name = "LTopicS";
            this.LTopicS.Size = new System.Drawing.Size(40, 13);
            this.LTopicS.TabIndex = 4;
            this.LTopicS.Text = "Temat:";
            this.LTopicS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBTopicS
            // 
            this.TBTopicS.Location = new System.Drawing.Point(68, 44);
            this.TBTopicS.Name = "TBTopicS";
            this.TBTopicS.ReadOnly = true;
            this.TBTopicS.Size = new System.Drawing.Size(476, 20);
            this.TBTopicS.TabIndex = 3;
            // 
            // TBSender
            // 
            this.TBSender.Location = new System.Drawing.Point(68, 15);
            this.TBSender.Name = "TBSender";
            this.TBSender.ReadOnly = true;
            this.TBSender.Size = new System.Drawing.Size(476, 20);
            this.TBSender.TabIndex = 2;
            // 
            // TBMessageS
            // 
            this.TBMessageS.Location = new System.Drawing.Point(35, 154);
            this.TBMessageS.Multiline = true;
            this.TBMessageS.Name = "TBMessageS";
            this.TBMessageS.Size = new System.Drawing.Size(545, 282);
            this.TBMessageS.TabIndex = 7;
            // 
            // TBMessageR
            // 
            this.TBMessageR.Enabled = false;
            this.TBMessageR.Location = new System.Drawing.Point(315, 154);
            this.TBMessageR.Multiline = true;
            this.TBMessageR.Name = "TBMessageR";
            this.TBMessageR.ReadOnly = true;
            this.TBMessageR.Size = new System.Drawing.Size(265, 282);
            this.TBMessageR.TabIndex = 10;
            this.TBMessageR.Visible = false;
            this.TBMessageR.WordWrap = false;
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Temat";
            this.Topic.Name = "Topic";
            this.Topic.ReadOnly = true;
            this.Topic.Width = 145;
            // 
            // CompanyEMail
            // 
            this.CompanyEMail.HeaderText = "Nadawca";
            this.CompanyEMail.Name = "CompanyEMail";
            this.CompanyEMail.ReadOnly = true;
            // 
            // MessageID
            // 
            this.MessageID.HeaderText = "MessageID";
            this.MessageID.Name = "MessageID";
            this.MessageID.ReadOnly = true;
            this.MessageID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MessageID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ClientApp.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(615, 466);
            this.Controls.Add(this.TBMessageR);
            this.Controls.Add(this.DGVMessagesR);
            this.Controls.Add(this.PSendMessage);
            this.Controls.Add(this.TBMessageS);
            this.Controls.Add(this.PGetMessage);
            this.Controls.Add(this.BGetMessagess);
            this.Controls.Add(this.BSendMessages);
            this.Controls.Add(this.BRevokeTheCertificate);
            this.Controls.Add(this.BApplyForTheCertificate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klient PKI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogOut);
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
        private System.Windows.Forms.TextBox TBSender;
        private System.Windows.Forms.Label LRecipient;
        private System.Windows.Forms.TextBox TBMessageS;
        private System.Windows.Forms.Button BSend;
        private System.Windows.Forms.Label LTopicR;
        private System.Windows.Forms.DataGridView DGVMessagesR;
        private System.Windows.Forms.TextBox TBMessageR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyEMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
    }
}

