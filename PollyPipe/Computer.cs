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
    public partial class Computer : Form
    {
        public Computer()
        {
            InitializeComponent();
        }

        private void Com_CanBtn_Click(object sender, EventArgs e)
        {
            var BackForm = new FacilityForm();
            this.Hide();
            BackForm.Show();
        }
    }
}
