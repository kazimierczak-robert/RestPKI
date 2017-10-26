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

            for (int i = 0; i < 10; i++)
            {
                var index = DGVEmployees.Rows.Add();
                DGVEmployees.Rows[index].Cells[0].Value = index;
                DGVEmployees.Rows[index].Cells[1].Value = "Jan";
                DGVEmployees.Rows[index].Cells[2].Value = "Nowak";
                DGVEmployees.Rows[index].Cells[3].Value = 77000312398;
                DGVEmployees.Rows[index].Cells[4].Value = "Nowa 1, 12-345, Poznań";
                DGVEmployees.Rows[index].Cells[5].Value = "03.00.1977";
            }

            if (DGVEmployees.Rows.Count<11)
            {
                BNewEmployee.Location = new Point(506, 262);
                this.Size = new Size(645, 336);
            }
            else
            {
                BNewEmployee.Location = new Point(522, 262);
                this.Size = new Size(661, 336);
            }
        }

        private void BNewEmployee_Click(object sender, EventArgs e)
        {
            PEmployee.Visible = true;

            if (DGVEmployees.Rows.Count < 11)
            {
                this.Size = new Size(830, 336);
                PEmployee.Location = new Point(616, 12);
            }
            else
            {
                this.Size = new Size(850, 336);
                PEmployee.Location = new Point(636, 12);
            }
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            PEmployee.Visible = false;
            if (DGVEmployees.Rows.Count < 11)
            {
                this.Size = new Size(645, 336);
            }
            else
            {
                this.Size = new Size(661, 336);
            }
        }

        private void BApply_Click(object sender, EventArgs e)
        {
            PEmployee.Visible = false;

            var index = DGVEmployees.Rows.Add();
            DGVEmployees.Rows[index].Cells[0].Value = index;
            DGVEmployees.Rows[index].Cells[1].Value = "Jan";
            DGVEmployees.Rows[index].Cells[2].Value = "Nowak";
            DGVEmployees.Rows[index].Cells[3].Value = 77000312398;
            DGVEmployees.Rows[index].Cells[4].Value = "Nowa 1, 12-345, Poznań";
            DGVEmployees.Rows[index].Cells[5].Value = "03.00.1977";

            if (DGVEmployees.Rows.Count < 11)
            {
                BNewEmployee.Location = new Point(506, 262);
                this.Size = new Size(645, 336);
            }
            else
            {
                BNewEmployee.Location = new Point(522, 262);
                this.Size = new Size(661, 336);
            }
        }
    }
}
