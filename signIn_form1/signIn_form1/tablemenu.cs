using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace signIn_form1
{
    public partial class tablemenu : Form
    {
        String qry = String.Empty;

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-J6APG29;Initial Catalog=db_cafe;Integrated Security=True");
        SqlCommand cmd;

        public tablemenu()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            qry = "INSERT INTO tbl_tablemenu ";
            qry += "values( ";
            qry += "(SELECT MAX(Table_Id)+1 FROM tbl_tablemenu), ";
            qry += "'" + tablename.Text.Trim() + "', ";
            qry += "'" + capacity.Text.Trim() + "', ";
            qry += "'True' ) ";

            
            MessageBox.Show("Table Added....!");
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
          
            this.Hide();
            tablemenu tbl = new tablemenu();
            tbl.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Visible = true;
        }
    }
}
