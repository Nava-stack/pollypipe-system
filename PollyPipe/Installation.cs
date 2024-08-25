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
    public partial class InstallForm : Form
    {
        public InstallForm()
        {
            InitializeComponent();
        }

        private void Equ_QtyBtn_Click(object sender, EventArgs e)
        {
            Equipment_Quantity obj = new Equipment_Quantity();
            this.Hide();
            obj.Show();
        }

        private void Staff_QtyBtn_Click(object sender, EventArgs e)
        {
            Staff_Quantity obj = new Staff_Quantity();
            this.Hide();
            obj.Show();
        }

        private void Ins_CanBtn_Click(object sender, EventArgs e)
        {
            var BackForm = new Company_Details();
            this.Hide();
            BackForm.Show();
        }

        private void InstallTypeBtn_Click(object sender, EventArgs e)
        {
            InstallTypeForm obj = new InstallTypeForm();
            this.Hide();
            obj.Show();
        }
    }
}
