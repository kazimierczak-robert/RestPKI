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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
