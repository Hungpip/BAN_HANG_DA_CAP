using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Xml.Linq;

namespace BAN_HANG_DA_CAP
{
    public partial class Update_Product : Form
    {
        SqlConnection connection;
        public Update_Product()
        {
            InitializeComponent();
            CenterToScreen();
            connection = new SqlConnection("Server=DESKTOP-AGPGF6N\\SQLEXPRESS;Database=product_management;Integrated Security=true;");
        }
        private void Update_Product_Load(object sender, EventArgs e)
        {           
            FillTable();
            GetCate();
        }
        public void FillTable()
        {
            string query = "select * from product";
            connection.Open();
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dgv.DataSource = tbl;
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_form main_Form = new Main_form();
            main_Form.ShowDialog();
            this.Dispose();
        }
        public void GetCate()
        {
            string query = "select category_id, category_name from category";
            DataTable table = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(table);
            comboBox1.DataSource = table;
            comboBox1.DisplayMember = "category_name";
            comboBox1.ValueMember = "category_id";
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Do you want delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                connection.Open();
                string delete = "delete from product where product_id = @id";
                SqlCommand cmd = new SqlCommand(delete, connection);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = txtPro.Text;
                cmd.ExecuteNonQuery();
                connection.Close();
                FillTable();
            }

        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            int error = 0;
            string id = txtPro.Text;
            if (id == "")
            {
                error += 1;
                lbErPo.Text = "ID can't be blank";
            }
            else lbErPo.Text = "";

            string name = txtName.Text;
            if (name == "")
            {
                error += 1;
                lbErNa.Text = "Product_Name can't be blank";
            }
            else lbErNa.Text = "";
            string quan = txtQuan.Text;
            if(quan == "")
            {
                error += 1;
                lbErQuan.Text = "Quantity can't be blank";
            }
            else
            {
                string query = "select * from product where product_id = @id";
                connection.Open();
                SqlCommand cmdCheck = new SqlCommand(query, connection);
                cmdCheck.Parameters.Add("@id", SqlDbType.Int);
                cmdCheck.Parameters["@id"].Value = id;
                SqlDataReader reader = cmdCheck.ExecuteReader();
                if (reader.Read())
                {
                    error++;
                    lbErPo1.Text = "This id is existing, please choose another";
                }
                else
                {
                    lbErPo1.Text = "";
                  
                }
                connection.Close();
            }
            string price = txtPri.Text;
            if (price == "")
            {
                error += 1;
                lbErPri.Text = "Price can't be blank";
            }
            else lbErPri.Text = "";

            string catid = comboBox1.SelectedValue.ToString();
            if(error == 0)
            {
                string insert = "insert into product (product_id, product_name,category_id,price,quantity) values (@id, @product_name, @category_id, @price,@quantity) ";
                connection.Open();
                SqlCommand cmd = new SqlCommand(insert, connection);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = id;
                cmd.Parameters.Add("@product_name", SqlDbType.VarChar);
                cmd.Parameters["@product_name"].Value = name;
                cmd.Parameters.Add("@category_id", SqlDbType.Int);
                cmd.Parameters["@category_id"].Value = catid;
                cmd.Parameters.Add("@price", SqlDbType.BigInt);
                cmd.Parameters["@price"].Value = price;
                cmd.Parameters.Add("@quantity", SqlDbType.Int);
                cmd.Parameters["@quantity"].Value = quan;
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show(this, "Inserted successfully", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbErCa.Text = "";
                lbErNa.Text = "";
                lbErPo.Text = "";
                lbErPri.Text = "";
                lbErQuan.Text = "";

            }
            txtName.Text = "";
            txtPri.Text = "";
            txtPro.Text = "";
            txtQuan.Text = "";
            FillTable();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(this, "Do you want update ?", "Question",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                string update = "update product set product_name=@product_name, price=@price, category_id = @cat_id, quantity=@quantity where product_id=@id";
                connection.Open();
                SqlCommand cmd = new SqlCommand(update, connection);
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = int.Parse(txtPro.Text);
                cmd.Parameters.Add("@product_name", SqlDbType.VarChar);
                cmd.Parameters["@product_name"].Value = txtName.Text;
                cmd.Parameters.Add("@quantity", SqlDbType.VarChar);
                cmd.Parameters["@quantity"].Value = txtQuan.Text;
                cmd.Parameters.Add("@price", SqlDbType.BigInt);
                cmd.Parameters["@price"].Value = long.Parse(txtPri.Text);
                cmd.Parameters.Add("@cat_id", SqlDbType.Int);
                cmd.Parameters["@cat_id"].Value = comboBox1.SelectedValue;
                var i = cmd.ExecuteNonQuery();
                connection.Close();
                if (i > 0)
                {
                    FillTable();
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                txtPro.Text = row.Cells["Column1"].Value.ToString();
                txtName.Text = row.Cells["Column2"].Value.ToString();
                txtQuan.Text = row.Cells["Column3"].Value.ToString();
                comboBox1.SelectedValue = row.Cells["Column4"].Value;
                txtPri.Text = row.Cells["Column5"].Value.ToString();
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
