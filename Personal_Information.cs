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
    public partial class Personal_Information : Form
    {
        SqlConnection connection;
        public Personal_Information()
        {
            InitializeComponent();
            CenterToScreen();
            connection = new SqlConnection("server=DESKTOP-AGPGF6N\\SQLEXPRESS;Database=product_management;Integrated Security = true");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_form main = new Main_form();
            main.Show();
            this.Dispose();
        }
        private void filltable()
        {
            string query = 
                "with temp as (" +
                "select " +
                "c.id as id, " +
                "pi.quantity * p.price as total " +
                "from personal_information pi " +
                "join product p on p.product_id = pi.p_id " +
                "join customer c on c.id = pi.c_id) " +
                "select id, sum(total) as spent " +
                "from temp " +
                "group by (id) " +
                "order by spent desc;";
            DataTable tbl = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(query, connection);
            ad.Fill(tbl);
            dataGridView1.DataSource = tbl;

            string query1 = 
                "with temp as (" +
                "select top(500) " +
                "pi.p_id, sum(pi.quantity) as quantity " +
                "from product p " +
                "join personal_information pi on pi.p_id = p.product_id " +
                "group by (pi.p_id) order by sum(pi.quantity) desc) " +
                "select t.quantity as quantity, " +
                "p.product_name as name " +
                "from temp t " +
                "join product p on p.product_id = t.p_id;";
            DataTable tbl1 = new DataTable();
            SqlDataAdapter ad1 = new SqlDataAdapter(query1, connection);
            ad1.Fill(tbl1);
            dataGridView2.DataSource = tbl1;
            connection.Close();
        }

        private void Personal_Information_Load(object sender, EventArgs e)
        {
            connection.Open();
            filltable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
