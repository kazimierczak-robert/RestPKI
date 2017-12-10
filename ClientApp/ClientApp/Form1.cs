﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            GetMyInfo(); //Get info about logged employee
            SetCBRecNames(); //Combobox with employeees you send message <id and e-mail>
            SetDGVMessageR(); //Data Grid View where you can read IN messages
            SetDGVMessageS(); //Data Grid View where you can read OUT messages
        }

        private Employee infoAboutMe = new Employee();
        Dictionary<int, Certificate> employeeCertificate = new Dictionary<int, Certificate>(); //employee id, certificate
        Dictionary<int, string> employeeMail = new Dictionary<int, string>(); //emloyee id, email
        Dictionary<int, string> inbox = new Dictionary<int, string>(); //message id, message
        Dictionary<int, string> outbox = new Dictionary<int, string>(); //message id, message

        private void GetMyInfo()//Get Info about logged employee
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
            //Inbox - messages sent to me
            var request = new RestRequest("api/inbox/", Method.GET);
            request.AddHeader("Authorization", "Token " + Program.token);
            //Get messeges sent to me
            IRestResponse<List<Message>> response = Program.client.Execute<List<Message>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (Message item in response.Data)
                {
                    var index = DGVMessagesR.Rows.Add();
                    DGVMessagesR.Rows[index].Cells[0].Value = item.id; //TODO: get msg ID
                    DGVMessagesR.Rows[index].Cells[1].Value = employeeMail[item.sender_id];
                    DGVMessagesR.Rows[index].Cells[2].Value = item.enc_topic; //TODO: must be decrypted
                    DGVMessagesR.Rows[index].Cells[3].Value = DateTime.Parse(item.send_date).ToString("MM-dd-yy HH:mm:ss");
                    inbox.Add(item.id, item.enc_message); //TODO: must be decrypted
                }
            }
            else
            {
                MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
            }
        }
        private void SetDGVMessageS() //Fill Outbox
        {
            //Inbox - messages sent to me
            var request = new RestRequest("api/outbox/", Method.GET);
            request.AddHeader("Authorization", "Token " + Program.token);
            //Get messeges sent to me
            IRestResponse<List<Message>> response = Program.client.Execute<List<Message>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (Message item in response.Data)
                {
                    var index = DGVMessagesS.Rows.Add();
                    DGVMessagesS.Rows[index].Cells[0].Value = item.id; //TODO: get msg ID
                    DGVMessagesS.Rows[index].Cells[1].Value = employeeMail[item.recipient_id];
                    DGVMessagesS.Rows[index].Cells[2].Value = item.enc_topic; //TODO: must be decrypted
                    DGVMessagesS.Rows[index].Cells[3].Value = DateTime.Parse(item.send_date).ToString("MM-dd-yy HH:mm:ss");
                    outbox.Add(item.id, item.enc_message); //TODO: must be decrypted
                }
            }
            else
            {
                MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
            }
        }
        private void GetEmployeeCertificate(List<Employee> employeeList) //Get Certificate for employees
        {
            string certReq = "";
            foreach (var item in employeeList)
            {
                certReq = "api/employee/" + item.id + "/cert/";
                var request = new RestRequest(certReq, Method.GET);
                request.AddHeader("Authorization", "Token " + Program.token);
                IRestResponse<Certificate> response = Program.client.Execute<Certificate>(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    employeeCertificate.Add(item.id, response.Data);
                }
                else
                {
                    MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
                }
            }
        }
        private void SetCBRecNames()//Combobox with employeees you send message
        {
            //Get employees
            var request = new RestRequest("api/employee/", Method.GET);
            request.AddHeader("Authorization", "Token " + Program.token);
            //Get employes
            IRestResponse<List<Employee>> response = Program.client.Execute<List<Employee>>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                CBRecNames.ValueMember = "id"; //EmployeeID
                CBRecNames.DisplayMember = "company_email";
                CBRecNames.DataSource = response.Data.Where(x=>x.id != infoAboutMe.id).ToList(); //Prevent displaying myself
                GetEmployeeCertificate(response.Data); //Get ID and Certficate - fill dictionary
                foreach (Employee item in response.Data)
                {
                    employeeMail.Add(item.id, item.company_email);
                }
            }
            else
            {
                MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
            }
        }
        private void BApplyForTheCertificate_Click(object sender, EventArgs e)
        {
            var request = new RestRequest("api/cert/", Method.POST);
            request.AddHeader("Authorization", "Token " + Program.token);
            IRestResponse<Certificate> response = Program.client.Execute<Certificate>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                if (!employeeCertificate.ContainsKey(infoAboutMe.id)) //user doesn't have certificate
                {
                    employeeCertificate.Add(infoAboutMe.id, response.Data);
                }
                else //user has certificate
                {
                    employeeCertificate[infoAboutMe.id] = response.Data;
                }
                MessageBox.Show("Wniosek o wygenerowanie certyfikatu rozpatrzono pozytywnie", "Sukces");
            }
            else
            {
                MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
            }
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
            PMessageS.Visible = false;
            DGVMessagesS.Visible = false;
        }

        private void BGetMessagess_Click(object sender, EventArgs e)
        {
            //GUI settings
            PGetMessage.Visible = true;
            PSendMessage.Visible = false;
            TBMessageS.Visible = false;
            DGVMessagesR.Visible = true;
            TBMessageR.Visible = true;
            PMessageS.Visible = false;
            DGVMessagesS.Visible = false;

            TBMessageR.Text = "";
            InboxSelectionChanged(this.DGVMessagesR, null);
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

        private void InboxSelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = DGVMessagesR.SelectedRows.Count;
            if (rowsCount < 1) return; //if 0 Messages
            var row = DGVMessagesR.SelectedRows[0];
            int msgID = Int32.Parse(row.Cells[0].Value.ToString());
            string senderTB = row.Cells[1].Value.ToString();
            string topicTB = row.Cells[2].Value.ToString();
            TBSender.Text = senderTB;
            TBTopicS.Text = topicTB;
            TBMessageR.Text = inbox[msgID];
        }
        private void OutboxSelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = DGVMessagesS.SelectedRows.Count;
            if (rowsCount < 1) return; //if 0 Messages
            var row = DGVMessagesS.SelectedRows[0];
            int msgID = Int32.Parse(row.Cells[0].Value.ToString());
            string recipientTB = row.Cells[1].Value.ToString();
            string topicTB = row.Cells[2].Value.ToString();
            TBSenderMsg.Text = recipientTB;
            TBSenderTopic.Text = topicTB;
            TBMessageR.Text = outbox[msgID];
        }

        private void BInBox_Click(object sender, EventArgs e)
        {
            PMessageS.Visible = true;
            DGVMessagesS.Visible = true;
            TBMessageR.Visible = true;

            PGetMessage.Visible = false;
            PSendMessage.Visible = false;
            TBMessageS.Visible = false;

            TBMessageR.Text = "";
            OutboxSelectionChanged(this.DGVMessagesS, null);
        }

        private void BClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BSend_Click(object sender, EventArgs e)
        {
            //Get recipient ID from Combobox
            int recipientID = (int)CBRecNames.SelectedValue;

            /*From certificate*/
            //Get recipient public key
            X509Certificate2 X509Cert = new X509Certificate2();
            X509Cert.Import(Encoding.ASCII.GetBytes(employeeCertificate[recipientID].cert));
            var employeePublicKey = X509Cert.GetPublicKeyString();

            
            //zaszyfruj temat
            //zaszyfruj wiadomosc
            //copy na True
            var request = new RestRequest("api/message/", Method.POST);
            request.AddHeader("Authorization", "Token " + Program.token);
            request.AddParameter("sender_id", infoAboutMe.id);
            request.AddParameter("recipient_id", recipientID);
            request.AddParameter("enc_topic", TBTopic.Text);
            request.AddParameter("enc_message",TBMessageS.Text);
            request.AddParameter("send_date", DateTime.Now.ToString());
            request.AddParameter("copy", true);

            var response = Program.client.Execute(request);
            if (response.StatusCode != System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("Wiadomość wysłano", "Sukces!");
                MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
                return;
            }

            //My public key
            X509Certificate2 X509Cert1 = new X509Certificate2();
            X509Cert1.Import(Encoding.ASCII.GetBytes(employeeCertificate[infoAboutMe.id].cert));
            var myPublicKey = X509Cert1.GetPublicKeyString();
            //zaszyfruj temat
            //zaszyfruj wiadomosc
            //copy na False
            var request1 = new RestRequest("api/message/", Method.POST);
            request1.AddHeader("Authorization", "Token " + Program.token);
            request1.AddParameter("sender_id", infoAboutMe.id);
            request1.AddParameter("recipient_id", recipientID);
            request1.AddParameter("enc_topic", TBTopic.Text);
            request1.AddParameter("enc_message", TBMessageS.Text);
            request1.AddParameter("send_date", DateTime.Now.ToString());
            request1.AddParameter("copy", false);

            var response1 = Program.client.Execute(request1);
            if (response1.StatusCode == System.Net.HttpStatusCode.Created)
            {
                MessageBox.Show("Wiadomość wysłano", "Sukces!");
                TBTopic.Text = "";
                TBMessageS.Text = "";
            }
            else
            {
                MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
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
    class Certificate
    {
        public int id { get; set; }
        public string not_valid_before { get; set; }
        public string not_valid_after { get; set; }
        public string creation_date { get; set; }
        public string expiration_date { get; set; }
        public string cert { get; set; }
        public int employee_id { get; set; }
    }

    class Message
    {
        public int id {get;set;}
        public int sender_id { get; set; }
        public int recipient_id { get; set; }
        public string enc_topic { get; set; }
        public string enc_message { get; set; }
        public string send_date { get; set; }
        public bool copy { get; set; }
    }
}