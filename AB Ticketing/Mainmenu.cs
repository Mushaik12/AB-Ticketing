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
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainbill mbill = new mainbill();
            mbill.TopLevel = false;
            panel3.Controls.Add(mbill);
            mbill.BringToFront();
            mbill.Show();
            
        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerregistration cr = new customerregistration();
            cr.TopLevel = false;
            panel3.Controls.Add(cr);
            cr.BringToFront();
            cr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reports rpt = new reports();
            rpt.TopLevel = false;
            panel3.Controls.Add(rpt);
            rpt.BringToFront();
            rpt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login log1 = new Login();
            log1.Show();
            this.Hide();
        }
    }
}
