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
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void Entr_Btn_Click(object sender, EventArgs e)
        {
            string userName = UserBox.Text;
            string password = PassBox.Text;

            if (userName=="SystemAdmin_PP" && password=="Polly@007") 
            {
                MessageBox.Show("Login to System Successfully...!","LOGIN SUCCESS",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                Company_Details obj = new Company_Details();
                this.Hide();
                obj.Show();
            }
            else 
            {
                MessageBox.Show("Invalid User name or Password ", "LOGIN FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to exit...?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}
