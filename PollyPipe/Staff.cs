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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_TyBtn_Click(object sender, EventArgs e)
        {
            Staff_Type obj = new Staff_Type();
            this.Hide();
            obj.Show();
        }

        private void Sta_CanBtn_Click(object sender, EventArgs e)
        {
            var BackForm = new FacilityForm();
            this.Hide();
            BackForm.Show();
        }
    }
}
