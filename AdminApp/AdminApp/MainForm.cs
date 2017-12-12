﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public partial class MainForm : Form
    {
        List<Job> jobs;
        int visibleRows = 0;
        public MainForm()
        {
            InitializeComponent();

            DTPBirthDay.MaxDate = DateTime.Today;
            PEmployee.Visible = false;

            var request = new RestRequest("api/employee/", Method.GET);
            request.AddHeader("Authorization", "Token " + Program.token);
            IRestResponse<List<Employee>> responseEmployees = Program.client.Execute<List<Employee>>(request);

            if (responseEmployees.StatusCode == System.Net.HttpStatusCode.OK)
            {
                request = new RestRequest("api/job/", Method.GET);
                request.AddHeader("Authorization", "Token " + Program.token);
                var responseJob = Program.client.Execute<List<Job>>(request);

                if (responseJob.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    jobs = responseJob.Data;

                    if (jobs.Count > 0)
                    {
                        CBJob.ValueMember = "id";
                        CBJob.DisplayMember = "description";
                        CBJob.DataSource = jobs;

                        var employeeList = responseEmployees.Data.Where(x => x.company_email != "admin@admin.pl").ToList();
                        foreach (var employee in employeeList)
                        {
                            var index = DGVEmployees.Rows.Add();
                            DGVEmployees.Rows[index].Cells[0].Value = employee.id;
                            DGVEmployees.Rows[index].Cells[1].Value = employee.name;
                            DGVEmployees.Rows[index].Cells[2].Value = employee.surname;
                            DGVEmployees.Rows[index].Cells[3].Value = employee.company_email;

                            foreach (var job in jobs)
                            {
                                if (job.id == employee.job_id)
                                {
                                    DGVEmployees.Rows[index].Cells[4].Value = job.description;
                                    break;
                                }
                            }

                            DGVEmployees.Rows[index].Cells[5].Value = employee.pesel;
                            DGVEmployees.Rows[index].Cells[6].Value = employee.address;
                            DGVEmployees.Rows[index].Cells[7].Value = employee.birth_day;
                        }

                        CBSearch.ValueMember = "id";
                        CBSearch.DisplayMember = "description";
                        CBSearch.DataSource = jobs;
                    }
                    else
                    {
                        this.Close();
                        MessageBox.Show("W bazie nie ma żadnych stanowisk pracy!", "Błąd!");
                    }
                }
                else
                {
                    this.Close();
                    MessageBox.Show("Wystąpił błąd podczas pobierania pracowników!", "Błąd!");
                } 
            }
            else
            {
                this.Close();
                MessageBox.Show("Wystąpił błąd podczas pobierania pracowników!", "Błąd!");
            }

            visibleRows = DGVEmployees.Rows.Count;
            if (visibleRows < 15)
            {
                BNewEmployee.Location = new Point(656, 356);
                this.Size = new Size(795, 425);
            }
            else
            {
                BNewEmployee.Location = new Point(674, 356);
                this.Size = new Size(811, 425);
            }
        }

        private void ClearControls()
        {
            TBID.Text = "";
            TBName.Text = "";
            TBSurname.Text = "";
            TBEMail.Text = "";
            TBPesel.Text = "";
            TBAddress.Text = "";
            TBEMail.Text = "";
            DTPBirthDay.Value = DateTime.Today;
            //CBJob.SelectedItem = CBJob.Items[0];
        }

        private void BNewEmployee_Click(object sender, EventArgs e)
        {
            PEmployee.Visible = true;
            BCancel.Focus();
            if (visibleRows < 15)
            {
                this.Size = new Size(980, 425);
                PEmployee.Location = new Point(766, 12);
            }
            else
            {
                this.Size = new Size(1000, 425);
                PEmployee.Location = new Point(786, 12);
            }
            ClearControls();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            PEmployee.Visible = false;
            BNewEmployee.Focus();
            if (visibleRows < 15)
            {
                this.Size = new Size(795, 425);
            }
            else
            {
                this.Size = new Size(811, 425);
            }
            ClearControls();
        }

        private bool checkRBRegex(int DGVIndex)
        {
            bool result = false;
            if(RBName.Checked == true)
            {
                result = DGVEmployees.Rows[DGVIndex].Cells[1].Value.ToString().ToLower().StartsWith(TBSearch.Text.ToLower());
            }
            else if (RBSurname.Checked == true)
            {
                result = DGVEmployees.Rows[DGVIndex].Cells[2].Value.ToString().ToLower().StartsWith(TBSearch.Text.ToLower());
            }
            else if (RBCompanyMail.Checked == true)
            {
                result = DGVEmployees.Rows[DGVIndex].Cells[3].Value.ToString().ToLower().StartsWith(TBSearch.Text.ToLower());
            }
            else if (RBJob.Checked == true)
            {
                result = DGVEmployees.Rows[DGVIndex].Cells[4].Value.ToString() == ((Job)CBSearch.SelectedItem).description;
            }
            else if (RBPesel.Checked == true)
            {
                result = DGVEmployees.Rows[DGVIndex].Cells[5].Value.ToString().ToLower().StartsWith(TBSearch.Text.ToLower());
            }
            DGVEmployees.Rows[DGVIndex].Visible = result;
            return result; 
        }

        private void BApply_Click(object sender, EventArgs e)
        {
            if (TBName.Text != "" && TBSurname.Text != "" && TBPesel.Text != "" && TBAddress.Text != "")
            {
                if (TBID.Text == "") //New
                {
                    var request = new RestRequest("api/employee/", Method.POST);
                    request.AddHeader("Authorization", "Token " + Program.token);
                    request.AddParameter("name", TBName.Text);
                    request.AddParameter("surname", TBSurname.Text);
                    request.AddParameter("pesel", TBPesel.Text);
                    request.AddParameter("address", TBAddress.Text);
                    request.AddParameter("birth_day", DTPBirthDay.Value.ToString("yyyy-MM-dd"));
                    request.AddParameter("job_id", CBJob.SelectedValue);

                    var response = Program.client.Execute<NewEmployee>(request);

                    if (response.StatusCode == System.Net.HttpStatusCode.Created)
                    {
                        var responseData = response.Data;

                        var index = DGVEmployees.Rows.Add();

                        DGVEmployees.Rows[index].Cells[0].Value = responseData.user.id;
                        DGVEmployees.Rows[index].Cells[1].Value = TBName.Text;
                        DGVEmployees.Rows[index].Cells[2].Value = TBSurname.Text;
                        DGVEmployees.Rows[index].Cells[3].Value = responseData.user.company_email;
                        DGVEmployees.Rows[index].Cells[4].Value = ((Job)CBJob.SelectedItem).description;
                        DGVEmployees.Rows[index].Cells[5].Value = TBPesel.Text;
                        DGVEmployees.Rows[index].Cells[6].Value = TBAddress.Text;
                        DGVEmployees.Rows[index].Cells[7].Value = DTPBirthDay.Value.ToString("yyyy-MM-dd");

                        if (checkRBRegex(index))
                        {
                            visibleRows++;
                        }

                        MessageBox.Show("Dane logowania:\nLogin: " + responseData.user.company_email + "\nHasło: " + responseData.password, "Sukces!");

                        BNewEmployee.Focus();
                        PEmployee.Visible = false;

                        if (visibleRows < 15)
                        {
                            BNewEmployee.Location = new Point(656, 356);
                            this.Size = new Size(795, 425);
                        }
                        else
                        {
                            BNewEmployee.Location = new Point(674, 356);
                            this.Size = new Size(811, 425);
                        }

                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd podczas dodawania pracowników!", "Błąd!");
                    }
                }
                else //Exist
                {
                    var request = new RestRequest("api/employee/" + TBID.Text + "/", Method.PUT);
                    request.AddHeader("Authorization", "Token " + Program.token);
                    request.AddParameter("name", TBName.Text);
                    request.AddParameter("surname", TBSurname.Text);
                    request.AddParameter("pesel", TBPesel.Text);
                    request.AddParameter("address", TBAddress.Text);
                    request.AddParameter("birth_day", DTPBirthDay.Value.ToString("yyyy-MM-dd"));
                    request.AddParameter("job_id", CBJob.SelectedValue);

                    var response = Program.client.Execute<Employee>(request);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        //var responseData = response.Data;

                        BNewEmployee.Focus();
                        PEmployee.Visible = false;

                        var index = -1;
                        foreach (DataGridViewRow item in DGVEmployees.Rows)
                        {
                            if(item.Cells[0].Value.ToString() == TBID.Text)
                            {
                                index = item.Index;
                                break;
                            }
                        }
                        if (index > -1)
                        {
                            bool wasVisible = DGVEmployees.Rows[index].Visible;
                            DGVEmployees.Rows[index].Cells[1].Value = TBName.Text;
                            DGVEmployees.Rows[index].Cells[2].Value = TBSurname.Text;
                            //DGVEmployees.Rows[index].Cells[3].Value = responseData.company_email;
                            DGVEmployees.Rows[index].Cells[4].Value = ((Job)CBJob.SelectedItem).description;
                            DGVEmployees.Rows[index].Cells[5].Value = TBPesel.Text;
                            DGVEmployees.Rows[index].Cells[6].Value = TBAddress.Text;
                            DGVEmployees.Rows[index].Cells[7].Value = DTPBirthDay.Value.ToString("yyyy-MM-dd");

                            if (checkRBRegex(index) != wasVisible)
                            {
                                if (!wasVisible)
                                {
                                    visibleRows++;
                                }
                                else
                                {
                                    visibleRows--;
                                }
                            }
                        }

                        if (visibleRows < 15)
                        {
                            BNewEmployee.Location = new Point(656, 356);
                            this.Size = new Size(795, 425);
                        }
                        else
                        {
                            BNewEmployee.Location = new Point(674, 356);
                            this.Size = new Size(811, 425);
                        }
                        MessageBox.Show("Edycja pracownika zakończyła się pomyślnie!", "Sukces!");

                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd podczas edycji danych pracownika!", "Błąd!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Co najmniej jedno z wymaganych pól jest puste!", "Błąd!");
            }
        }

        private void LogOut(object sender, FormClosingEventArgs e)
        {
            var request = new RestRequest("api/logout/", Method.GET);
            request.AddHeader("Authorization", "Token " + Program.token);
            var response = Program.client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                e.Cancel = true;
                MessageBox.Show("Klient nie może zostać wylogowany, skontaktuj się z administratorem systemu!", "Błąd!");
            }
        }

        private void DGVEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 8 || (e.ColumnIndex < 8 && PEmployee.Visible == true))
            {
                int row = e.RowIndex;
                BNewEmployee_Click(null, null);
                TBID.Text = DGVEmployees.Rows[row].Cells[0].Value.ToString();
                TBName.Text = DGVEmployees.Rows[row].Cells[1].Value.ToString();
                TBSurname.Text = DGVEmployees.Rows[row].Cells[2].Value.ToString();
                TBEMail.Text = DGVEmployees.Rows[row].Cells[3].Value.ToString();
                CBJob.SelectedValue = jobs.Where(x => x.description == DGVEmployees.Rows[row].Cells[4].Value.ToString()).Select(x => x.id).FirstOrDefault();
                TBPesel.Text = DGVEmployees.Rows[row].Cells[5].Value.ToString();
                TBAddress.Text = DGVEmployees.Rows[row].Cells[6].Value.ToString();
                DTPBirthDay.Text = DGVEmployees.Rows[row].Cells[7].Value.ToString();
            }
            else if(e.ColumnIndex == 9)
            {
                int row = e.RowIndex;
                DialogResult dialogResult = MessageBox.Show("Czy na pewno usunąć pracownika o ID:" + DGVEmployees.Rows[row].Cells[0].Value.ToString() + "?\nTej operacji nie można cofnąć!", "Ostrzeżenie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var request = new RestRequest("api/employee/" + DGVEmployees.Rows[row].Cells[0].Value.ToString() + "/", Method.DELETE);
                    request.AddHeader("Authorization", "Token " + Program.token);
                    IRestResponse responseEmployees = Program.client.Execute(request);
                    if (responseEmployees.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        if(checkRBRegex(row))
                        {
                            visibleRows--;
                        }
                        DGVEmployees.Rows.RemoveAt(row);

                        PEmployee.Visible = false;
                        if (DGVEmployees.Rows.Count < 15)
                        {
                            BNewEmployee.Location = new Point(656, 356);
                            this.Size = new Size(795, 425);
                        }
                        else
                        {
                            BNewEmployee.Location = new Point(674, 356);
                            this.Size = new Size(811, 425);
                        }
                        ClearControls();

                        MessageBox.Show("Usunięto!", "OK!");
                    }
                    else
                    {
                        MessageBox.Show("Wystąpił błąd podczas usuwania pracownika!", "Błąd!");
                    }
                }
            }
        }

        private void SearchEmployee(object sender, EventArgs e)
        {
            if((sender is RadioButton) && sender != RBJob)
            {
                TBSearch.Focus();
            }
            CBSearch.Visible = RBJob.Checked;
            TBSearch.Visible = !RBJob.Checked;

            visibleRows = 0;
            foreach (DataGridViewRow row in DGVEmployees.Rows)
            {
                if(checkRBRegex(row.Index))
                {
                    visibleRows++;
                }
            }

            if (DGVEmployees.SelectedRows.Count > 0 && DGVEmployees.SelectedRows[0].Visible == false)
            {
                DGVEmployees.SelectedRows[0].Selected = false;
            }
            if (DGVEmployees.SelectedRows.Count == 0)
            { 
                foreach (DataGridViewRow row in DGVEmployees.Rows)
                {
                    if (row.Visible == true)
                    {
                        row.Selected = true;
                        if (PEmployee.Visible == true)
                        {
                            DGVEmployees_CellClick(null, new DataGridViewCellEventArgs(8, row.Index));
                        }
                        if (!RBJob.Checked)
                        {
                            TBSearch.Focus();
                        }
                        else
                        {
                            CBJob.Focus();
                        }
                        break;
                    }
                }
                if (DGVEmployees.SelectedRows.Count == 0)
                {
                    ClearControls();
                }
            }

            if (PEmployee.Visible == true)
            {
                if (visibleRows < 15)
                {
                    this.Size = new Size(980, 425);
                    PEmployee.Location = new Point(766, 12);
                }
                else
                {
                    this.Size = new Size(1000, 425);
                    PEmployee.Location = new Point(786, 12);
                }
            }
            else
            {
                if (visibleRows < 15)
                {
                    BNewEmployee.Location = new Point(656, 356);
                    this.Size = new Size(795, 425);
                }
                else
                {
                    BNewEmployee.Location = new Point(674, 356);
                    this.Size = new Size(811, 425);
                }
            }
        }
    }

    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string pesel { get; set; }
        public string address { get; set; }
        public string birth_day { get; set; }
        public int job_id { get; set; }
        public string company_email { get; set; }
    }

    class NewEmployee
    {
        public Employee user { get; set; }
        public string password { get; set; }
    }

    class Job
    {
        public int id { get; set; }
        public string description { get; set; }
    }
}
