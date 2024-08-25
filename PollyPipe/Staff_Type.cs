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
    public partial class Staff_Type : Form
    {
        public Staff_Type()
        {
            InitializeComponent();
        }

        private void Sta_Ty_CanBtn_Click(object sender, EventArgs e)
        {
            var BackForm = new Staff();
            this.Hide();
            BackForm.Show();
        }
    }
}
