﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class LogInPanel : Form
    {
        public LogInPanel()
        {
            InitializeComponent();
        }

        private void BLogIn_Click(object sender, EventArgs e)
        {
            if (TBLogin.Text == "" || TBPassword.Text == "")
            {
                MessageBox.Show("Przynajmniej jedno z wymaganych pól jest nieuzupełnione!", "Błąd!");
            }
            else
            {
                var request = new RestRequest("api/login/", Method.POST);
                request.AddParameter("username",TBLogin.Text);

                //Password hash
                //SHA256 mySHA256 = SHA256Managed.Create();
                //byte[] hashValue = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(TBPassword.Text));
                string hashValueS = TBPassword.Text;//Encoding.ASCII.GetString(hashValue);

                request.AddParameter("password", hashValueS);
                IRestResponse<Token> response = Program.client.Execute<Token>(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Program.token = response.Data.token; //Get token
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Podano nieprawidłowy login lub hasło!", "Błąd!");
                }
            }
        }

        private void EnterClicked(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                BLogIn_Click(sender, e);
            }
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelChangePassword_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawRectangle(new Pen(Color.DarkGray, 3), this.DisplayRectangle);
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }
    }
}
