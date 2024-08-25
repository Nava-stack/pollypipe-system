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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }

        private void Pay_CanBtn_Click(object sender, EventArgs e)
        {
            var BackForm = new Company_Details();
            this.Hide();
            BackForm.Show();
        }
    }
}
