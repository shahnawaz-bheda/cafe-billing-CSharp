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
    public partial class Product : Form
    {
        String qry = String.Empty;
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-J6APG29;Initial Catalog=db_cafe;Integrated Security=True");
        SqlCommand cmd;

        public Product()
        {
            InitializeComponent();
        }
        private void category_Load(object sender, EventArgs e)
        {
            findcat();
            findsubcat();
        }
        void displaydata()
        {
            qry = "select * from tbl_prod";
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
            Home sb = new Home();
            sb.Visible = true;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.Hide();
            category cat = new category();
            cat.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            qry = "INSERT INTO tbl_prod ";
            qry += "values( ";
            qry += "(SELECT MAX(prod_Id)+1 FROM tbl_prod), ";
            qry += "'" + cmbsubcat.SelectedValue.ToString() + "', ";
            qry += "'" + txtname.Text.Trim() + "', ";
            qry += "'" + addprice.Text.Trim() + "', ";
            qry += "'True' ) ";

           
            MessageBox.Show("Product Added sucessfully");
            
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();
            

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cnn.Close();

            displaydata();

            this.Hide();
            Product sc = new Product();
            sc.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btndisp_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prodId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            addprice.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            qry = "Update tbl_prod set";
            qry += " prod_name='" + txtname.Text.ToString() + "' ,";
            qry += " prod_price='" + addprice.Text.ToString() + "'";
            qry += " where prod_Id=" + prodId.Text.ToString() + "";


            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();
        
            MessageBox.Show("Record Updated...!");

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cnn.Close();

            displaydata();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            qry = "DELETE tbl_prod ";
            qry += " where prod_Id=" + prodId.Text.ToString() + "";

           
         
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Deleted...!");

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cnn.Close();

            displaydata();
        }

         public void findcat()
        {
            qry = "SELECT cat_name FROM tbl_addcat";

            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmbcat.DisplayMember = "cat_name";
            cmbcat.DataSource = ds.Tables[0];
            cnn.Close();

        }
        public void findsubcat()
        {
            qry = "SELECT subcat_Id,subcat_name FROM tbl_subcat";

            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            
            cmbsubcat.ValueMember = "subcat_Id"; 
            cmbsubcat.DisplayMember = "subcat_name";
            cmbsubcat.DataSource = ds.Tables[0];
            cnn.Close();

        }

       
    }
}
