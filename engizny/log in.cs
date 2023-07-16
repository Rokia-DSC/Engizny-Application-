using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace engizny
{
    public partial class login : Form
    {
        public string user_id;
        public login()
        {
           
            InitializeComponent();
            
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            sign_in s_in = new sign_in();   
            s_in.Show();
            this.Hide();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Focus();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
        var x = this.tbl_UserTableAdapter.check_user_and_password(textBox1.Text, textBox2.Text);
            if(x.First().User_Id ==textBox1.Text
                             && x.First().Password == textBox2.Text )
            {
                Customer_servise cu = new Customer_servise();
                user_id = x.First().User_Id;
                cu.Show();
                this.Hide();   
            }
        }
        private void tbl_UserBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;

            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
