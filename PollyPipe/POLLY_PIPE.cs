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
    public partial class POLLY_PIPE : Form
    {
        public POLLY_PIPE()
        {
            InitializeComponent();
        }
        private void wel_timer_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;
            if (panel2.Width >=700)
            {
                wel_timer.Stop();
                LOGIN obj = new LOGIN();
                this.Hide();
                obj.Show();
            }
        }

        private void POLLY_PIPE_Load(object sender, EventArgs e)
        {

        }
    }
}
