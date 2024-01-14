using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signIn_form1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing bl = new Billing();
            bl.Visible = true;
        }

       
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN ln = new LOGIN();
            ln.Visible = true;
        }

       
        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            About_Us au = new About_Us();
            au.Visible = true;
        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
      
        {
            this.Hide();
            category subcat = new category();
            subcat.Visible = true;    
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Hide();
            subcategory subcat = new subcategory();
            subcat.Visible = true;

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Product prod = new Product();
            prod.Visible = true;
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            About_Us ab = new About_Us();
            ab.Visible = true;
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN ln = new LOGIN();
            ln.Visible = true;
        }

        private void addTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            tablemenu tbm = new tablemenu();
            tbm.Visible = true;
        }

        private void addOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            neworder o = new neworder();
            o.Visible = true;
        }
    }
}
