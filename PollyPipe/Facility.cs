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
    public partial class FacilityForm : Form
    {
        public FacilityForm()
        {
            InitializeComponent();
        }

        private void Eq_Btn_Click(object sender, EventArgs e)
        {
            Equipment obj = new Equipment();
            this.Hide();
            obj.Show();
        }

        private void StaffBtn_Click(object sender, EventArgs e)
        {
            Staff obj = new Staff();
            this.Hide();
            obj.Show();
        }

        private void ComBtn_Click(object sender, EventArgs e)
        {
            Computer obj = new Computer();
            this.Hide();
            obj.Show();
        }

        private void Fac_CanBtn_Click(object sender, EventArgs e)
        {
            var BackForm = new Company_Details();
            this.Hide();
            BackForm.Show();
        }
    }
}
