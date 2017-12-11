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
            this.DGVMessagesR = new System.Windows.Forms.DataGridView();
            this.MessageID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyEMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BGetMessagess = new System.Windows.Forms.Button();
            this.BSendMessages = new System.Windows.Forms.Button();
            this.BRevokeTheCertificate = new System.Windows.Forms.Button();
            this.BApplyForTheCertificate = new System.Windows.Forms.Button();
            this.BInBox = new System.Windows.Forms.Button();
            this.DGVMessagesS = new System.Windows.Forms.DataGridView();
            this.MessageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PSendMessage = new System.Windows.Forms.Panel();
            this.LTopicR = new System.Windows.Forms.Label();
            this.TBTopic = new System.Windows.Forms.TextBox();
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
            this.PMessageS = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TBSenderTopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBSenderMsg = new System.Windows.Forms.TextBox();
            this.BClose = new System.Windows.Forms.Button();
            this.BHide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMessagesR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMessagesS)).BeginInit();
            this.PSendMessage.SuspendLayout();
            this.PGetMessage.SuspendLayout();
            this.PMessageS.SuspendLayout();
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
            this.MessageID1,
            this.CompanyEMail,
            this.Topic,
            this.Date});
            this.DGVMessagesR.Location = new System.Drawing.Point(35, 176);
            this.DGVMessagesR.MultiSelect = false;
            this.DGVMessagesR.Name = "DGVMessagesR";
            this.DGVMessagesR.ReadOnly = true;
            this.DGVMessagesR.RowHeadersVisible = false;
            this.DGVMessagesR.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVMessagesR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMessagesR.Size = new System.Drawing.Size(404, 282);
            this.DGVMessagesR.TabIndex = 9;
            this.DGVMessagesR.Visible = false;
            this.DGVMessagesR.SelectionChanged += new System.EventHandler(this.InboxSelectionChanged);
            // 
            // MessageID1
            // 
            this.MessageID1.HeaderText = "MessageID";
            this.MessageID1.Name = "MessageID1";
            this.MessageID1.ReadOnly = true;
            this.MessageID1.Visible = false;
            // 
            // CompanyEMail
            // 
            this.CompanyEMail.HeaderText = "Nadawca";
            this.CompanyEMail.Name = "CompanyEMail";
            this.CompanyEMail.ReadOnly = true;
            this.CompanyEMail.Width = 124;
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Temat";
            this.Topic.Name = "Topic";
            this.Topic.ReadOnly = true;
            this.Topic.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Data wysłania";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 110;
            // 
            // BGetMessagess
            // 
            this.BGetMessagess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BGetMessagess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BGetMessagess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BGetMessagess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BGetMessagess.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.BGetMessagess.ForeColor = System.Drawing.Color.Black;
            this.BGetMessagess.Location = new System.Drawing.Point(308, 130);
            this.BGetMessagess.Name = "BGetMessagess";
            this.BGetMessagess.Size = new System.Drawing.Size(131, 40);
            this.BGetMessagess.TabIndex = 1;
            this.BGetMessagess.Text = "Skrzynka odbiorcza";
            this.BGetMessagess.UseVisualStyleBackColor = false;
            this.BGetMessagess.Click += new System.EventHandler(this.BGetMessagess_Click);
            // 
            // BSendMessages
            // 
            this.BSendMessages.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BSendMessages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BSendMessages.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BSendMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSendMessages.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.BSendMessages.ForeColor = System.Drawing.Color.Black;
            this.BSendMessages.Location = new System.Drawing.Point(34, 130);
            this.BSendMessages.Name = "BSendMessages";
            this.BSendMessages.Size = new System.Drawing.Size(131, 40);
            this.BSendMessages.TabIndex = 2;
            this.BSendMessages.Text = "Nowa wiadomość";
            this.BSendMessages.UseVisualStyleBackColor = false;
            this.BSendMessages.Click += new System.EventHandler(this.BSendMessages_Click);
            // 
            // BRevokeTheCertificate
            // 
            this.BRevokeTheCertificate.BackColor = System.Drawing.Color.Salmon;
            this.BRevokeTheCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BRevokeTheCertificate.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.BRevokeTheCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRevokeTheCertificate.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.BRevokeTheCertificate.ForeColor = System.Drawing.Color.Black;
            this.BRevokeTheCertificate.Location = new System.Drawing.Point(582, 130);
            this.BRevokeTheCertificate.Name = "BRevokeTheCertificate";
            this.BRevokeTheCertificate.Size = new System.Drawing.Size(131, 40);
            this.BRevokeTheCertificate.TabIndex = 4;
            this.BRevokeTheCertificate.Text = "Unieważnij certyfikat";
            this.BRevokeTheCertificate.UseVisualStyleBackColor = false;
            this.BRevokeTheCertificate.Click += new System.EventHandler(this.BRevokeTheCertificate_Click);
            // 
            // BApplyForTheCertificate
            // 
            this.BApplyForTheCertificate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BApplyForTheCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BApplyForTheCertificate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BApplyForTheCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BApplyForTheCertificate.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BApplyForTheCertificate.ForeColor = System.Drawing.Color.Black;
            this.BApplyForTheCertificate.Location = new System.Drawing.Point(445, 130);
            this.BApplyForTheCertificate.Name = "BApplyForTheCertificate";
            this.BApplyForTheCertificate.Size = new System.Drawing.Size(131, 40);
            this.BApplyForTheCertificate.TabIndex = 3;
            this.BApplyForTheCertificate.Text = "Złóż wniosek \r\no wydanie certyfikatu";
            this.BApplyForTheCertificate.UseVisualStyleBackColor = false;
            this.BApplyForTheCertificate.Click += new System.EventHandler(this.BApplyForTheCertificate_Click);
            // 
            // BInBox
            // 
            this.BInBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BInBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BInBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BInBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.BInBox.ForeColor = System.Drawing.Color.Black;
            this.BInBox.Location = new System.Drawing.Point(171, 130);
            this.BInBox.Name = "BInBox";
            this.BInBox.Size = new System.Drawing.Size(131, 40);
            this.BInBox.TabIndex = 11;
            this.BInBox.Text = "Skrzynka nadawcza";
            this.BInBox.UseVisualStyleBackColor = false;
            this.BInBox.Click += new System.EventHandler(this.BInBox_Click);
            // 
            // DGVMessagesS
            // 
            this.DGVMessagesS.AllowUserToAddRows = false;
            this.DGVMessagesS.AllowUserToDeleteRows = false;
            this.DGVMessagesS.AllowUserToResizeColumns = false;
            this.DGVMessagesS.AllowUserToResizeRows = false;
            this.DGVMessagesS.BackgroundColor = System.Drawing.Color.White;
            this.DGVMessagesS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVMessagesS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMessagesS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MessageID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Date1});
            this.DGVMessagesS.Location = new System.Drawing.Point(35, 176);
            this.DGVMessagesS.MultiSelect = false;
            this.DGVMessagesS.Name = "DGVMessagesS";
            this.DGVMessagesS.ReadOnly = true;
            this.DGVMessagesS.RowHeadersVisible = false;
            this.DGVMessagesS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVMessagesS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMessagesS.Size = new System.Drawing.Size(404, 282);
            this.DGVMessagesS.TabIndex = 12;
            this.DGVMessagesS.Visible = false;
            this.DGVMessagesS.SelectionChanged += new System.EventHandler(this.OutboxSelectionChanged);
            // 
            // MessageID
            // 
            this.MessageID.HeaderText = "MessageID";
            this.MessageID.Name = "MessageID";
            this.MessageID.ReadOnly = true;
            this.MessageID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Odbiorca";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 124;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Temat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Date1
            // 
            this.Date1.HeaderText = "Data wysłania";
            this.Date1.Name = "Date1";
            this.Date1.ReadOnly = true;
            this.Date1.Width = 110;
            // 
            // PSendMessage
            // 
            this.PSendMessage.BackColor = System.Drawing.Color.Transparent;
            this.PSendMessage.Controls.Add(this.LTopicR);
            this.PSendMessage.Controls.Add(this.TBTopic);
            this.PSendMessage.Controls.Add(this.BSend);
            this.PSendMessage.Controls.Add(this.CBRecNames);
            this.PSendMessage.Controls.Add(this.LRecipient);
            this.PSendMessage.Location = new System.Drawing.Point(34, 44);
            this.PSendMessage.Name = "PSendMessage";
            this.PSendMessage.Size = new System.Drawing.Size(679, 80);
            this.PSendMessage.TabIndex = 5;
            // 
            // LTopicR
            // 
            this.LTopicR.AutoSize = true;
            this.LTopicR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LTopicR.Location = new System.Drawing.Point(22, 46);
            this.LTopicR.Name = "LTopicR";
            this.LTopicR.Size = new System.Drawing.Size(40, 13);
            this.LTopicR.TabIndex = 5;
            this.LTopicR.Text = "Temat:";
            this.LTopicR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBTopic
            // 
            this.TBTopic.Location = new System.Drawing.Point(68, 44);
            this.TBTopic.Name = "TBTopic";
            this.TBTopic.Size = new System.Drawing.Size(533, 20);
            this.TBTopic.TabIndex = 4;
            // 
            // BSend
            // 
            this.BSend.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BSend.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSend.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BSend.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BSend.Location = new System.Drawing.Point(607, 15);
            this.BSend.Name = "BSend";
            this.BSend.Size = new System.Drawing.Size(72, 49);
            this.BSend.TabIndex = 8;
            this.BSend.Text = "Wyślij";
            this.BSend.UseVisualStyleBackColor = false;
            this.BSend.Click += new System.EventHandler(this.BSend_Click);
            // 
            // CBRecNames
            // 
            this.CBRecNames.FormattingEnabled = true;
            this.CBRecNames.Location = new System.Drawing.Point(68, 15);
            this.CBRecNames.Name = "CBRecNames";
            this.CBRecNames.Size = new System.Drawing.Size(533, 21);
            this.CBRecNames.TabIndex = 1;
            // 
            // LRecipient
            // 
            this.LRecipient.AutoSize = true;
            this.LRecipient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.LSender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.PGetMessage.Location = new System.Drawing.Point(34, 44);
            this.PGetMessage.Name = "PGetMessage";
            this.PGetMessage.Size = new System.Drawing.Size(679, 80);
            this.PGetMessage.TabIndex = 6;
            // 
            // LTopicS
            // 
            this.LTopicS.AutoSize = true;
            this.LTopicS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LTopicS.Location = new System.Drawing.Point(21, 46);
            this.LTopicS.Name = "LTopicS";
            this.LTopicS.Size = new System.Drawing.Size(40, 13);
            this.LTopicS.TabIndex = 4;
            this.LTopicS.Text = "Temat:";
            this.LTopicS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBTopicS
            // 
            this.TBTopicS.BackColor = System.Drawing.Color.White;
            this.TBTopicS.Location = new System.Drawing.Point(68, 44);
            this.TBTopicS.Name = "TBTopicS";
            this.TBTopicS.ReadOnly = true;
            this.TBTopicS.Size = new System.Drawing.Size(611, 20);
            this.TBTopicS.TabIndex = 3;
            // 
            // TBSender
            // 
            this.TBSender.BackColor = System.Drawing.Color.White;
            this.TBSender.Location = new System.Drawing.Point(68, 15);
            this.TBSender.Name = "TBSender";
            this.TBSender.ReadOnly = true;
            this.TBSender.Size = new System.Drawing.Size(611, 20);
            this.TBSender.TabIndex = 2;
            // 
            // TBMessageS
            // 
            this.TBMessageS.Location = new System.Drawing.Point(35, 176);
            this.TBMessageS.Multiline = true;
            this.TBMessageS.Name = "TBMessageS";
            this.TBMessageS.Size = new System.Drawing.Size(678, 282);
            this.TBMessageS.TabIndex = 7;
            // 
            // TBMessageR
            // 
            this.TBMessageR.BackColor = System.Drawing.Color.White;
            this.TBMessageR.Enabled = false;
            this.TBMessageR.Location = new System.Drawing.Point(445, 176);
            this.TBMessageR.Multiline = true;
            this.TBMessageR.Name = "TBMessageR";
            this.TBMessageR.ReadOnly = true;
            this.TBMessageR.Size = new System.Drawing.Size(268, 282);
            this.TBMessageR.TabIndex = 10;
            this.TBMessageR.Visible = false;
            this.TBMessageR.WordWrap = false;
            // 
            // PMessageS
            // 
            this.PMessageS.BackColor = System.Drawing.Color.Transparent;
            this.PMessageS.Controls.Add(this.label1);
            this.PMessageS.Controls.Add(this.TBSenderTopic);
            this.PMessageS.Controls.Add(this.label2);
            this.PMessageS.Controls.Add(this.TBSenderMsg);
            this.PMessageS.Location = new System.Drawing.Point(34, 44);
            this.PMessageS.Name = "PMessageS";
            this.PMessageS.Size = new System.Drawing.Size(679, 80);
            this.PMessageS.TabIndex = 7;
            this.PMessageS.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Temat:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBSenderTopic
            // 
            this.TBSenderTopic.BackColor = System.Drawing.Color.White;
            this.TBSenderTopic.Location = new System.Drawing.Point(68, 44);
            this.TBSenderTopic.Name = "TBSenderTopic";
            this.TBSenderTopic.ReadOnly = true;
            this.TBSenderTopic.Size = new System.Drawing.Size(611, 20);
            this.TBSenderTopic.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Odbiorca:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBSenderMsg
            // 
            this.TBSenderMsg.BackColor = System.Drawing.Color.White;
            this.TBSenderMsg.Location = new System.Drawing.Point(68, 15);
            this.TBSenderMsg.Name = "TBSenderMsg";
            this.TBSenderMsg.ReadOnly = true;
            this.TBSenderMsg.Size = new System.Drawing.Size(611, 20);
            this.TBSenderMsg.TabIndex = 2;
            // 
            // BClose
            // 
            this.BClose.BackColor = System.Drawing.Color.Transparent;
            this.BClose.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClose.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BClose.ForeColor = System.Drawing.Color.LightGray;
            this.BClose.Location = new System.Drawing.Point(713, 9);
            this.BClose.Margin = new System.Windows.Forms.Padding(0);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(28, 24);
            this.BClose.TabIndex = 26;
            this.BClose.Text = "X";
            this.BClose.UseVisualStyleBackColor = false;
            this.BClose.Click += new System.EventHandler(this.BClose_Click_1);
            // 
            // BHide
            // 
            this.BHide.BackColor = System.Drawing.Color.Transparent;
            this.BHide.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.BHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.BHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BHide.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BHide.ForeColor = System.Drawing.Color.LightGray;
            this.BHide.Location = new System.Drawing.Point(676, 9);
            this.BHide.Margin = new System.Windows.Forms.Padding(0);
            this.BHide.Name = "BHide";
            this.BHide.Size = new System.Drawing.Size(28, 24);
            this.BHide.TabIndex = 27;
            this.BHide.Text = "_";
            this.BHide.UseVisualStyleBackColor = false;
            this.BHide.Click += new System.EventHandler(this.BHide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ClientApp.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 494);
            this.Controls.Add(this.BHide);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.DGVMessagesS);
            this.Controls.Add(this.PMessageS);
            this.Controls.Add(this.BInBox);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klient PKI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogOut);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMessagesR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMessagesS)).EndInit();
            this.PSendMessage.ResumeLayout(false);
            this.PSendMessage.PerformLayout();
            this.PGetMessage.ResumeLayout(false);
            this.PGetMessage.PerformLayout();
            this.PMessageS.ResumeLayout(false);
            this.PMessageS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BApplyForTheCertificate;
        private System.Windows.Forms.Button BRevokeTheCertificate;
        private System.Windows.Forms.Button BSendMessages;
        private System.Windows.Forms.Button BGetMessagess;
        private System.Windows.Forms.Panel PSendMessage;
        private System.Windows.Forms.TextBox TBTopic;
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
        private System.Windows.Forms.Button BInBox;
        private System.Windows.Forms.Panel PMessageS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBSenderTopic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBSenderMsg;
        private System.Windows.Forms.DataGridView DGVMessagesS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyEMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date1;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Button BHide;
    }
}

