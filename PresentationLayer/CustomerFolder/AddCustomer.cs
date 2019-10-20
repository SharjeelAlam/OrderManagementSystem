using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessEntities;

namespace PresentationLayer
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click_1(object sender, EventArgs e)
        {
            //CustomerForm customerFormObj = new CustomerForm();
            //customerFormObj.ShowDialog();
            this.Dispose();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_SaveCustomer_Click(object sender, EventArgs e)
        {
            ClsBLL clsBllObj = new ClsBLL();
            Customer customerObj = new Customer();
            customerObj.CustomerID1 = textBox_CustomerID.Text.Trim();
            customerObj.CompanyName1 = textBox_CompanyName.Text.Trim();
            customerObj.ContactName1 = textBox_ContactName.Text.Trim();
            customerObj.ContactTitle1 = textBox_ContactTitle.Text.Trim();
            customerObj.Address1 = textBox_Address.Text.Trim();
            customerObj.City1 = textBox_City.Text.Trim();
            customerObj.Country1 = textBox_Country.Text.Trim();
            customerObj.Fax1 = textBox_Fax.Text.Trim();
            customerObj.Phone1 = textBox_Phone.Text.Trim();
            customerObj.PostalCode1 = textBox_PostalCode.Text.Trim();
            customerObj.Region1 = textBox_Region.Text.Trim();
            try
            {
                int rowsAffected = clsBllObj.CreateCustomer(customerObj);
                if(rowsAffected == 1)
                {
                    MessageBox.Show("Customer created successfully");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
