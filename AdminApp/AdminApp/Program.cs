using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp
{
    public class Token
    {
        public string token { get; set; }
    }
    static class Program
    {
        public static RestClient client = new RestClient("http://195.181.212.93:4567"); //Physical connection with server
        public static string token;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult dialogResult = DialogResult.No;
            LogInPanel logInPanel;
            MainForm form1;

            while (dialogResult != DialogResult.Cancel)
            {
                if (dialogResult == DialogResult.No) //user isn't logIn
                {
                    logInPanel = new LogInPanel();
                    dialogResult = logInPanel.ShowDialog();
                }
                if (dialogResult == DialogResult.Yes) //user is logIn
                {
                    form1 = new MainForm();
                    dialogResult = form1.ShowDialog();
                }
            }
        }
    }
}
