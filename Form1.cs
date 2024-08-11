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
    public partial class Form1 : Form
    {
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            connection = new SqlConnection("Server=DESKTOP-AGPGF6N\\SQLEXPRESS;Database=product_management;Integrated Security=true;");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string username = txtEmail.Text;
            string password = txtPass.Text;
            string query = "select * from account where username = @username and u_password =@password";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Logged in successfully");
                this.Hide();
                Main_form f2 = new Main_form();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Account or password is incorrect");
            }
            connection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit??", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Dispose();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
