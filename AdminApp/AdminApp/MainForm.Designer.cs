namespace AdminApp
{
    partial class MainForm
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
            this.BNewEmployee = new System.Windows.Forms.Button();
            this.DGVEmployees = new System.Windows.Forms.DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeEMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeePESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeBirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TBID = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.TBPesel = new System.Windows.Forms.TextBox();
            this.TBAddress = new System.Windows.Forms.TextBox();
            this.DTPBirthDay = new System.Windows.Forms.DateTimePicker();
            this.LID = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.LSurname = new System.Windows.Forms.Label();
            this.LPESEL = new System.Windows.Forms.Label();
            this.LAddress = new System.Windows.Forms.Label();
            this.LBirthDay = new System.Windows.Forms.Label();
            this.BCancel = new System.Windows.Forms.Button();
            this.BApply = new System.Windows.Forms.Button();
            this.PEmployee = new System.Windows.Forms.Panel();
            this.CBJob = new System.Windows.Forms.ComboBox();
            this.LJob = new System.Windows.Forms.Label();
            this.LEMail = new System.Windows.Forms.Label();
            this.TBEMail = new System.Windows.Forms.TextBox();
            this.TBSearch = new System.Windows.Forms.TextBox();
            this.LSearch = new System.Windows.Forms.Label();
            this.RBName = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RBSurname = new System.Windows.Forms.RadioButton();
            this.RBCompanyMail = new System.Windows.Forms.RadioButton();
            this.RBJob = new System.Windows.Forms.RadioButton();
            this.CBSearch = new System.Windows.Forms.ComboBox();
            this.RBPesel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployees)).BeginInit();
            this.PEmployee.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BNewEmployee
            // 
            this.BNewEmployee.Location = new System.Drawing.Point(656, 356);
            this.BNewEmployee.Name = "BNewEmployee";
            this.BNewEmployee.Size = new System.Drawing.Size(111, 23);
            this.BNewEmployee.TabIndex = 2;
            this.BNewEmployee.Text = "Nowy pracownik...";
            this.BNewEmployee.UseVisualStyleBackColor = true;
            this.BNewEmployee.Click += new System.EventHandler(this.BNewEmployee_Click);
            // 
            // DGVEmployees
            // 
            this.DGVEmployees.AllowUserToAddRows = false;
            this.DGVEmployees.AllowUserToDeleteRows = false;
            this.DGVEmployees.AllowUserToResizeColumns = false;
            this.DGVEmployees.AllowUserToResizeRows = false;
            this.DGVEmployees.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGVEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.EmployeeSurname,
            this.EmployeeEMail,
            this.EmployeeJob,
            this.EmployeePESEL,
            this.EmployeeAddress,
            this.EmployeeBirthDay,
            this.Edit,
            this.Delete});
            this.DGVEmployees.Location = new System.Drawing.Point(12, 12);
            this.DGVEmployees.MultiSelect = false;
            this.DGVEmployees.Name = "DGVEmployees";
            this.DGVEmployees.ReadOnly = true;
            this.DGVEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DGVEmployees.RowHeadersVisible = false;
            this.DGVEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGVEmployees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVEmployees.ShowCellErrors = false;
            this.DGVEmployees.ShowRowErrors = false;
            this.DGVEmployees.Size = new System.Drawing.Size(773, 331);
            this.DGVEmployees.TabIndex = 3;
            this.DGVEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEmployees_CellClick);
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "ID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            this.EmployeeID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeID.Width = 30;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Imię";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeName.Width = 70;
            // 
            // EmployeeSurname
            // 
            this.EmployeeSurname.HeaderText = "Nazwisko";
            this.EmployeeSurname.Name = "EmployeeSurname";
            this.EmployeeSurname.ReadOnly = true;
            this.EmployeeSurname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeSurname.Width = 103;
            // 
            // EmployeeEMail
            // 
            this.EmployeeEMail.HeaderText = "E-Mail";
            this.EmployeeEMail.Name = "EmployeeEMail";
            this.EmployeeEMail.ReadOnly = true;
            this.EmployeeEMail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // EmployeeJob
            // 
            this.EmployeeJob.HeaderText = "Stanowisko";
            this.EmployeeJob.Name = "EmployeeJob";
            this.EmployeeJob.ReadOnly = true;
            this.EmployeeJob.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeJob.Width = 80;
            // 
            // EmployeePESEL
            // 
            this.EmployeePESEL.HeaderText = "PESEL";
            this.EmployeePESEL.Name = "EmployeePESEL";
            this.EmployeePESEL.ReadOnly = true;
            this.EmployeePESEL.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeePESEL.Width = 80;
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.HeaderText = "Adres";
            this.EmployeeAddress.Name = "EmployeeAddress";
            this.EmployeeAddress.ReadOnly = true;
            this.EmployeeAddress.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeAddress.Width = 140;
            // 
            // EmployeeBirthDay
            // 
            this.EmployeeBirthDay.HeaderText = "Data urodzenia";
            this.EmployeeBirthDay.Name = "EmployeeBirthDay";
            this.EmployeeBirthDay.ReadOnly = true;
            this.EmployeeBirthDay.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeBirthDay.Width = 90;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Width = 30;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 30;
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(44, 0);
            this.TBID.Name = "TBID";
            this.TBID.ReadOnly = true;
            this.TBID.Size = new System.Drawing.Size(45, 20);
            this.TBID.TabIndex = 4;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(23, 42);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(159, 20);
            this.TBName.TabIndex = 5;
            // 
            // TBSurname
            // 
            this.TBSurname.Location = new System.Drawing.Point(23, 85);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(159, 20);
            this.TBSurname.TabIndex = 6;
            // 
            // TBPesel
            // 
            this.TBPesel.Location = new System.Drawing.Point(23, 129);
            this.TBPesel.Name = "TBPesel";
            this.TBPesel.Size = new System.Drawing.Size(159, 20);
            this.TBPesel.TabIndex = 7;
            // 
            // TBAddress
            // 
            this.TBAddress.Location = new System.Drawing.Point(23, 174);
            this.TBAddress.Name = "TBAddress";
            this.TBAddress.Size = new System.Drawing.Size(159, 20);
            this.TBAddress.TabIndex = 8;
            // 
            // DTPBirthDay
            // 
            this.DTPBirthDay.Location = new System.Drawing.Point(23, 219);
            this.DTPBirthDay.MaxDate = new System.DateTime(2017, 12, 6, 22, 21, 39, 0);
            this.DTPBirthDay.Name = "DTPBirthDay";
            this.DTPBirthDay.Size = new System.Drawing.Size(159, 20);
            this.DTPBirthDay.TabIndex = 9;
            this.DTPBirthDay.Value = new System.DateTime(2017, 12, 6, 0, 0, 0, 0);
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Location = new System.Drawing.Point(20, 3);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(18, 13);
            this.LID.TabIndex = 10;
            this.LID.Text = "ID";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(20, 26);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(26, 13);
            this.LName.TabIndex = 11;
            this.LName.Text = "Imię";
            // 
            // LSurname
            // 
            this.LSurname.AutoSize = true;
            this.LSurname.Location = new System.Drawing.Point(20, 69);
            this.LSurname.Name = "LSurname";
            this.LSurname.Size = new System.Drawing.Size(53, 13);
            this.LSurname.TabIndex = 12;
            this.LSurname.Text = "Nazwisko";
            // 
            // LPESEL
            // 
            this.LPESEL.AutoSize = true;
            this.LPESEL.Location = new System.Drawing.Point(20, 113);
            this.LPESEL.Name = "LPESEL";
            this.LPESEL.Size = new System.Drawing.Size(41, 13);
            this.LPESEL.TabIndex = 13;
            this.LPESEL.Text = "PESEL";
            // 
            // LAddress
            // 
            this.LAddress.AutoSize = true;
            this.LAddress.Location = new System.Drawing.Point(20, 158);
            this.LAddress.Name = "LAddress";
            this.LAddress.Size = new System.Drawing.Size(34, 13);
            this.LAddress.TabIndex = 14;
            this.LAddress.Text = "Adres";
            // 
            // LBirthDay
            // 
            this.LBirthDay.AutoSize = true;
            this.LBirthDay.Location = new System.Drawing.Point(20, 203);
            this.LBirthDay.Name = "LBirthDay";
            this.LBirthDay.Size = new System.Drawing.Size(79, 13);
            this.LBirthDay.TabIndex = 15;
            this.LBirthDay.Text = "Data urodzenia";
            // 
            // BCancel
            // 
            this.BCancel.Location = new System.Drawing.Point(23, 344);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 16;
            this.BCancel.Text = "Anuluj";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // BApply
            // 
            this.BApply.Location = new System.Drawing.Point(107, 344);
            this.BApply.Name = "BApply";
            this.BApply.Size = new System.Drawing.Size(75, 23);
            this.BApply.TabIndex = 17;
            this.BApply.Text = "Zapisz";
            this.BApply.UseVisualStyleBackColor = true;
            this.BApply.Click += new System.EventHandler(this.BApply_Click);
            // 
            // PEmployee
            // 
            this.PEmployee.BackColor = System.Drawing.Color.Transparent;
            this.PEmployee.Controls.Add(this.CBJob);
            this.PEmployee.Controls.Add(this.LJob);
            this.PEmployee.Controls.Add(this.LEMail);
            this.PEmployee.Controls.Add(this.TBEMail);
            this.PEmployee.Controls.Add(this.TBID);
            this.PEmployee.Controls.Add(this.BApply);
            this.PEmployee.Controls.Add(this.TBName);
            this.PEmployee.Controls.Add(this.BCancel);
            this.PEmployee.Controls.Add(this.TBSurname);
            this.PEmployee.Controls.Add(this.LBirthDay);
            this.PEmployee.Controls.Add(this.TBPesel);
            this.PEmployee.Controls.Add(this.LAddress);
            this.PEmployee.Controls.Add(this.TBAddress);
            this.PEmployee.Controls.Add(this.LPESEL);
            this.PEmployee.Controls.Add(this.DTPBirthDay);
            this.PEmployee.Controls.Add(this.LSurname);
            this.PEmployee.Controls.Add(this.LID);
            this.PEmployee.Controls.Add(this.LName);
            this.PEmployee.Location = new System.Drawing.Point(785, 12);
            this.PEmployee.Name = "PEmployee";
            this.PEmployee.Size = new System.Drawing.Size(200, 371);
            this.PEmployee.TabIndex = 18;
            // 
            // CBJob
            // 
            this.CBJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBJob.FormattingEnabled = true;
            this.CBJob.Location = new System.Drawing.Point(22, 311);
            this.CBJob.MaxDropDownItems = 6;
            this.CBJob.Name = "CBJob";
            this.CBJob.Size = new System.Drawing.Size(159, 21);
            this.CBJob.TabIndex = 22;
            // 
            // LJob
            // 
            this.LJob.AutoSize = true;
            this.LJob.Location = new System.Drawing.Point(19, 295);
            this.LJob.Name = "LJob";
            this.LJob.Size = new System.Drawing.Size(62, 13);
            this.LJob.TabIndex = 21;
            this.LJob.Text = "Stanowisko";
            // 
            // LEMail
            // 
            this.LEMail.AutoSize = true;
            this.LEMail.Location = new System.Drawing.Point(19, 250);
            this.LEMail.Name = "LEMail";
            this.LEMail.Size = new System.Drawing.Size(36, 13);
            this.LEMail.TabIndex = 19;
            this.LEMail.Text = "E-Mail";
            // 
            // TBEMail
            // 
            this.TBEMail.Location = new System.Drawing.Point(22, 266);
            this.TBEMail.Name = "TBEMail";
            this.TBEMail.ReadOnly = true;
            this.TBEMail.Size = new System.Drawing.Size(159, 20);
            this.TBEMail.TabIndex = 18;
            // 
            // TBSearch
            // 
            this.TBSearch.Location = new System.Drawing.Point(474, 357);
            this.TBSearch.MaxLength = 50;
            this.TBSearch.Name = "TBSearch";
            this.TBSearch.Size = new System.Drawing.Size(159, 20);
            this.TBSearch.TabIndex = 19;
            this.TBSearch.TextChanged += new System.EventHandler(this.SearchEmployee);
            // 
            // LSearch
            // 
            this.LSearch.AutoSize = true;
            this.LSearch.Location = new System.Drawing.Point(9, 359);
            this.LSearch.Name = "LSearch";
            this.LSearch.Size = new System.Drawing.Size(129, 13);
            this.LSearch.TabIndex = 20;
            this.LSearch.Text = "Wyszukaj pracownika po:";
            this.LSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RBName
            // 
            this.RBName.AutoSize = true;
            this.RBName.Checked = true;
            this.RBName.Location = new System.Drawing.Point(3, 5);
            this.RBName.Name = "RBName";
            this.RBName.Size = new System.Drawing.Size(57, 17);
            this.RBName.TabIndex = 21;
            this.RBName.TabStop = true;
            this.RBName.Text = "imieniu";
            this.RBName.UseVisualStyleBackColor = true;
            this.RBName.CheckedChanged += new System.EventHandler(this.SearchEmployee);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RBPesel);
            this.panel1.Controls.Add(this.RBJob);
            this.panel1.Controls.Add(this.RBCompanyMail);
            this.panel1.Controls.Add(this.RBSurname);
            this.panel1.Controls.Add(this.RBName);
            this.panel1.Location = new System.Drawing.Point(140, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 27);
            this.panel1.TabIndex = 22;
            // 
            // RBSurname
            // 
            this.RBSurname.AutoSize = true;
            this.RBSurname.Location = new System.Drawing.Point(61, 5);
            this.RBSurname.Name = "RBSurname";
            this.RBSurname.Size = new System.Drawing.Size(69, 17);
            this.RBSurname.TabIndex = 22;
            this.RBSurname.Text = "nazwisku";
            this.RBSurname.UseVisualStyleBackColor = true;
            this.RBSurname.CheckedChanged += new System.EventHandler(this.SearchEmployee);
            // 
            // RBCompanyMail
            // 
            this.RBCompanyMail.AutoSize = true;
            this.RBCompanyMail.Location = new System.Drawing.Point(132, 5);
            this.RBCompanyMail.Name = "RBCompanyMail";
            this.RBCompanyMail.Size = new System.Drawing.Size(58, 17);
            this.RBCompanyMail.TabIndex = 23;
            this.RBCompanyMail.Text = "e-mailu";
            this.RBCompanyMail.UseVisualStyleBackColor = true;
            this.RBCompanyMail.CheckedChanged += new System.EventHandler(this.SearchEmployee);
            // 
            // RBJob
            // 
            this.RBJob.AutoSize = true;
            this.RBJob.Location = new System.Drawing.Point(193, 5);
            this.RBJob.Name = "RBJob";
            this.RBJob.Size = new System.Drawing.Size(78, 17);
            this.RBJob.TabIndex = 24;
            this.RBJob.Text = "stanowisku";
            this.RBJob.UseVisualStyleBackColor = true;
            this.RBJob.CheckedChanged += new System.EventHandler(this.SearchEmployee);
            // 
            // CBSearch
            // 
            this.CBSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBSearch.FormattingEnabled = true;
            this.CBSearch.Location = new System.Drawing.Point(474, 357);
            this.CBSearch.MaxDropDownItems = 6;
            this.CBSearch.Name = "CBSearch";
            this.CBSearch.Size = new System.Drawing.Size(159, 21);
            this.CBSearch.TabIndex = 23;
            this.CBSearch.Visible = false;
            this.CBSearch.SelectedIndexChanged += new System.EventHandler(this.SearchEmployee);
            // 
            // RBPesel
            // 
            this.RBPesel.AutoSize = true;
            this.RBPesel.Location = new System.Drawing.Point(273, 5);
            this.RBPesel.Name = "RBPesel";
            this.RBPesel.Size = new System.Drawing.Size(56, 17);
            this.RBPesel.TabIndex = 25;
            this.RBPesel.Text = "peselu";
            this.RBPesel.UseVisualStyleBackColor = true;
            this.RBPesel.CheckedChanged += new System.EventHandler(this.SearchEmployee);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 389);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LSearch);
            this.Controls.Add(this.PEmployee);
            this.Controls.Add(this.DGVEmployees);
            this.Controls.Add(this.BNewEmployee);
            this.Controls.Add(this.CBSearch);
            this.Controls.Add(this.TBSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Administrator PKI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogOut);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployees)).EndInit();
            this.PEmployee.ResumeLayout(false);
            this.PEmployee.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BNewEmployee;
        private System.Windows.Forms.DataGridView DGVEmployees;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBSurname;
        private System.Windows.Forms.TextBox TBPesel;
        private System.Windows.Forms.TextBox TBAddress;
        private System.Windows.Forms.DateTimePicker DTPBirthDay;
        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LSurname;
        private System.Windows.Forms.Label LPESEL;
        private System.Windows.Forms.Label LAddress;
        private System.Windows.Forms.Label LBirthDay;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BApply;
        private System.Windows.Forms.Panel PEmployee;
        private System.Windows.Forms.Label LEMail;
        private System.Windows.Forms.TextBox TBEMail;
        private System.Windows.Forms.ComboBox CBJob;
        private System.Windows.Forms.Label LJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeEMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeePESEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeBirthDay;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox TBSearch;
        private System.Windows.Forms.Label LSearch;
        private System.Windows.Forms.RadioButton RBName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RBJob;
        private System.Windows.Forms.RadioButton RBCompanyMail;
        private System.Windows.Forms.RadioButton RBSurname;
        private System.Windows.Forms.ComboBox CBSearch;
        private System.Windows.Forms.RadioButton RBPesel;
    }
}

