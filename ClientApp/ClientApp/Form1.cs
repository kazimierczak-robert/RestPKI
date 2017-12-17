using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.X509;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
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
            GetMyInfo(); //Get info about logged employee
            GetPrivateKeys();
            GetEmployees(); //Combobox with employeees you send message <id and e-mail>
            SetDGVInBox(); //Data Grid View where you can read IN messages
            SetDGVOutBox(); //Data Grid View where you can read OUT messages
            BInBox_Click(null, null);
            LLogged.Text += infoAboutMe.company_email;
        }

        public Employee infoAboutMe = new Employee();
        //Dictionary<int, Certificate> employeeCertificate = new Dictionary<int, Certificate>(); //employee id, certificate
        //TODO: pobierac na biezaca!
        Dictionary<int, string> employeeMail = new Dictionary<int, string>(); //Emloyee id, email
        Dictionary<int, string> inbox = new Dictionary<int, string>(); //Message id, message
        Dictionary<int, string> outbox = new Dictionary<int, string>(); //Message id, message
        Dictionary<int, PrivateKey> myPrivateKeys = new Dictionary<int, PrivateKey>(); //Cert id, PrivateKey
        //TODO: przy generowaniu certyfikatu pobierz klucze

        public void GetPrivateKeys()
        {
            var request = new RestRequest("api/get_employee_keys/", Method.POST);
            request.AddHeader("Authorization", "Token " + Program.token);
            request.AddParameter("id", infoAboutMe.id.ToString());
            IRestResponse<List<PrivateKey>> response = Program.client.Execute<List<PrivateKey>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (PrivateKey item in response.Data)
                {
                    myPrivateKeys.Add(item.cert_id, item);
                }
            }
        }
        /*
         0 - BSendMessages
         1 - BInBox
         2 - BOutBox
        */
        byte focusedButton = 1;

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
        private void SetDGVInBox() //Fill Inbox
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
                    var reader = new StringReader(myPrivateKeys[item.certificate_id].privatekey);
                    //Parsed private key
                    AsymmetricKeyParameter parsedPrivateKey = (AsymmetricKeyParameter)new PemReader(reader).ReadObject();
                    RSACryptoServiceProvider rsaPrivate = new RSACryptoServiceProvider(1024);
                    var messageToDecrypt = Convert.FromBase64String(item.enc_message);
                    var topicToDecrypt = Convert.FromBase64String(item.enc_topic);
                    var decryptEngine = new Pkcs1Encoding(new RsaEngine());
                    decryptEngine.Init(false, parsedPrivateKey);

                    int inBlockSize = decryptEngine.GetInputBlockSize();
                    List<byte> topicOutBytes = new List<byte>();
                    List<byte> messageOutBytes = new List<byte>();
                    int chunkSize = 0;

                    //Decrypt topic with your public key
                    for (int i = 0; i < topicToDecrypt.Length; i += inBlockSize)
                    {
                        chunkSize = Math.Min(inBlockSize, topicToDecrypt.Length - ((i / inBlockSize) * inBlockSize));
                        topicOutBytes.AddRange(decryptEngine.ProcessBlock(topicToDecrypt, i, chunkSize));
                    }
                    string  decTopic = Encoding.UTF8.GetString(topicOutBytes.ToArray());

                    //Decrypt message with your public key
                    for (int i = 0; i < messageToDecrypt.Length; i += inBlockSize)
                    {
                        chunkSize = Math.Min(inBlockSize, messageToDecrypt.Length - ((i / inBlockSize) * inBlockSize));
                        messageOutBytes.AddRange(decryptEngine.ProcessBlock(messageToDecrypt, i, chunkSize));
                    }
                    string decMessage = Encoding.UTF8.GetString(messageOutBytes.ToArray());

                    var index = DGVInBox.Rows.Add();
                    DGVInBox.Rows[index].Cells[0].Value = item.id;
                    DGVInBox.Rows[index].Cells[1].Value = employeeMail[item.sender_id];
                    DGVInBox.Rows[index].Cells[2].Value = decTopic;
                    DGVInBox.Rows[index].Cells[3].Value = DateTime.Parse(item.send_date).ToString("dd-MM-yy HH:mm:ss");
                    inbox.Add(item.id, decMessage);
                }
            }
            else
            {
                MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
            }
        }
        private void SetDGVOutBox() //Fill Outbox
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
                    //Parsed private key
                    var reader = new StringReader(myPrivateKeys[item.certificate_id].privatekey);
                    AsymmetricKeyParameter parsedPrivateKey = (AsymmetricKeyParameter)new PemReader(reader).ReadObject();
                    RSACryptoServiceProvider rsaPrivate = new RSACryptoServiceProvider(1024);
                    var messageToDecrypt = Convert.FromBase64String(item.enc_message);
                    var topicToDecrypt = Convert.FromBase64String(item.enc_topic);
                    var decryptEngine = new Pkcs1Encoding(new RsaEngine());
                    decryptEngine.Init(false, parsedPrivateKey);

                    int inBlockSize = decryptEngine.GetInputBlockSize();
                    List<byte> topicOutBytes = new List<byte>();
                    List<byte> messageOutBytes = new List<byte>();
                    int chunkSize = 0;

                    //Decrypt topic with your public key
                    for (int i = 0; i < topicToDecrypt.Length; i += inBlockSize)
                    {
                        chunkSize = Math.Min(inBlockSize, topicToDecrypt.Length - ((i / inBlockSize) * inBlockSize));
                        topicOutBytes.AddRange(decryptEngine.ProcessBlock(topicToDecrypt, i, chunkSize));
                    }
                    string decTopic = Encoding.UTF8.GetString(topicOutBytes.ToArray());

                    //Decrypt message with your public key
                    for (int i = 0; i < messageToDecrypt.Length; i += inBlockSize)
                    {
                        chunkSize = Math.Min(inBlockSize, messageToDecrypt.Length - ((i / inBlockSize) * inBlockSize));
                        messageOutBytes.AddRange(decryptEngine.ProcessBlock(messageToDecrypt, i, chunkSize));
                    }
                    string decMessage = Encoding.UTF8.GetString(messageOutBytes.ToArray());

                    var index = DGVOutBox.Rows.Add();
                    DGVOutBox.Rows[index].Cells[0].Value = item.id;
                    DGVOutBox.Rows[index].Cells[1].Value = employeeMail[item.recipient_id];
                    DGVOutBox.Rows[index].Cells[2].Value = decTopic;
                    DGVOutBox.Rows[index].Cells[3].Value = DateTime.Parse(item.send_date).ToString("dd-MM-yy HH:mm:ss");
                    outbox.Add(item.id, decMessage);
                }
            }
            else
            {
                MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
            }
        }
        private Certificate GetEmployeeCertificate(int employeeID) //Get employee Certificate
        {
            string certReq = "";
            certReq = "api/employee/" + employeeID + "/cert/";
            var request = new RestRequest(certReq, Method.GET);
            request.AddHeader("Authorization", "Token " + Program.token);
            IRestResponse<Certificate> response = Program.client.Execute<Certificate>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                DateTime timeNow = DateTime.Now;
                if (timeNow > DateTime.Parse(response.Data.expiration_date)) //If certificate has expired
                {
                    return null;
                }
                else
                {
                    return response.Data;
                }
            }
            else
            {
                MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
                return null;
            }
        }
        private void CBRecNamesTextChanged(object sender, EventArgs e)
        {

        }
        private void GetEmployees()//Combobox with employeees you send message
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
                CBRecNames.DataSource = response.Data.Where(x => x.id != infoAboutMe.id).ToList(); //Prevent displaying myself
                CBRecNames.AutoCompleteMode = AutoCompleteMode.Append;
                CBRecNames.AutoCompleteSource = AutoCompleteSource.ListItems;

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
            panel2.Enabled = false;

            //highlight font in the clicked button
            BNewMessage.ForeColor = Color.Gray;
            BOutBox.ForeColor = Color.Gray;
            BInBox.ForeColor = Color.Gray;
            BApplyForTheCertificate.ForeColor = Color.Black;
            BRevokeTheCertificate.ForeColor = Color.Gray;
            BChangePassword.ForeColor = Color.Gray;

            var request = new RestRequest("api/cert/", Method.POST);
            request.AddHeader("Authorization", "Token " + Program.token);
            IRestResponse<Certificate> response = Program.client.Execute<Certificate>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show("Wniosek o wygenerowanie certyfikatu rozpatrzono pozytywnie", "Sukces");

                string certReq = "api/certificate/" + response.Data.id + "/get_key/";
                var request2 = new RestRequest(certReq, Method.GET);
                request2.AddHeader("Authorization", "Token " + Program.token);
                IRestResponse<PrivateKey> response2 = Program.client.Execute<PrivateKey>(request2);
                if (response2.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    myPrivateKeys.Add(response.Data.id, response2.Data);
                }
                else
                {
                    MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
                }
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
            panel2.Enabled = false;

            //highlight font in the clicked button
            BNewMessage.ForeColor = Color.Gray;
            BOutBox.ForeColor = Color.Gray;
            BInBox.ForeColor = Color.Gray;
            BApplyForTheCertificate.ForeColor = Color.Gray;
            BRevokeTheCertificate.ForeColor = Color.Black;
            BChangePassword.ForeColor = Color.Gray;
        }

        private void BNewMessage_Click(object sender, EventArgs e)
        {
            Certificate myCert = GetEmployeeCertificate(infoAboutMe.id);
            if (myCert != null)
            {
                if (myCert.cert != "") //if I have valid certificate...
                {
                    focusedButton = 0;
                    panel2.Enabled = false;

                    //highlight font in the clicked button
                    BNewMessage.ForeColor = Color.Black;
                    BOutBox.ForeColor = Color.Gray;
                    BInBox.ForeColor = Color.Gray;
                    BApplyForTheCertificate.ForeColor = Color.Gray;
                    BRevokeTheCertificate.ForeColor = Color.Gray;
                    BChangePassword.ForeColor = Color.Gray;

                    //GUI settings
                    PInBox.Visible = false;
                    PSendMessage.Visible = true;
                    TBMessageS.Visible = true;
                    DGVInBox.Visible = false;
                    TBMessageR.Visible = false;
                    POutBox.Visible = false;
                    DGVOutBox.Visible = false;
                }
                else //If I have empty certificate
                {
                    MessageBox.Show("Aby móc wysyłać wiadomości, złóż wniosek o wydanie certyfikatu", "Uwaga!");
                }
            }
            else //If I don't have valid certificate
            {
                MessageBox.Show("Aby móc wysyłać wiadomości, złóż wniosek o wydanie certyfikatu", "Uwaga!");
            }
        }
        private void BInBox_Click(object sender, EventArgs e)
        {
            focusedButton = 1;
            panel2.Enabled = true;

            //highlight font in the clicked button
            BNewMessage.ForeColor = Color.Gray;
            BInBox.ForeColor = Color.Black;
            BOutBox.ForeColor = Color.Gray;
            BApplyForTheCertificate.ForeColor = Color.Gray;
            BRevokeTheCertificate.ForeColor = Color.Gray;
            BChangePassword.ForeColor = Color.Gray;
            BChangePassword.ForeColor = Color.Gray;

            POutBox.Visible = false;
            DGVOutBox.Visible = false;
            TBMessageR.Visible = true;

            PInBox.Visible = true;
            PSendMessage.Visible = false;
            TBMessageS.Visible = false;
            DGVInBox.Visible = true;

            int newestMsgID;
            if (inbox.Count != 0)
            {
                //Check if something new in inbox
                newestMsgID = inbox.Keys.Max();
            }
            else
            {
                newestMsgID = 0;
            }

            var request = new RestRequest("api/refresh_inbox/", Method.POST);
            request.AddHeader("Authorization", "Token " + Program.token);
            request.AddParameter("id", newestMsgID);

            IRestResponse<List<Message>> response = Program.client.Execute<List<Message>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                foreach (Message item in response.Data)
                {                  
                    var reader = new StringReader(myPrivateKeys[item.certificate_id].privatekey);
                    //Parsed private key
                    AsymmetricKeyParameter parsedPrivateKey = (AsymmetricKeyParameter)new PemReader(reader).ReadObject();
                    RSACryptoServiceProvider rsaPrivate = new RSACryptoServiceProvider(1024);
                    var messageToDecrypt = Convert.FromBase64String(item.enc_message);
                    var topicToDecrypt = Convert.FromBase64String(item.enc_topic);
                    var decryptEngine = new Pkcs1Encoding(new RsaEngine());
                    decryptEngine.Init(false, parsedPrivateKey);

                    int inBlockSize = decryptEngine.GetInputBlockSize();
                    List<byte> topicOutBytes = new List<byte>();
                    List<byte> messageOutBytes = new List<byte>();
                    int chunkSize = 0;

                    //Decrypt topic with your public key
                    for (int i = 0; i < topicToDecrypt.Length; i += inBlockSize)
                    {
                        chunkSize = Math.Min(inBlockSize, topicToDecrypt.Length - ((i / inBlockSize) * inBlockSize));
                        topicOutBytes.AddRange(decryptEngine.ProcessBlock(topicToDecrypt, i, chunkSize));
                    }
                    string decTopic = Encoding.UTF8.GetString(topicOutBytes.ToArray());

                    //Decrypt message with your public key
                    for (int i = 0; i < messageToDecrypt.Length; i += inBlockSize)
                    {
                        chunkSize = Math.Min(inBlockSize, messageToDecrypt.Length - ((i / inBlockSize) * inBlockSize));
                        messageOutBytes.AddRange(decryptEngine.ProcessBlock(messageToDecrypt, i, chunkSize));
                    }
                    string decMessage = Encoding.UTF8.GetString(messageOutBytes.ToArray());

                    DataGridViewRow dgvRow = new DataGridViewRow();
                    dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = item.id });
                    dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = employeeMail[item.sender_id] });
                    dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = decTopic });
                    dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = (DateTime.Parse(item.send_date)).ToString("dd-MM-yy HH:mm:ss") });
                    inbox.Add(item.id, decMessage);
                    DGVInBox.Rows.Add(dgvRow);
                }
            }
            else
            {
                //User won't see more messages in session
            }
            SearchInDGV(null, null);

            //TBMessageR.Text = "";
            //OutboxSelectionChanged(this.DGVMessagesS, null);
        }
        private void BOutBox_Click(object sender, EventArgs e)
        {
            focusedButton = 2;
            panel2.Enabled = true;

            //highlight font in the clicked button
            BNewMessage.ForeColor = Color.Gray;
            BInBox.ForeColor = Color.Gray;
            BOutBox.ForeColor = Color.Black;
            BApplyForTheCertificate.ForeColor = Color.Gray;
            BRevokeTheCertificate.ForeColor = Color.Gray;
            BChangePassword.ForeColor = Color.Gray;

            //GUI settings
            PInBox.Visible = false;
            PSendMessage.Visible = false;
            TBMessageS.Visible = false;
            DGVInBox.Visible = false;
            TBMessageR.Visible = true;
            POutBox.Visible = true;
            DGVOutBox.Visible = true;

            //TBMessageR.Text = "";
            //InboxSelectionChanged(this.DGVMessagesR, null);
            SearchInDGV(null, null);
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
            DGVInBox.Update();
            var rowsCount = DGVInBox.SelectedRows.Count;
            if (rowsCount < 1)
            {
                TBMessageR.Text = "";
                TBSender.Text = "";
                TBTopicS.Text = "";
                return; //if 0 Messages
            }
            if (DGVInBox.SelectedRows[0].Visible == true)
            {
                var row = DGVInBox.SelectedRows[0];
                int msgID = Int32.Parse(row.Cells[0].Value.ToString());
                string senderTB = row.Cells[1].Value.ToString();
                string topicTB = row.Cells[2].Value.ToString();
                TBSender.Text = senderTB;
                TBTopicS.Text = topicTB;
                TBMessageR.Text = inbox[msgID];
            }
            else
            {
                TBMessageR.Text = "";
                TBSender.Text = "";
                TBTopicS.Text = "";
            }
        }
        private void OutboxSelectionChanged(object sender, EventArgs e)
        {
            DGVOutBox.Update();
            var rowsCount = DGVOutBox.SelectedRows.Count;
            if (rowsCount < 1)
            {
                TBMessageR.Text = "";
                TBSenderMsg.Text = "";
                TBSenderTopic.Text = "";

                return; //if 0 Messages
            }
            if (DGVOutBox.SelectedRows[0].Visible == true)
            {
                var row = DGVOutBox.SelectedRows[0];
                int msgID = Int32.Parse(row.Cells[0].Value.ToString());
                string recipientTB = row.Cells[1].Value.ToString();
                string topicTB = row.Cells[2].Value.ToString();
                TBSenderMsg.Text = recipientTB;
                TBSenderTopic.Text = topicTB;
                TBMessageR.Text = outbox[msgID];
            }
            else
            {
                TBMessageR.Text = "";
                TBSenderMsg.Text = "";
                TBSenderTopic.Text = "";
            }
        }
        private void BClose_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void BHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BSend_Click(object sender, EventArgs e)
        {
            if (TBTopic.Text == "" || TBMessageS.Text == "" || CBRecNames.Text == "")
            {
                MessageBox.Show("Odbiorca, temat wiadomości i jej treść nie mogą być puste!", "Błąd!!");
            }
            else
            {
                //Get recipient ID from Combobox
                int recipientID = (int)CBRecNames.SelectedValue;
                Certificate recipientCert = GetEmployeeCertificate(recipientID);
                if (recipientCert != null)//If recipient has valid certificate...
                {
                    if (recipientCert.cert != "")
                    {
                        Certificate myCert = GetEmployeeCertificate(infoAboutMe.id);
                        if (myCert != null)
                        {
                            if (myCert.cert != "") //If I have certificate
                            {
                                var reader = new StringReader(myCert.cert);
                                //Parsed certificate
                                var parsedCert = (Org.BouncyCastle.X509.X509Certificate)new PemReader(reader).ReadObject();
                                //Encryption
                                var encryptEngine = new Pkcs1Encoding(new RsaEngine());
                                encryptEngine.Init(true, parsedCert.GetPublicKey());

                                int inBlockSize = encryptEngine.GetInputBlockSize();
                                //int outputBlockSize = encryptEngine.GetOutputBlockSize();   
                                List<byte> topicOutBytes = new List<byte>();
                                List<byte> messageOutBytes = new List<byte>();
                                int chunkSize = 0;

                                //Encrypt topic with your public key
                                byte[] topic = Encoding.UTF8.GetBytes(TBTopic.Text);
                                for (int i = 0; i < topic.Length; i+=inBlockSize)
                                {
                                    chunkSize = Math.Min(inBlockSize, topic.Length - ((i / inBlockSize) * inBlockSize));
                                    topicOutBytes.AddRange(encryptEngine.ProcessBlock(topic, i, chunkSize));
                                }
                                string encTopic = Convert.ToBase64String(topicOutBytes.ToArray());

                                //Encrypt message with your public key
                                byte[] message = Encoding.UTF8.GetBytes(TBMessageS.Text);
                                for (int i = 0; i < message.Length; i += inBlockSize)
                                {
                                    chunkSize = Math.Min(inBlockSize, message.Length - ((i/inBlockSize) * inBlockSize));
                                    messageOutBytes.AddRange(encryptEngine.ProcessBlock(message, i, chunkSize));
                                }

                                string encMessage = Convert.ToBase64String(messageOutBytes.ToArray());

                                //Get time
                                string timeNow = DateTime.Now.ToString();
                                var request = new RestRequest("api/message/", Method.POST);
                                request.AddHeader("Authorization", "Token " + Program.token);
                                request.AddParameter("certificate_id", myCert.id);
                                request.AddParameter("sender_id", infoAboutMe.id);
                                request.AddParameter("recipient_id", recipientID);
                                request.AddParameter("enc_topic", encTopic);
                                request.AddParameter("enc_message", encMessage);
                                request.AddParameter("send_date", timeNow);
                                request.AddParameter("copy", true);

                                IRestResponse<Message> response = Program.client.Execute<Message>(request);
                                if (response.StatusCode != System.Net.HttpStatusCode.Created)
                                {
                                    MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
                                    return;
                                }

                                var reader2 = new StringReader(recipientCert.cert);
                                //Parsed certificate
                                var parsedCert2 = (Org.BouncyCastle.X509.X509Certificate)new PemReader(reader2).ReadObject();
                                //Encryption
                                var encryptEngine2 = new Pkcs1Encoding(new RsaEngine());
                                encryptEngine2.Init(true, parsedCert2.GetPublicKey());

                                //int outputBlockSize = encryptEngine.GetOutputBlockSize();   
                                topicOutBytes.Clear();
                                messageOutBytes.Clear();
                                chunkSize = 0;

                                //Encrypt topic with your public key
                                topic = Encoding.UTF8.GetBytes(TBTopic.Text);
                                for (int i = 0; i < topic.Length; i += inBlockSize)
                                {
                                    chunkSize = Math.Min(inBlockSize, topic.Length - ((i / inBlockSize) * inBlockSize));
                                    topicOutBytes.AddRange(encryptEngine2.ProcessBlock(topic, i, chunkSize));
                                }
                                encTopic = Convert.ToBase64String(topicOutBytes.ToArray());

                                //Encrypt message with your public key
                                message = Encoding.UTF8.GetBytes(TBMessageS.Text);
                                for (int i = 0; i < message.Length; i += inBlockSize)
                                {
                                    chunkSize = Math.Min(inBlockSize, message.Length - ((i / inBlockSize) * inBlockSize));
                                    messageOutBytes.AddRange(encryptEngine2.ProcessBlock(message, i, chunkSize));
                                }

                                encMessage = Convert.ToBase64String(messageOutBytes.ToArray());

                                var request1 = new RestRequest("api/message/", Method.POST);
                                request1.AddHeader("Authorization", "Token " + Program.token);
                                request1.AddParameter("certificate_id", recipientCert.id);
                                request1.AddParameter("sender_id", infoAboutMe.id);
                                request1.AddParameter("recipient_id", recipientID);
                                request1.AddParameter("enc_topic", encTopic);
                                request1.AddParameter("enc_message", encMessage);
                                request1.AddParameter("send_date", timeNow);
                                request1.AddParameter("copy", false);

                                var response1 = Program.client.Execute(request1);
                                if (response1.StatusCode == System.Net.HttpStatusCode.Created)
                                {
                                    DataGridViewRow dgvRow = new DataGridViewRow();
                                    dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = response.Data.id });
                                    dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = employeeMail[recipientID] });
                                    dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = TBTopic.Text });
                                    dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = (DateTime.Parse(timeNow)).ToString("dd-MM-yy HH:mm:ss") });
                                    outbox.Add(response.Data.id, TBMessageS.Text);
                                    DGVOutBox.Rows.Add(dgvRow);

                                    MessageBox.Show("Wiadomość wysłano", "Sukces!");
                                    TBTopic.Text = "";
                                    TBMessageS.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
                                }
                            }
                            else //If I have empty certificate...
                            {
                                MessageBox.Show("Nie możesz wysłać wiadomości - nie masz ważnego certyfikatu", "Uwaga!");
                            }
                        }
                        else //If I don't have valid certificate...
                        {
                            MessageBox.Show("Nie możesz wysłać wiadomości - nie masz ważnego certyfikatu", "Uwaga!");
                        }
                    }
                    else //If recipient has empty certificate...
                    {
                        MessageBox.Show("Nie możesz wysłać wiadomości - odbiorca nie ma ważnego certyfikatu", "Uwaga!");
                    }
                }
                else //If recipient doesn't have valid certificate...
                {
                    MessageBox.Show("Nie możesz wysłać wiadomości - odbiorca nie ma ważnego certyfikatu", "Uwaga!");
                }
            }
        }

        private void SearchInDGV(object sender, EventArgs e)
        {
            /*
                0 - BSendMessages
                1 - BInBox
                2 - BOutBox
            */

            if (focusedButton == 0)
            {

            }
            else if (focusedButton == 1)
            {
                foreach (DataGridViewRow row in DGVInBox.Rows) //you receive msg
                {
                    if (RBReceiver.Checked == true)
                    {
                        row.Visible = row.Cells[1].Value.ToString().ToLower().StartsWith(TBSearch.Text.ToLower());//receiver
                    }
                    else if (RBTopic.Checked == true)
                    {
                        row.Visible = row.Cells[2].Value.ToString().ToLower().StartsWith(TBSearch.Text.ToLower());//topic
                    }
                    else if (RBSentDate.Checked == true)
                    {
                        row.Visible = DateTime.ParseExact(row.Cells[3].Value.ToString(), "dd-MM-yy HH:mm:ss", null).ToString("dd-MM-yy") == DateTime.Parse(dateTimePicker1.Value.ToString()).ToString("dd-MM-yy") ? true : false;//date 
                    }
                }
                foreach (DataGridViewRow row in DGVInBox.Rows) //You send msg
                {
                    if (row.Visible == true)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            else if (focusedButton == 2)
            {
                foreach (DataGridViewRow row in DGVOutBox.Rows) //You send msg
                {
                    if (RBReceiver.Checked == true)
                    {
                        row.Visible = row.Cells[1].Value.ToString().ToLower().StartsWith(TBSearch.Text.ToLower());//receiver
                    }
                    else if (RBTopic.Checked == true)
                    {
                        row.Visible = row.Cells[2].Value.ToString().ToLower().StartsWith(TBSearch.Text.ToLower());//topic
                    }
                    else if (RBSentDate.Checked == true)
                    {
                        row.Visible = DateTime.ParseExact(row.Cells[3].Value.ToString(), "dd-MM-yy HH:mm:ss", null).ToString("dd-MM-yy") == DateTime.Parse(dateTimePicker1.Value.ToString()).ToString("dd-MM-yy") ? true : false;//date 
                    }
                }
                foreach (DataGridViewRow row in DGVOutBox.Rows) //You send msg
                {
                    if (row.Visible == true)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            if (focusedButton == 1)
            {
                InboxSelectionChanged(null, null);
            }
            else if (focusedButton == 2)
            {
                OutboxSelectionChanged(null, null);
            }
        }

        private void RBCheckedChanged(object sender, EventArgs e)
        {
            if (RBSentDate.Checked == true)
            {
                TBSearch.Visible = false;
                dateTimePicker1.Visible = true;
            }
            else
            {
                TBSearch.Visible = true;
                dateTimePicker1.Visible = false;
            }
            SearchInDGV(null, null);
        }

        private void BChangePassword_Click(object sender, EventArgs e)
        {
            //highlight font in the clicked button
            BNewMessage.ForeColor = Color.Gray;
            BOutBox.ForeColor = Color.Gray;
            BInBox.ForeColor = Color.Gray;
            BApplyForTheCertificate.ForeColor = Color.Gray;
            BRevokeTheCertificate.ForeColor = Color.Gray;
            BChangePassword.ForeColor = Color.Black;

            PanelChangePassword form = new PanelChangePassword();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.No; //LogOut
                this.Close();
            }
        }
        private void PanelChangePassword_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.DarkGray, 3), this.DisplayRectangle);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }
    }

    public class Employee
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
        public int id { get; set; }
        public int certificate_id { get; set; }
        public int sender_id { get; set; }
        public int recipient_id { get; set; }
        public string enc_topic { get; set; }
        public string enc_message { get; set; }
        public string send_date { get; set; }
        public bool copy { get; set; }
    }

    class PrivateKey
    {
        public string not_valid_before_private_key { get; set; }
        public string not_valid_after_private_key { get; set; }
        public string privatekey { get; set; }
        public int cert_id { get; set; }
        public int id { get; set; }
    }
}