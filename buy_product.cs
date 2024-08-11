using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAN_HANG_DA_CAP
{
    public partial class buy_product : Form
    {
        SqlConnection connection;
        public buy_product()
        {
            InitializeComponent();
            CenterToScreen();
            connection = new SqlConnection("Server=DESKTOP-AGPGF6N\\SQLEXPRESS;Database=product_management;Integrated Security=true;");
            view_of_product_Load();
        }

        public void view_of_product_Load()
        {
            connection.Open(); 
            FillData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit? If you exit, you will lose data ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Main_form main_Form = new Main_form();
                main_Form.ShowDialog();
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtQuan.Text == "")
            {
                MessageBox.Show("Fill Text");
            }
            else
            {
                
                if (product_list.SelectedRows.Count <= 0 || customer_list.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Must select a product and a customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show(this, "Do you want by this", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var insert = "insert into personal_information(c_id, p_id, quantity, date) values (@c, @p, @q, @d)";

                        var product_id = product_list.SelectedRows[0].Cells["Column1"].Value.ToString();
                        var customer_id = customer_list.SelectedRows[0].Cells["cus_id_col"].Value.ToString();
                        var quantity = txtQuan.Text;
                        var date = DateTimeOffset.Now.ToUnixTimeMilliseconds();

                        connection.Open();
                        var cmd = new SqlCommand(insert, connection);
                        cmd.Parameters.AddWithValue("@c", customer_id);
                        cmd.Parameters.AddWithValue("@p", product_id);
                        cmd.Parameters.AddWithValue("@q", quantity);
                        cmd.Parameters.AddWithValue("@d", date);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Order Successfully");
                        txtQuan.Text = "";
                    }else   return;

                }
            }
        }
        private void btnIF_Click(object sender, EventArgs e)
        {
            string insert = "insert into customer (id, Name, category_name, quantity, price) values(@id, @name, @cat, @quan, @price)";
            connection.Open();
            SqlCommand cmd = new SqlCommand(insert, connection);
            cmd.ExecuteNonQuery();
            txtQuan.Text = "";
            connection.Close();
        }
        private void FillData()
        {
            string query = "select * from product";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            product_list.DataSource = tbl;
            query = "select id, name, number from customer";
            DataTable tbl2 = new DataTable();
            SqlDataAdapter ad2 = new SqlDataAdapter(query, connection);
            ad2.Fill(tbl2);
            customer_list.DataSource = tbl2;
            connection.Close();
        }

        private void txtQuan_TextChanged(object sender, EventArgs e)
        {
            txtQuan.Text = check_quan(txtQuan.Text);
        }
        private string check_quan(string quan)
        {
            if (quan.Trim().Length == 0) return "";
            try
            {
                int.Parse(quan);
                return quan;
            }
            catch
            {
                MessageBox.Show("Quantity must be a number");
                return "";
            }
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

         }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
        if (MessageBox.Show(this, "Do you want delete ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
                var rows = customer_list.SelectedRows;
                if (rows.Count <= 0) return;
                
                var c_id = rows[0].Cells["cus_id_col"].Value;
                var id = int.Parse(c_id.ToString());
            connection.Open();
                string delete1 = "delete from personal_information where c_id  = @c_id";

                string delete = "delete from customer where id  = @id";
            SqlCommand cmd1 = new SqlCommand(delete1, connection);
            SqlCommand cmd = new SqlCommand(delete, connection);
            cmd1.Parameters.Add("@c_id", SqlDbType.Int);
            cmd1.Parameters["@c_id"].Value = id;
            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = id;
                cmd1.ExecuteNonQuery();
                cmd.ExecuteNonQuery();
            connection.Close();
            FillData();

        }
        }
    }
}

