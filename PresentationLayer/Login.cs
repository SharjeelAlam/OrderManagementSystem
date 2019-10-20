using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            Homepage HomeFormObj = new Homepage();
            ClsBLL clSBLLObj = new ClsBLL();
            if (clSBLLObj.Login(textBox_Username.Text, textBox_Password.Text))
            {
                MessageBox.Show("Login Successful");
                HomeFormObj.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Unsuccessful. Either the username or the password is incorrect");
            }

        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
