using RestSharp;
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
        public MainForm()
        {
            InitializeComponent();

            PEmployee.Visible = false;

            var request = new RestRequest("api/employee/", Method.GET);
            request.AddHeader("Authorization", "Token " + Program.token);
            IRestResponse<List<Employee>> response = Program.client.Execute<List<Employee>>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var responseData = response.Data;

                foreach (var employee in responseData)
                {
                    var index = DGVEmployees.Rows.Add();
                    DGVEmployees.Rows[index].Cells[0].Value = employee.id;
                    DGVEmployees.Rows[index].Cells[1].Value = employee.name;
                    DGVEmployees.Rows[index].Cells[2].Value = employee.surname;
                    DGVEmployees.Rows[index].Cells[3].Value = employee.company_email;
                    DGVEmployees.Rows[index].Cells[4].Value = "Administator";
                    DGVEmployees.Rows[index].Cells[5].Value = employee.pesel;
                    DGVEmployees.Rows[index].Cells[6].Value = employee.address;
                    DGVEmployees.Rows[index].Cells[7].Value = employee.birth_day;
                }
            }
            else
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania pracowników!", "Błąd!");
            }

            if (DGVEmployees.Rows.Count<15)
            {
                BNewEmployee.Location = new Point(656, 355);
                this.Size = new Size(795, 425);
            }
            else
            {
                BNewEmployee.Location = new Point(672, 355);
                this.Size = new Size(811, 425);
            }
        }

        private void BNewEmployee_Click(object sender, EventArgs e)
        {
            PEmployee.Visible = true;

            if (DGVEmployees.Rows.Count < 15)
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

        private void BCancel_Click(object sender, EventArgs e)
        {
            PEmployee.Visible = false;
            if (DGVEmployees.Rows.Count < 15)
            {
                this.Size = new Size(795, 425);
            }
            else
            {
                this.Size = new Size(811, 425);
            }
        }

        private void BApply_Click(object sender, EventArgs e)
        {
            PEmployee.Visible = false;

            var index = DGVEmployees.Rows.Add();
            DGVEmployees.Rows[index].Cells[0].Value = index;
            DGVEmployees.Rows[index].Cells[1].Value = "Jan";
            DGVEmployees.Rows[index].Cells[2].Value = "Nowak";
            DGVEmployees.Rows[index].Cells[3].Value = "jan.nowak@company.pl";
            DGVEmployees.Rows[index].Cells[4].Value = "Administator";
            DGVEmployees.Rows[index].Cells[5].Value = 77000312398;
            DGVEmployees.Rows[index].Cells[6].Value = "Nowa 1, 12-345, Poznań";
            DGVEmployees.Rows[index].Cells[7].Value = "03.00.1977";

            if (DGVEmployees.Rows.Count < 15)
            {
                BNewEmployee.Location = new Point(656, 355);
                this.Size = new Size(795, 425);
            }
            else
            {
                BNewEmployee.Location = new Point(672, 355);
                this.Size = new Size(811, 425);
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
}
