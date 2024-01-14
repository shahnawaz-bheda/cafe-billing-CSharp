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
    public partial class Registration : Form
    {
        String qry = String.Empty;
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-J6APG29;Initial Catalog=db_cafe;Integrated Security=True");
        SqlCommand cmd;

        public Registration()
        {
            InitializeComponent();  
        }

        void displaydata()
        {    
            qry = "select * from tbl_reg";
            cmd = new SqlCommand(qry, cnn);
            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LOGIN lg = new LOGIN();
            lg.Visible = true;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            qry = "INSERT INTO tbl_reg ";
            qry += "values( ";
            qry += "(SELECT MAX(reg_Id)+1 FROM tbl_reg), ";
            qry += "'" + txtfname.Text.Trim() + "', ";

            if (male.Checked == true)
            {
                qry += "' male ', ";
            }
            if (Female.Checked == true)
            {
                qry += "' female ', ";
            }
            qry += "'" + contact.Text.Trim() + "', ";
            qry += "'" + textemail.Text.Trim() + "', ";
            qry += "'" + txtuser.Text.Trim() + "', ";
            qry += "'" + txtpass.Text.Trim() + "', ";
            qry += "'True' ) ";

           
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Registrater Done....!");
            cnn.Close();
         
            displaydata();   
            this.Hide();
            LOGIN ln = new LOGIN();
            ln.Visible = true;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string gen;
            if (male.Checked)
                gen = "male";
            else
                gen = "female";

            gen = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtfname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            contact.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textemail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtuser.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtpass.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            cpass.Text  = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            qry = "Update tbl_reg set";
            qry += " name='" + txtfname.Text.ToString() + "' ,";
            qry += " contact_no='" + contact.Text.ToString() + "' ,";
            qry += " email_Id='" + textemail.Text.ToString() + "' ,";
            qry += " username='" + txtuser.Text.ToString() + "' ,";
            qry += " password='" + txtpass.Text.ToString() + "' ";
            qry += " where reg_Id=" + txtid.Text.ToString() + "";


            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated...!");

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cnn.Close();

            displaydata();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LOGIN lg = new LOGIN();
            lg.Visible = true;
        }
    }
}


