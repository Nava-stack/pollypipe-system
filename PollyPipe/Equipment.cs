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
    public partial class Equipment : Form
    {
        public Equipment()
        {
            InitializeComponent();
        }

        private void Eq_TyBtn_Click(object sender, EventArgs e)
        {
            Equipment_Type obj = new Equipment_Type();
            this.Hide();
            obj.Show();
        }

        private void Eq_CanBtn_Click(object sender, EventArgs e)
        {
            var BackForm = new FacilityForm();
            this.Hide();
            BackForm.Show();
        }
    }
}
