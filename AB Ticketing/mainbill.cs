using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AB_Ticketing
{
    public partial class mainbill : Form
    {
        public mainbill()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            Mainmenu mu = new Mainmenu();
            mu.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
