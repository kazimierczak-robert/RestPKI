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
            this.DGVInBox = new System.Windows.Forms.DataGridView();
            this.MessageID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyEMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BInBox = new System.Windows.Forms.Button();
            this.BNewMessage = new System.Windows.Forms.Button();
            this.BRevokeTheCertificate = new System.Windows.Forms.Button();
            this.BApplyForTheCertificate = new System.Windows.Forms.Button();
            this.BOutBox = new System.Windows.Forms.Button();
            this.DGVOutBox = new System.Windows.Forms.DataGridView();
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
            this.PInBox = new System.Windows.Forms.Panel();
            this.LTopicS = new System.Windows.Forms.Label();
            this.TBTopicS = new System.Windows.Forms.TextBox();
            this.TBSender = new System.Windows.Forms.TextBox();
            this.TBMessageS = new System.Windows.Forms.TextBox();
            this.TBMessageR = new System.Windows.Forms.TextBox();
            this.POutBox = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TBSenderTopic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBSenderMsg = new System.Windows.Forms.TextBox();
            this.BClose = new System.Windows.Forms.Button();
            this.BHide = new System.Windows.Forms.Button();
            this.RBReceiver = new System.Windows.Forms.RadioButton();
            this.RBTopic = new System.Windows.Forms.RadioButton();
            this.RBSentDate = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LLogged = new System.Windows.Forms.Label();
            this.BChangePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOutBox)).BeginInit();
            this.PSendMessage.SuspendLayout();
            this.PInBox.SuspendLayout();
            this.POutBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVInBox
            // 
            this.DGVInBox.AllowUserToAddRows = false;
            this.DGVInBox.AllowUserToDeleteRows = false;
            this.DGVInBox.AllowUserToResizeColumns = false;
            this.DGVInBox.AllowUserToResizeRows = false;
            this.DGVInBox.BackgroundColor = System.Drawing.Color.White;
            this.DGVInBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVInBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MessageID1,
            this.CompanyEMail,
            this.Topic,
            this.Date});
            this.DGVInBox.Location = new System.Drawing.Point(35, 220);
            this.DGVInBox.MultiSelect = false;
            this.DGVInBox.Name = "DGVInBox";
            this.DGVInBox.ReadOnly = true;
            this.DGVInBox.RowHeadersVisible = false;
            this.DGVInBox.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVInBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVInBox.Size = new System.Drawing.Size(404, 282);
            this.DGVInBox.TabIndex = 9;
            this.DGVInBox.Visible = false;
            this.DGVInBox.SelectionChanged += new System.EventHandler(this.InboxSelectionChanged);
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
            // BInBox
            // 
            this.BInBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BInBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BInBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BInBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BInBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.BInBox.ForeColor = System.Drawing.Color.Black;
            this.BInBox.Location = new System.Drawing.Point(264, 174);
            this.BInBox.Name = "BInBox";
            this.BInBox.Size = new System.Drawing.Size(103, 40);
            this.BInBox.TabIndex = 1;
            this.BInBox.Text = "Skrzynka odbiorcza";
            this.BInBox.UseVisualStyleBackColor = false;
            this.BInBox.Click += new System.EventHandler(this.BInBox_Click);
            // 
            // BNewMessage
            // 
            this.BNewMessage.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BNewMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BNewMessage.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.BNewMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BNewMessage.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.BNewMessage.ForeColor = System.Drawing.Color.Gray;
            this.BNewMessage.Location = new System.Drawing.Point(34, 174);
            this.BNewMessage.Name = "BNewMessage";
            this.BNewMessage.Size = new System.Drawing.Size(103, 40);
            this.BNewMessage.TabIndex = 2;
            this.BNewMessage.Text = "Nowa wiadomość";
            this.BNewMessage.UseVisualStyleBackColor = false;
            this.BNewMessage.Click += new System.EventHandler(this.BNewMessage_Click);
            // 
            // BRevokeTheCertificate
            // 
            this.BRevokeTheCertificate.BackColor = System.Drawing.Color.LightSalmon;
            this.BRevokeTheCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BRevokeTheCertificate.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.BRevokeTheCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BRevokeTheCertificate.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.BRevokeTheCertificate.ForeColor = System.Drawing.Color.Gray;
            this.BRevokeTheCertificate.Location = new System.Drawing.Point(495, 174);
            this.BRevokeTheCertificate.Name = "BRevokeTheCertificate";
            this.BRevokeTheCertificate.Size = new System.Drawing.Size(103, 40);
            this.BRevokeTheCertificate.TabIndex = 4;
            this.BRevokeTheCertificate.Text = "Unieważnij certyfikat";
            this.BRevokeTheCertificate.UseVisualStyleBackColor = false;
            this.BRevokeTheCertificate.Click += new System.EventHandler(this.BRevokeTheCertificate_Click);
            // 
            // BApplyForTheCertificate
            // 
            this.BApplyForTheCertificate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BApplyForTheCertificate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BApplyForTheCertificate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BApplyForTheCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BApplyForTheCertificate.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BApplyForTheCertificate.ForeColor = System.Drawing.Color.Gray;
            this.BApplyForTheCertificate.Location = new System.Drawing.Point(379, 174);
            this.BApplyForTheCertificate.Name = "BApplyForTheCertificate";
            this.BApplyForTheCertificate.Size = new System.Drawing.Size(103, 40);
            this.BApplyForTheCertificate.TabIndex = 3;
            this.BApplyForTheCertificate.Text = "Złóż wniosek \r\no wydanie certyfikatu";
            this.BApplyForTheCertificate.UseVisualStyleBackColor = false;
            this.BApplyForTheCertificate.Click += new System.EventHandler(this.BApplyForTheCertificate_Click);
            // 
            // BOutBox
            // 
            this.BOutBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BOutBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BOutBox.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BOutBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BOutBox.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.BOutBox.ForeColor = System.Drawing.Color.Gray;
            this.BOutBox.Location = new System.Drawing.Point(148, 174);
            this.BOutBox.Name = "BOutBox";
            this.BOutBox.Size = new System.Drawing.Size(103, 40);
            this.BOutBox.TabIndex = 11;
            this.BOutBox.Text = "Skrzynka nadawcza";
            this.BOutBox.UseVisualStyleBackColor = false;
            this.BOutBox.Click += new System.EventHandler(this.BOutBox_Click);
            // 
            // DGVOutBox
            // 
            this.DGVOutBox.AllowUserToAddRows = false;
            this.DGVOutBox.AllowUserToDeleteRows = false;
            this.DGVOutBox.AllowUserToResizeColumns = false;
            this.DGVOutBox.AllowUserToResizeRows = false;
            this.DGVOutBox.BackgroundColor = System.Drawing.Color.White;
            this.DGVOutBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVOutBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOutBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MessageID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Date1});
            this.DGVOutBox.Location = new System.Drawing.Point(35, 220);
            this.DGVOutBox.MultiSelect = false;
            this.DGVOutBox.Name = "DGVOutBox";
            this.DGVOutBox.ReadOnly = true;
            this.DGVOutBox.RowHeadersVisible = false;
            this.DGVOutBox.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVOutBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVOutBox.Size = new System.Drawing.Size(404, 282);
            this.DGVOutBox.TabIndex = 12;
            this.DGVOutBox.Visible = false;
            this.DGVOutBox.SelectionChanged += new System.EventHandler(this.OutboxSelectionChanged);
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
            // PInBox
            // 
            this.PInBox.BackColor = System.Drawing.Color.Transparent;
            this.PInBox.Controls.Add(this.LTopicS);
            this.PInBox.Controls.Add(this.TBTopicS);
            this.PInBox.Controls.Add(this.LSender);
            this.PInBox.Controls.Add(this.TBSender);
            this.PInBox.Location = new System.Drawing.Point(34, 44);
            this.PInBox.Name = "PInBox";
            this.PInBox.Size = new System.Drawing.Size(679, 80);
            this.PInBox.TabIndex = 6;
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
            this.TBMessageS.Location = new System.Drawing.Point(35, 220);
            this.TBMessageS.Multiline = true;
            this.TBMessageS.Name = "TBMessageS";
            this.TBMessageS.Size = new System.Drawing.Size(678, 282);
            this.TBMessageS.TabIndex = 7;
            // 
            // TBMessageR
            // 
            this.TBMessageR.BackColor = System.Drawing.Color.White;
            this.TBMessageR.Enabled = false;
            this.TBMessageR.Location = new System.Drawing.Point(445, 220);
            this.TBMessageR.Multiline = true;
            this.TBMessageR.Name = "TBMessageR";
            this.TBMessageR.ReadOnly = true;
            this.TBMessageR.Size = new System.Drawing.Size(268, 282);
            this.TBMessageR.TabIndex = 10;
            this.TBMessageR.Visible = false;
            this.TBMessageR.WordWrap = false;
            // 
            // POutBox
            // 
            this.POutBox.BackColor = System.Drawing.Color.Transparent;
            this.POutBox.Controls.Add(this.label1);
            this.POutBox.Controls.Add(this.TBSenderTopic);
            this.POutBox.Controls.Add(this.label2);
            this.POutBox.Controls.Add(this.TBSenderMsg);
            this.POutBox.Location = new System.Drawing.Point(34, 44);
            this.POutBox.Name = "POutBox";
            this.POutBox.Size = new System.Drawing.Size(679, 80);
            this.POutBox.TabIndex = 7;
            this.POutBox.Visible = false;
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
            // RBReceiver
            // 
            this.RBReceiver.AutoSize = true;
            this.RBReceiver.BackColor = System.Drawing.Color.Transparent;
            this.RBReceiver.Checked = true;
            this.RBReceiver.Location = new System.Drawing.Point(9, 4);
            this.RBReceiver.Name = "RBReceiver";
            this.RBReceiver.Size = new System.Drawing.Size(119, 17);
            this.RBReceiver.TabIndex = 28;
            this.RBReceiver.TabStop = true;
            this.RBReceiver.Text = "Nadawca/Odbiorca";
            this.RBReceiver.UseVisualStyleBackColor = false;
            this.RBReceiver.CheckedChanged += new System.EventHandler(this.RBCheckedChanged);
            // 
            // RBTopic
            // 
            this.RBTopic.AutoSize = true;
            this.RBTopic.BackColor = System.Drawing.Color.Transparent;
            this.RBTopic.Location = new System.Drawing.Point(131, 4);
            this.RBTopic.Name = "RBTopic";
            this.RBTopic.Size = new System.Drawing.Size(55, 17);
            this.RBTopic.TabIndex = 29;
            this.RBTopic.Text = "Temat";
            this.RBTopic.UseVisualStyleBackColor = false;
            this.RBTopic.CheckedChanged += new System.EventHandler(this.RBCheckedChanged);
            // 
            // RBSentDate
            // 
            this.RBSentDate.AutoSize = true;
            this.RBSentDate.BackColor = System.Drawing.Color.Transparent;
            this.RBSentDate.Location = new System.Drawing.Point(201, 4);
            this.RBSentDate.Name = "RBSentDate";
            this.RBSentDate.Size = new System.Drawing.Size(93, 17);
            this.RBSentDate.TabIndex = 30;
            this.RBSentDate.Text = "Data wysłania";
            this.RBSentDate.UseVisualStyleBackColor = false;
            this.RBSentDate.CheckedChanged += new System.EventHandler(this.RBCheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(5, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wyszukaj, używając:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBSearch
            // 
            this.TBSearch.BackColor = System.Drawing.Color.White;
            this.TBSearch.Location = new System.Drawing.Point(419, 11);
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(268, 20);
            this.TBSearch.TabIndex = 5;
            this.TBSearch.TextChanged += new System.EventHandler(this.SearchInDGV);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.RBReceiver);
            this.panel1.Controls.Add(this.RBTopic);
            this.panel1.Controls.Add(this.RBSentDate);
            this.panel1.Location = new System.Drawing.Point(117, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 26);
            this.panel1.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(419, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 20);
            this.dateTimePicker1.TabIndex = 32;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.SearchInDGV);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.TBSearch);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(26, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 38);
            this.panel2.TabIndex = 33;
            // 
            // LLogged
            // 
            this.LLogged.AutoSize = true;
            this.LLogged.BackColor = System.Drawing.Color.Transparent;
            this.LLogged.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.LLogged.Location = new System.Drawing.Point(31, 24);
            this.LLogged.Name = "LLogged";
            this.LLogged.Size = new System.Drawing.Size(127, 13);
            this.LLogged.TabIndex = 34;
            this.LLogged.Text = "Zalogowany użytkownik: ";
            // 
            // BChangePassword
            // 
            this.BChangePassword.BackColor = System.Drawing.Color.NavajoWhite;
            this.BChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.BChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BChangePassword.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F);
            this.BChangePassword.ForeColor = System.Drawing.Color.Gray;
            this.BChangePassword.Location = new System.Drawing.Point(610, 174);
            this.BChangePassword.Name = "BChangePassword";
            this.BChangePassword.Size = new System.Drawing.Size(103, 40);
            this.BChangePassword.TabIndex = 35;
            this.BChangePassword.Text = "Zmień hasło";
            this.BChangePassword.UseVisualStyleBackColor = false;
            this.BChangePassword.Click += new System.EventHandler(this.BChangePassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::ClientApp.Properties.Resources.background3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(749, 541);
            this.Controls.Add(this.BChangePassword);
            this.Controls.Add(this.LLogged);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.BHide);
            this.Controls.Add(this.BInBox);
            this.Controls.Add(this.BClose);
            this.Controls.Add(this.DGVOutBox);
            this.Controls.Add(this.POutBox);
            this.Controls.Add(this.BOutBox);
            this.Controls.Add(this.TBMessageR);
            this.Controls.Add(this.DGVInBox);
            this.Controls.Add(this.PSendMessage);
            this.Controls.Add(this.TBMessageS);
            this.Controls.Add(this.PInBox);
            this.Controls.Add(this.BNewMessage);
            this.Controls.Add(this.BRevokeTheCertificate);
            this.Controls.Add(this.BApplyForTheCertificate);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Klient PKI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogOut);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChangePassword_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.DGVInBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOutBox)).EndInit();
            this.PSendMessage.ResumeLayout(false);
            this.PSendMessage.PerformLayout();
            this.PInBox.ResumeLayout(false);
            this.PInBox.PerformLayout();
            this.POutBox.ResumeLayout(false);
            this.POutBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BApplyForTheCertificate;
        private System.Windows.Forms.Button BRevokeTheCertificate;
        private System.Windows.Forms.Button BNewMessage;
        private System.Windows.Forms.Button BInBox;
        private System.Windows.Forms.Panel PSendMessage;
        private System.Windows.Forms.TextBox TBTopic;
        private System.Windows.Forms.ComboBox CBRecNames;
        private System.Windows.Forms.Label LSender;
        private System.Windows.Forms.Panel PInBox;
        private System.Windows.Forms.Label LTopicS;
        private System.Windows.Forms.TextBox TBTopicS;
        private System.Windows.Forms.TextBox TBSender;
        private System.Windows.Forms.Label LRecipient;
        private System.Windows.Forms.TextBox TBMessageS;
        private System.Windows.Forms.Button BSend;
        private System.Windows.Forms.Label LTopicR;
        private System.Windows.Forms.DataGridView DGVInBox;
        private System.Windows.Forms.TextBox TBMessageR;
        private System.Windows.Forms.Button BOutBox;
        private System.Windows.Forms.Panel POutBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBSenderTopic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBSenderMsg;
        private System.Windows.Forms.DataGridView DGVOutBox;
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
        private System.Windows.Forms.RadioButton RBReceiver;
        private System.Windows.Forms.RadioButton RBTopic;
        private System.Windows.Forms.RadioButton RBSentDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LLogged;
        private System.Windows.Forms.Button BChangePassword;
    }
}

