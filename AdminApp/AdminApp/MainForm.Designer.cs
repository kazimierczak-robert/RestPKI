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
            this.TBID = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
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
            this.LEMail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LJob = new System.Windows.Forms.Label();
            this.CBJob = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployees)).BeginInit();
            this.PEmployee.SuspendLayout();
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
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(44, 0);
            this.TBID.Name = "TBID";
            this.TBID.ReadOnly = true;
            this.TBID.Size = new System.Drawing.Size(45, 20);
            this.TBID.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(23, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(159, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(23, 129);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(159, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(23, 174);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 20);
            this.textBox5.TabIndex = 8;
            // 
            // DTPBirthDay
            // 
            this.DTPBirthDay.Location = new System.Drawing.Point(23, 219);
            this.DTPBirthDay.Name = "DTPBirthDay";
            this.DTPBirthDay.Size = new System.Drawing.Size(159, 20);
            this.DTPBirthDay.TabIndex = 9;
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
            this.PEmployee.Controls.Add(this.textBox1);
            this.PEmployee.Controls.Add(this.TBID);
            this.PEmployee.Controls.Add(this.BApply);
            this.PEmployee.Controls.Add(this.textBox2);
            this.PEmployee.Controls.Add(this.BCancel);
            this.PEmployee.Controls.Add(this.textBox3);
            this.PEmployee.Controls.Add(this.LBirthDay);
            this.PEmployee.Controls.Add(this.textBox4);
            this.PEmployee.Controls.Add(this.LAddress);
            this.PEmployee.Controls.Add(this.textBox5);
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
            // LEMail
            // 
            this.LEMail.AutoSize = true;
            this.LEMail.Location = new System.Drawing.Point(19, 250);
            this.LEMail.Name = "LEMail";
            this.LEMail.Size = new System.Drawing.Size(36, 13);
            this.LEMail.TabIndex = 19;
            this.LEMail.Text = "E-Mail";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 18;
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
            // CBJob
            // 
            this.CBJob.FormattingEnabled = true;
            this.CBJob.Location = new System.Drawing.Point(22, 311);
            this.CBJob.MaxDropDownItems = 6;
            this.CBJob.Name = "CBJob";
            this.CBJob.Size = new System.Drawing.Size(159, 21);
            this.CBJob.TabIndex = 22;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 389);
            this.Controls.Add(this.PEmployee);
            this.Controls.Add(this.DGVEmployees);
            this.Controls.Add(this.BNewEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Administrator PKI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogOut);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEmployees)).EndInit();
            this.PEmployee.ResumeLayout(false);
            this.PEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BNewEmployee;
        private System.Windows.Forms.DataGridView DGVEmployees;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
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
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

