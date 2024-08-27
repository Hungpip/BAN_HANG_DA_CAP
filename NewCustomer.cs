using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BAN_HANG_DA_CAP
{
    internal class NewCustomer : Form
    {

        public NewCustomer()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFullname = new System.Windows.Forms.Label();
            this.fullname = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.errorShow = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Cusomer";
            // 
            // lbFullname
            // 
            this.lbFullname.AutoSize = true;
            this.lbFullname.Location = new System.Drawing.Point(12, 75);
            this.lbFullname.Name = "lbFullname";
            this.lbFullname.Size = new System.Drawing.Size(54, 13);
            this.lbFullname.TabIndex = 1;
            this.lbFullname.Text = "Full Name";
            // 
            // fullname
            // 
            this.fullname.Location = new System.Drawing.Point(79, 72);
            this.fullname.Name = "fullname";
            this.fullname.Size = new System.Drawing.Size(450, 20);
            this.fullname.TabIndex = 2;
            this.fullname.TextChanged += textListener;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(12, 117);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(45, 13);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "Address";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(79, 114);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(450, 20);
            this.address.TabIndex = 4;
            this.address.TextChanged += textListener;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(12, 161);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(76, 13);
            this.lbPhoneNumber.TabIndex = 5;
            this.lbPhoneNumber.Text = "Phone number";
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(104, 158);
            this.phonenumber.MaxLength = 10;
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(107, 20);
            this.phonenumber.TabIndex = 6;
            this.TextChanged += textListener;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(454, 326);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 7;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.AddAction);
            // 
            // errorShow
            // 
            this.errorShow.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewCustomer
            // 
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.phonenumber);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.lbFullname);
            this.Controls.Add(this.label1);
            this.Name = "NewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.errorShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textListener(object sender, EventArgs e)
        {
            if (sender == fullname)
                checkName();
            if (sender == address)
                checkAddress();
            if (sender == phonenumber)
                checkPhoneNumber();
        }

        private void checkName()
        {
            if (fullname.Text.Length == 0)
            {
                errorShow.SetError(fullname, "Full name is required");
                return;
            }
            errorShow.SetError(fullname, "");
        }

        private void checkAddress()
        {
            if (address.Text.Length == 0)
            {
                errorShow.SetError(address, "Address is required");
                return;
            }
            errorShow.SetError(address, "");
        }


        private bool checkPhoneNumber()
        {
            string phone = phonenumber.Text;
            if (phone.Length == 0)
            {
                errorShow.SetError(phonenumber, "Phone number is required");
                return false;
            }
            if (!phone.All(char.IsDigit))
            {
                errorShow.SetError(phonenumber, "Phone number should only contain digits");
                return false;
            }
            if (phone.Length != 10)
            {
                errorShow.SetError(phonenumber, "Phone number should be 10 digits long");
                return false;
            }
            if (!phone.StartsWith("0"))
            {
                errorShow.SetError(phonenumber, "Phone number should start with 0");
                return false;
            }
            errorShow.SetError(phonenumber, "");
            return true;
        }

        private Label label1;
        private Label lbFullname;
        private TextBox fullname;
        private Label lbAddress;
        private TextBox address;
        private Label lbPhoneNumber;
        private Button add;
        private ErrorProvider errorShow;
        private System.ComponentModel.IContainer components;
        private Button button1;
        private TextBox phonenumber;

        private void AddAction(object sender, EventArgs e)
        {
            if (fullname.Text.Length != 0 && address.Text.Length != 0 && checkPhoneNumber())
            {
                errorShow.SetError(fullname, "");
                errorShow.SetError(address, "");
                errorShow.SetError(phonenumber, "");
                Add();
                return;
            }
            if (fullname.Text.Length == 0)
            {
                errorShow.SetError(fullname, "Full name is required");
            }
            if (address.Text.Length == 0)
            {
                errorShow.SetError(address, "Address is required");
            }
            if (phonenumber.Text.Length != 10)
            {
                errorShow.SetError(phonenumber, "Phone number should be 10 digits long");
            }
        }


        private void Add()
        {
            var conn =  new SqlConnection("Server=DESKTOP-AGPGF6N\\SQLEXPRESS;Database=product_management;Integrated Security=true;");
            conn.Open();
            var insert = "insert into customer(name, address, number) values (@n, @a, @p)";
            var cmd = new SqlCommand(insert, conn);
            cmd.Parameters.AddWithValue("@n", fullname.Text);
            cmd.Parameters.AddWithValue("@a", address.Text);
            cmd.Parameters.AddWithValue("@p", phonenumber.Text);
            try
            {
                var a = 0;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dispose();
                new Main_form().ShowDialog();
            }
            catch
            {
                MessageBox.Show("Failed to add customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_form main = new Main_form();
            main.ShowDialog();
            this.Dispose();
        }
    }

}
