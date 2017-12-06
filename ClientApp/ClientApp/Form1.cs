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

namespace ClientApp
{
    //TODO: zabezpiecz bledy - wyjscie po msgbox
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BGetMessagess_Click(null, null);
            GetMyInfo();
            SetCBRecNames(); //Combobox with employeees you send message
            SetDGVMessageR(); //Data Grid View where you can check employee to read messages
            SelectionChanged(null, null);
        }

        private Employee infoAboutMe = new Employee();

        private void GetMyInfo()
        {
            var request = new RestRequest("api/employee/me/", Method.GET);
            request.AddHeader("Authorization", "Token " + Program.token);
            IRestResponse<Employee> response = Program.client.Execute<Employee>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                infoAboutMe.id = response.Data.id;
                infoAboutMe.name = response.Data.name;
                infoAboutMe.surname = response.Data.surname;
                infoAboutMe.pesel = response.Data.pesel;
                infoAboutMe.address = response.Data.address;
                infoAboutMe.birth_day = response.Data.birth_day;
                infoAboutMe.job_id = response.Data.job_id;
                infoAboutMe.company_email = response.Data.company_email;
            }
            else
            {
                MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
            }
        }
        private void SetDGVMessageR() //Fill Inbox
        {

            for (int i = 0; i < 20; i++)
            {
                var index = DGVMessagesR.Rows.Add();
                DGVMessagesR.Rows[index].Cells[0].Value = i;
                DGVMessagesR.Rows[index].Cells[1].Value = "karol.koralin@koralowo.pl";
                DGVMessagesR.Rows[index].Cells[2].Value = "Blah blah blah blah blah blah " + i;
            }
        }
        private void SetCBRecNames()
        {
            //Get employees
            var request = new RestRequest("api/employee/", Method.GET);
            request.AddHeader("Authorization", "Token " + Program.token);
            IRestResponse<List<Employee>> response = Program.client.Execute<List<Employee>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                CBRecNames.ValueMember = "id"; //EmployeeID
                CBRecNames.DisplayMember = "company_email";
                CBRecNames.DataSource = response.Data.Where(x=>x.id != infoAboutMe.id).ToList();
            }
            else
            {
                MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
            }
        }
        private void BApplyForTheCertificate_Click(object sender, EventArgs e)
        {

        }

        private void BGetTheCertificate_Click(object sender, EventArgs e)
        {

        }

        private void BRevokeTheCertificate_Click(object sender, EventArgs e)
        {

        }

        private void BSendMessages_Click(object sender, EventArgs e)
        {
            //GUI settings
            PGetMessage.Visible = false;
            PSendMessage.Visible = true;
            TBMessageS.Visible = true;
            DGVMessagesR.Visible = false;
            TBMessageR.Visible = false;

            //Get emplo
        }

        private void BGetMessagess_Click(object sender, EventArgs e)
        {
            //GUI settings
            PGetMessage.Visible = true;
            PSendMessage.Visible = false;
            TBMessageS.Visible = false;
            DGVMessagesR.Visible = true;
            TBMessageR.Visible = true;
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

        private void SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = DGVMessagesR.SelectedRows.Count;
            if (rowsCount <1) return; //if 0 Messages
            var row = DGVMessagesR.SelectedRows[0];
            string senderTB = row.Cells[1].Value.ToString();
            string topicTB = row.Cells[2].Value.ToString();
            TBSender.Text = senderTB;
            TBTopicS.Text = topicTB;
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