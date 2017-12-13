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
    public partial class PanelChangePassword : Form
    {
        public PanelChangePassword()
        {
            InitializeComponent();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BChangePassword_Click(object sender, EventArgs e)
        {
            if (TBCurrentPassword.Text == "" || TBNewPassword.Text == "" || TBNewPassword2.Text == "")
            {
                MessageBox.Show("Przynajmniej jedno z wymaganych pól jest nieuzupełnione!", "Błąd!");
            }
            else
            {
                if (TBNewPassword.Text !=TBNewPassword2.Text)
                {
                    MessageBox.Show("Podane nowe hasła nie są takie same!", "Błąd!");
                }
                else
                {
                    var request = new RestRequest("api/changepass/", Method.POST);
                    request.AddHeader("Authorization", "Token " + Program.token);
                    request.AddParameter("username", Program.form1.infoAboutMe.company_email);
                    request.AddParameter("oldpass", TBCurrentPassword.Text);
                    request.AddParameter("newpass", TBNewPassword.Text);

                    var response  = Program.client.Execute(request);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        MessageBox.Show("Hasło zostało zmienione", "Sukces!");
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hasło nie zostało zmienione, proszę skontaktować się z administratorem", "Błąd!");
                        this.DialogResult = DialogResult.No;
                    }
                }

            }
        }
        private void PanelChangePassword_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.DarkGray, 3), this.DisplayRectangle);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        private void EnterClicked(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                BChangePassword_Click(sender, e);
            }
        }
    }
}
