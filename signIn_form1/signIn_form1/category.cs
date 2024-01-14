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
    public partial class category : Form
    {
        String qry = String.Empty;
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-J6APG29;Initial Catalog=db_cafe;Integrated Security=True");
        SqlCommand cmd;

        public category()
        {
            InitializeComponent();
        }

        private void subcategory_Load(object sender, EventArgs e)
        {
           
        }
        void displaydata()
        {
            qry = "select * from tbl_addcat";
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cnn.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            qry = "INSERT INTO tbl_addcat ";
            qry += "values( ";
            qry += "(SELECT MAX(cat_Id)+1 FROM tbl_addcat), ";
            qry += "'" + textBox1.Text.Trim() + "', ";
            qry += "'True' ) ";
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Category Added sucessfully");

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cnn.Close();

            displaydata();

            this.Hide();
            category sc = new category();
            sc.Visible = true;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Visible = true;
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            displaydata();
        }

        private void catupdate_Click(object sender, EventArgs e)
        {
            qry = "Update tbl_addcat set";
            qry += " cat_name='" + textBox1.Text.ToString() + "'";
            qry += " where cat_Id=" + cat_Id.Text.ToString() + "";

            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Category Updated...!");

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cnn.Close();

            displaydata();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cat_Id.Text = dataGridView1.SelectedRows[e.RowIndex].Cells[0].Value.ToString();
               cat_Id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
              textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            qry = "DELETE tbl_addcat ";
            qry += " where cat_Id=" + cat_Id.Text.ToString() + "";

            
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Category Deleted...!");

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            cnn.Close();

            displaydata();
        }
    }
}
