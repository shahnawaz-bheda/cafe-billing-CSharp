using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;

namespace signIn_form1
{
    public partial class LOGIN : Form
    {
        String qry = String.Empty;

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-J6APG29;Initial Catalog=db_cafe;Integrated Security=True");
       
        public LOGIN()
        {
            InitializeComponent();
        }

        private void reglink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration rs = new Registration();
            rs.ShowDialog(); 
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
                cnn.Open();
                qry = "SELECT * FROM tbl_reg ";
                qry += "where ";
                qry += "username ='"+ txtuser.Text.Trim() +"' AND ";
                qry += "password ='" + txtpass.Text.Trim() + "' ";

                SqlDataAdapter da = new SqlDataAdapter(qry, cnn);
                DataTable dtl=new DataTable();
                da.Fill(dtl);
                cnn.Close();    

                if (dtl.Rows.Count == 1)
                {
                    this.Hide();
                    Home hm = new Home();
                    hm.Visible = true;
                }
                else
                {
                    MessageBox.Show("Invalid....!");

                }

        }
        
        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            txtuser.Text = string.Empty;
            txtpass.Text = string.Empty;
            this.Close();
        }

        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpass.Checked)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
            
        }
    }
}
