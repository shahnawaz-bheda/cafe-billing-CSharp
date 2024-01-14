using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace signIn_form1
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }
        private void Billing_Load(object sender, EventArgs e)
        {
            LoadData();   
        }
        void LoadData()
        {            

            rptBill rpt = new rptBill();
            rpt.FullResourceName = Application.StartupPath.ToString() + "\\CafeBill.xml";
            CRV1.ReportSource = rpt;
            CRV1.Refresh();           
              
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Home hm = new Home();
            hm.Visible = true;
           
        }
    }
}
