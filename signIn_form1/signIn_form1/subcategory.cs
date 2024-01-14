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
    public partial class subcategory : Form
    {
        String qry = String.Empty;
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-J6APG29;Initial Catalog=db_cafe;Integrated Security=True"); 
        SqlCommand cmd;

        public subcategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            qry = "INSERT INTO tbl_subcat ";
            qry += "values( ";
            qry += "(SELECT MAX(subcat_Id)+1 FROM tbl_subcat), ";
            qry += "'" + cbsubcat.SelectedValue.ToString() + "', ";
            qry += "'" + txtsubcat.Text.Trim() + "', ";
            qry += "'True' ) ";

            MessageBox.Show("subCategory Added sucessfully");
           
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();

            this.Hide();
            subcategory sc = new subcategory();
            sc.Visible = true;

        }

        
        private void subcategory_Load(object sender, EventArgs e)
        {
            findcat();
        }
        void displaydata()
        {
            qry = "select * from tbl_subcat";
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home cat = new Home();
            cat.Visible = true;
        }

           public void findcat()
        {
            qry = "SELECT cat_ID,cat_name FROM tbl_addcat";
            
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cbsubcat.DisplayMember = "cat_name";
            cbsubcat.ValueMember = "cat_ID";

            cbsubcat.DataSource = ds.Tables[0];



            cnn.Close();

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            qry = "DELETE tbl_subcat ";
            qry += " where subcat_Id=" + subcatid.Text.ToString() + "";

            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Deleted...!");

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cnn.Close();

            displaydata();
        }

        private void display_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            subcatid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtsubcat.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            qry = "Update tbl_subcat set";
            qry += " subcat_name='" + txtsubcat.Text.ToString() + "' ";
            qry += " where subcat_Id=" + subcatid.Text.ToString() + "";


           
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
            
        }
    }
}
