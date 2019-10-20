using System;
using System.Data;
using System.Windows.Forms;
using BusinessLogicLayer;
using BusinessEntities;

namespace PresentationLayer
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string customerID = textBox_CustomerID.Text;
            ClsBLL bLLObj = new ClsBLL();
            DataTable dT = new DataTable();
            if (customerID != string.Empty)
            {
                Customer customerObj = bLLObj.SearchCustomer(customerID);
                if (customerObj.CustomerID1 == null)
                {
                    MessageBox.Show("Could not find a customer with the CustomerID:\"" + customerID + "\".");
                }
                else
                {
                    dT.Columns.Add("CustomerID", typeof(string));
                    dT.Columns.Add("CompanyName", typeof(string));
                    dT.Columns.Add("ContactName", typeof(string));
                    dT.Columns.Add("ContactTitle", typeof(string));
                    dT.Columns.Add("Address", typeof(string));
                    dT.Columns.Add("City", typeof(string));
                    dT.Columns.Add("Region", typeof(string));
                    dT.Columns.Add("PostalCode", typeof(string));
                    dT.Columns.Add("Country", typeof(string));
                    dT.Columns.Add("Phone", typeof(string));
                    dT.Columns.Add("Fax", typeof(string));
                    dT.Rows.Add(customerObj.CustomerID1, customerObj.CompanyName1, customerObj.ContactName1, customerObj.ContactTitle1, customerObj.Address1, customerObj.City1, customerObj.Region1, customerObj.PostalCode1, customerObj.Country1, customerObj.Phone1, customerObj.Fax1);
                    dataGrid_CustomerDetails.DataSource = dT;
                    dataGrid_CustomerDetails.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Please enter a Customer ID");
            }
        }

        private void dataGrid_CustomerDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_CustomerID_Click(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button_ViewAllCustomers_Click(object sender, EventArgs e)
        {
            ClsBLL ClsBllObj = new ClsBLL();
            dataGrid_CustomerDetails.DataSource = ClsBllObj.ViewAllCustomers();
            this.button_Search.Enabled = true;
            //label_CustomerID.Visible = true;
            //textBox_CustomerID.Visible = true;
            //button_Search.Visible = true;
            //dataGrid_CustomerDetails.Visible = true;
        }

        private void button_DeleteCustomer_Click(object sender, EventArgs e)
        {
            //Get CustomerID value from the selected row of DataGridView
            string customerID = dataGrid_CustomerDetails.SelectedRows[0].Cells[0].Value.ToString().Trim();
            var resultMessageBox = MessageBox.Show("Are you sure you want to permanently delete the selected Customer?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if ( resultMessageBox == DialogResult.Yes)
            {
                // user clicked yes 
                ClsBLL ClsBllObj = new ClsBLL();
                ClsBllObj.DeleteCustomer(customerID);
                MessageBox.Show("Customer \"" + customerID +"\" has been deleted successfully.");
                dataGrid_CustomerDetails.DataSource = ClsBllObj.ViewAllCustomers();
            }
            else
            {
                // user clicked no
            }
        }

        private void button_AddNewCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer AddCustomerObj = new AddCustomer();
            AddCustomerObj.ShowDialog();
            this.button_ViewAllCustomers_Click(sender, e);
        }

        private void button_EditCustomer_Click(object sender, EventArgs e)
        {
            Customer customerObj = new Customer();
            customerObj.Address1 = dataGrid_CustomerDetails.SelectedRows[0].Cells["Address"].Value.ToString().Trim();
            customerObj.City1 = dataGrid_CustomerDetails.SelectedRows[0].Cells["City"].Value.ToString().Trim();
            customerObj.CompanyName1 = dataGrid_CustomerDetails.SelectedRows[0].Cells["CompanyName"].Value.ToString().Trim();
            customerObj.ContactName1 = dataGrid_CustomerDetails.SelectedRows[0].Cells["ContactName"].Value.ToString().Trim();
            customerObj.ContactTitle1 = dataGrid_CustomerDetails.SelectedRows[0].Cells["ContactTitle"].Value.ToString().Trim();
            customerObj.Country1 = dataGrid_CustomerDetails.SelectedRows[0].Cells["Country"].Value.ToString().Trim();
            customerObj.CustomerID1 = dataGrid_CustomerDetails.SelectedRows[0].Cells["CustomerID"].Value.ToString().Trim();
            customerObj.Fax1 = dataGrid_CustomerDetails.SelectedRows[0].Cells["Fax"].Value.ToString().Trim();
            customerObj.Phone1 = dataGrid_CustomerDetails.SelectedRows[0].Cells["Phone"].Value.ToString().Trim();
            customerObj.PostalCode1 = dataGrid_CustomerDetails.SelectedRows[0].Cells["PostalCode"].Value.ToString().Trim();
            customerObj.Region1 = dataGrid_CustomerDetails.SelectedRows[0].Cells["Region"].Value.ToString().Trim();
            EditCustomer editCustomerObj = new EditCustomer(customerObj);
            editCustomerObj.ShowDialog();
            this.button_ViewAllCustomers_Click(sender,e);
        }
    }
}
