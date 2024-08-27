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

    public partial class Main_form : Form
    {
        public Main_form()
        {
            InitializeComponent();
            CenterToScreen();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            buy_product buy_Pro = new buy_product();
            buy_Pro.ShowDialog();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personal_Information personal_Information = new Personal_Information();
            personal_Information.ShowDialog();
            this.Dispose();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Product update_Product = new Update_Product();
            update_Product.ShowDialog();
            this.Dispose();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want logout ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Dispose();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewCustomer NewC = new NewCustomer();
            NewC.ShowDialog();
            this.Dispose();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Personal_Information personal_Information = new Personal_Information();
            personal_Information.ShowDialog();
            this.Dispose();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {

        }
    }
    }
