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
    public partial class Equipment_Type : Form
    {
        public Equipment_Type()
        {
            InitializeComponent();
        }

        private void Eq_Ty_CanBtn_Click(object sender, EventArgs e)
        {
            var BackForm = new Equipment();
            this.Hide();
            BackForm.Show();
        }
    }
}
