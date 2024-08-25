using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PollyPipe
{
    public partial class Company_Details : Form
    {
        public Company_Details()
        {
            InitializeComponent();
        }

        private void CustomerBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moving to Customer Details form","Forms Confirmation",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            CustomerForm obj = new CustomerForm();
            this.Hide();
            obj.Show();

        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            PayForm obj = new PayForm();
            this.Hide();
            obj.Show();
        }
        private void InstallBtn_Click(object sender, EventArgs e)
        {
            InstallForm obj = new InstallForm();
            this.Hide();
            obj.Show();
        }

        private void FacilityBtn_Click(object sender, EventArgs e)
        {
            FacilityForm obj = new FacilityForm();
            this.Hide();
            obj.Show();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit...?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
