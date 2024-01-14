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
    public partial class neworder : Form
    {
        String qry = String.Empty;
        SqlConnection cnn = new SqlConnection(@"Data source=DESKTOP-J6APG29;Initial Catalog=db_cafe;Integrated Security=True");
        SqlCommand cmd;

        int myTotAmt = 0;
        double myPayableAmt = 0.0;

        static DataSet DS_Products = new DataSet();
        public neworder()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void AddDataToDB()
        {
            
        
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            dtGrd_Items.Rows.Add();
            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[0].Value = dtGrd_Items.Rows.Count.ToString();
            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[1].Value = cmbProducts.SelectedValue.ToString();
            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[2].Value = cmbProducts.Text;
            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[3].Value = txtQTY.Text;
            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[4].Value = lblPrice.Text;
            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[5].Value = (int.Parse(txtQTY.Text) * int.Parse(lblPrice.Text)).ToString();
            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[6].Value = cmbTable.SelectedValue.ToString();

            cmbProducts.SelectedIndex = 0;
            txtQTY.Clear();
            cmbProducts.Focus();            
        }
        public void BindTable()
        {
            qry = "SELECT Table_Id, Table_name FROM tbl_tablemenu WHERE Table_IsAct = 'TRUE' ORDER BY Table_Id";
            DataSet DS_Table = new DataSet();
            cmd = new SqlCommand(qry, cnn);
            
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DS_Table);
            cmbTable.ValueMember = "Table_Id";
            cmbTable.DisplayMember = "Table_name";
            cmbTable.DataSource = DS_Table.Tables[0];

            if(cmbTable.Items.Count > 0)
            cmbTable.SelectedIndex = 0;
        }
        public void BindProduct()
        {
            qry = "SELECT prod_Id, prod_name, prod_price FROM tbl_prod WHERE prod_IsAct = 'TRUE' ORDER BY prod_name";            
            cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DA.Fill(DS_Products);
            cmbProducts.ValueMember = "prod_Id";
            cmbProducts.DisplayMember = "prod_name";
            cmbProducts.DataSource = DS_Products.Tables[0];
            if (cmbProducts.Items.Count > 0)
                cmbProducts.SelectedIndex = 0;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void neworder_Load(object sender, EventArgs e)
        {
            
        }

        private void neworder_Load_1(object sender, EventArgs e)
        {
            BindTable();
            BindProduct();
            btnadd.Enabled = false;
            btnbill.Enabled = false;            
        }

        private void btndisplay(object sender, EventArgs e)
        {
            if (cmbTable.SelectedIndex >= 0)
            {
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_orderitem WHERE tab_Id = " + cmbTable.SelectedValue.ToString() + " AND io_IsAct = 'TRUE'", cnn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtGrd_Items.DataSource = dt;
                cnn.Close();
            }
        }

        private void product_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrice.Text = DS_Products.Tables[0].Rows[cmbProducts.SelectedIndex][2].ToString();
        }

        void displaydata()
        {
            qry = "select * from tbl_subcat";
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dtGrd_Items.DataSource = dt;
            cnn.Close();
        }
       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void CalcMyData()
        {
            foreach (DataGridViewRow DGR in dtGrd_Items.Rows)
            {
                myTotAmt += int.Parse(DGR.Cells[5].Value.ToString());
            }

            myPayableAmt = (double.Parse(myTotAmt.ToString()) * 0.18) + myTotAmt;
        }
        private void btnbill_Click(object sender, EventArgs e)
        {
            CalcMyData();
            qry = "UPDATE tbl_orderitem SET ";
            qry += "order_Id = (SELECT MAX(order_Id) + 1 FROM tbl_order), io_IsAct = 'FALSE' ";
            qry += "WHERE tab_Id = " + cmbTable.SelectedValue.ToString() + " AND io_IsAct = 'TRUE'";
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

            qry = "INSERT INTO tbl_order VALUES( ";
            qry += "(SELECT MAX(order_Id) + 1 FROM tbl_order), ";
            qry += "'"+ System.DateTime.Now.ToString("yyyy-MM-dd") +"', ";
            qry += "" + myTotAmt.ToString() + ", " + myPayableAmt.ToString() + ", 'Y', 'FALSE')";
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();


            qry = "SELECT ORD.order_Id, PR.prod_name, PR.prod_price, OI.qty, OI.price, OI.tab_Id, ORD.order_date, ORD.totamnt, ORD.payble_amnt ";
            qry += "FROM ";
            qry += "tbl_order ORD, tbl_orderitem OI, tbl_prod PR ";
            qry += "WHERE ";
            qry += "ORD.order_Id = OI.order_Id AND ";
            qry += "OI.prod_Id = PR.prod_Id AND ";
            qry += "ORD.order_Id = (SELECT MAX(order_Id) FROM tbl_order) ";
            qry += "ORDER BY OI.Order_ID";

            
            cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            DS.WriteXml(Application.StartupPath.ToString() + "\\CafeBill.xml");            
            cnn.Close();
            Billing b = new Billing();            
            b.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Visible = true;
        }

        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTable.SelectedIndex == 0)
            {
                btnadd.Enabled = false;
                btnbill.Enabled = false;                
            }
            else
            {
                if (cmbTable.Text.Contains("Away"))
                {
                    lblContN0.Visible = true;
                    txtContactNo.Visible = true;
                }
                else
                {
                    lblContN0.Visible = false;
                    txtContactNo.Visible = false;
                    qry = "SELECT OI.prod_Id, PR.prod_name, OI.qty, PR.prod_price, (OI.qty * PR.prod_price), '"+ cmbTable.SelectedValue.ToString() +"' ";
                    qry += "FROM tbl_orderitem OI, tbl_prod PR ";
                    qry += "WHERE OI.prod_Id = PR.prod_Id AND ";
                    qry += "OI.tab_Id = "+ cmbTable.SelectedValue.ToString() +" AND ";
                    qry += "OI.io_IsAct = 'TRUE' ";
                    qry += "ORDER BY OI.oi_Id";
                    cnn.Open();
                    cmd = new SqlCommand(qry, cnn);
                    SqlDataReader DR = cmd.ExecuteReader();
                    if (DR.HasRows)
                    {
                        dtGrd_Items.Rows.Clear();
                        while (DR.Read())
                        {
                            dtGrd_Items.Rows.Add();
                            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[0].Value = dtGrd_Items.Rows.Count.ToString();
                            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[1].Value = DR.GetValue(0).ToString();
                            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[2].Value = DR.GetValue(1).ToString();
                            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[3].Value = DR.GetValue(2).ToString();
                            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[4].Value = DR.GetValue(3).ToString();
                            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[5].Value = DR.GetValue(4).ToString();
                            dtGrd_Items.Rows[dtGrd_Items.Rows.Count - 1].Cells[6].Value = DR.GetValue(5).ToString();
                        }
                    }
                    else dtGrd_Items.Rows.Clear();
                    DR.Close();
                    cnn.Close();
                }                
                btnadd.Enabled = true;
                btnbill.Enabled = true;                
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void totamt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            qry = "DELETE FROM tbl_orderitem WHERE tab_Id = " + cmbTable.SelectedValue.ToString() + " AND io_IsAct = 'TRUE'";
            cnn.Open();
            cmd = new SqlCommand(qry, cnn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            for (int i = 0; i < dtGrd_Items.Rows.Count; i++)
            {
                qry = "INSERT INTO tbl_orderitem ";
                qry += "values( ";
                qry += "(SELECT MAX(oi_Id)+1 FROM tbl_orderitem), ";
                qry += "" + dtGrd_Items.Rows[i].Cells[6].Value + ", ";                
                qry += "'" + dtGrd_Items.Rows[i].Cells[1].Value + "', ";
                qry += "'" + dtGrd_Items.Rows[i].Cells[3].Value + "', ";
                qry += "" + dtGrd_Items.Rows[i].Cells[5].Value + ", ";
                qry += "'" + dtGrd_Items.Rows[i].Cells[6].Value + "', ";
                qry += "'True' ) ";
                cmd = new SqlCommand(qry, cnn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();                
            }
            cnn.Close();
            MessageBox.Show("Order Placed...");
        }

    }
}
