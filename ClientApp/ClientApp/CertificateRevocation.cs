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
    public partial class CertificateRevocation : Form
    {
        public CertificateRevocation(int certID)
        {
            InitializeComponent();
            FillCBRevocationReason();
            this.certID = certID;
        }

        int certID;

        private void FillCBRevocationReason()
        {
            //Get employees
            var request = new RestRequest("/api/cancellation_reason/", Method.GET);
            request.AddHeader("Authorization", "Token " + Program.token);
            //Get employes
            IRestResponse<List<CancellationReason>> response = Program.client.Execute<List<CancellationReason>>(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                CBRevocationReason.ValueMember = "id";
                CBRevocationReason.DisplayMember = "description";
                CBRevocationReason.DataSource = response.Data;
            }
            else
            {
                MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
            }
        }
        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BRevokeCertificate_Click(object sender, EventArgs e)
        {
            if (CBRevocationReason.Text == "")
            {
                MessageBox.Show("Powód unieważnienia musi zostać wybrany", "Uwaga");
            }
            else
            {
                int revocationID = (int)CBRevocationReason.SelectedValue;

                string certReq = "";
                certReq = "api/certificate/" + certID + "/revoke/";
                var request = new RestRequest(certReq, Method.POST);
                request.AddHeader("Authorization", "Token " + Program.token);
                request.AddParameter("reason_id", revocationID);
                var response = Program.client.Execute(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Certyfikat został unieważniony", "Sukces!");
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Błąd wewnętrzny aplikacji, skontaktuj się z administratorem", "Błąd!");
                    this.DialogResult = DialogResult.No;
                }
            }
        }
        private void CertificateRevocation_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }
    }
    public class CancellationReason
    {
        public int id { get; set; }
        public string description { get; set; }
    }
}
