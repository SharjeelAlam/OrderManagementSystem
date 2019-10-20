using System;

namespace PresentationLayer
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.textBox_CustomerID = new System.Windows.Forms.TextBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.label_CustomerID = new System.Windows.Forms.Label();
            this.dataGrid_CustomerDetails = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Heading = new System.Windows.Forms.Label();
            this.button_ViewAllCustomers = new System.Windows.Forms.Button();
            this.button_AddNewCustomer = new System.Windows.Forms.Button();
            this.button_EditCustomer = new System.Windows.Forms.Button();
            this.button_DeleteCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_CustomerDetails)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_CustomerID
            // 
            this.textBox_CustomerID.Location = new System.Drawing.Point(828, 180);
            this.textBox_CustomerID.Name = "textBox_CustomerID";
            this.textBox_CustomerID.Size = new System.Drawing.Size(165, 20);
            this.textBox_CustomerID.TabIndex = 0;
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.IndianRed;
            this.button_Search.Enabled = false;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.Location = new System.Drawing.Point(999, 179);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 20);
            this.button_Search.TabIndex = 1;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.EnabledChanged += new System.EventHandler(this.button_Search_EnabledChanged);
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // label_CustomerID
            // 
            this.label_CustomerID.AutoSize = true;
            this.label_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerID.ForeColor = System.Drawing.Color.DarkRed;
            this.label_CustomerID.Location = new System.Drawing.Point(736, 181);
            this.label_CustomerID.Name = "label_CustomerID";
            this.label_CustomerID.Size = new System.Drawing.Size(86, 15);
            this.label_CustomerID.TabIndex = 2;
            this.label_CustomerID.Text = "Customer ID";
            this.label_CustomerID.Click += new System.EventHandler(this.label_CustomerID_Click);
            // 
            // dataGrid_CustomerDetails
            // 
            this.dataGrid_CustomerDetails.AllowUserToAddRows = false;
            this.dataGrid_CustomerDetails.AllowUserToDeleteRows = false;
            this.dataGrid_CustomerDetails.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_CustomerDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_CustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_CustomerDetails.Location = new System.Drawing.Point(224, 205);
            this.dataGrid_CustomerDetails.Name = "dataGrid_CustomerDetails";
            this.dataGrid_CustomerDetails.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_CustomerDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_CustomerDetails.RowTemplate.ReadOnly = true;
            this.dataGrid_CustomerDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_CustomerDetails.Size = new System.Drawing.Size(850, 350);
            this.dataGrid_CustomerDetails.TabIndex = 3;
            this.dataGrid_CustomerDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CustomerDetails_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.button_Exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label_Heading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 56);
            this.panel1.TabIndex = 4;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.DarkRed;
            this.button_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Exit.BackgroundImage")));
            this.button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.ForeColor = System.Drawing.Color.White;
            this.button_Exit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_Exit.Location = new System.Drawing.Point(1124, 0);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(60, 56);
            this.button_Exit.TabIndex = 12;
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_Heading
            // 
            this.label_Heading.AutoSize = true;
            this.label_Heading.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Heading.ForeColor = System.Drawing.Color.White;
            this.label_Heading.Location = new System.Drawing.Point(69, 13);
            this.label_Heading.Name = "label_Heading";
            this.label_Heading.Size = new System.Drawing.Size(284, 26);
            this.label_Heading.TabIndex = 0;
            this.label_Heading.Text = "Customer Management System";
            // 
            // button_ViewAllCustomers
            // 
            this.button_ViewAllCustomers.AutoSize = true;
            this.button_ViewAllCustomers.BackColor = System.Drawing.Color.DarkRed;
            this.button_ViewAllCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ViewAllCustomers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ViewAllCustomers.ForeColor = System.Drawing.Color.White;
            this.button_ViewAllCustomers.Location = new System.Drawing.Point(50, 205);
            this.button_ViewAllCustomers.Name = "button_ViewAllCustomers";
            this.button_ViewAllCustomers.Size = new System.Drawing.Size(168, 33);
            this.button_ViewAllCustomers.TabIndex = 5;
            this.button_ViewAllCustomers.Text = "View All Customers";
            this.button_ViewAllCustomers.UseVisualStyleBackColor = false;
            this.button_ViewAllCustomers.Click += new System.EventHandler(this.button_ViewAllCustomers_Click);
            // 
            // button_AddNewCustomer
            // 
            this.button_AddNewCustomer.AutoSize = true;
            this.button_AddNewCustomer.BackColor = System.Drawing.Color.DarkRed;
            this.button_AddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_AddNewCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.button_AddNewCustomer.Location = new System.Drawing.Point(50, 253);
            this.button_AddNewCustomer.Name = "button_AddNewCustomer";
            this.button_AddNewCustomer.Size = new System.Drawing.Size(168, 33);
            this.button_AddNewCustomer.TabIndex = 6;
            this.button_AddNewCustomer.Text = "Add New Customer";
            this.button_AddNewCustomer.UseVisualStyleBackColor = false;
            this.button_AddNewCustomer.Click += new System.EventHandler(this.button_AddNewCustomer_Click);
            // 
            // button_EditCustomer
            // 
            this.button_EditCustomer.AutoSize = true;
            this.button_EditCustomer.BackColor = System.Drawing.Color.DarkRed;
            this.button_EditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_EditCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EditCustomer.ForeColor = System.Drawing.Color.White;
            this.button_EditCustomer.Location = new System.Drawing.Point(50, 301);
            this.button_EditCustomer.Name = "button_EditCustomer";
            this.button_EditCustomer.Size = new System.Drawing.Size(168, 33);
            this.button_EditCustomer.TabIndex = 7;
            this.button_EditCustomer.Text = "Edit Customer";
            this.button_EditCustomer.UseVisualStyleBackColor = false;
            this.button_EditCustomer.Click += new System.EventHandler(this.button_EditCustomer_Click);
            // 
            // button_DeleteCustomer
            // 
            this.button_DeleteCustomer.AutoSize = true;
            this.button_DeleteCustomer.BackColor = System.Drawing.Color.DarkRed;
            this.button_DeleteCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_DeleteCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.button_DeleteCustomer.Location = new System.Drawing.Point(50, 349);
            this.button_DeleteCustomer.Name = "button_DeleteCustomer";
            this.button_DeleteCustomer.Size = new System.Drawing.Size(168, 33);
            this.button_DeleteCustomer.TabIndex = 8;
            this.button_DeleteCustomer.Text = "Delete Customer";
            this.button_DeleteCustomer.UseVisualStyleBackColor = false;
            this.button_DeleteCustomer.Click += new System.EventHandler(this.button_DeleteCustomer_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.button_DeleteCustomer);
            this.Controls.Add(this.button_EditCustomer);
            this.Controls.Add(this.button_AddNewCustomer);
            this.Controls.Add(this.button_ViewAllCustomers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGrid_CustomerDetails);
            this.Controls.Add(this.label_CustomerID);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textBox_CustomerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_CustomerDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_CustomerID;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Label label_CustomerID;
        private System.Windows.Forms.DataGridView dataGrid_CustomerDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Heading;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_ViewAllCustomers;
        private System.Windows.Forms.Button button_AddNewCustomer;
        private System.Windows.Forms.Button button_EditCustomer;
        private System.Windows.Forms.Button button_DeleteCustomer;

        //Event Handler to change colour of Search button when it gets Enabled
        private void button_Search_EnabledChanged(object sender, EventArgs e)
        {
            if (button_Search.Enabled == true)
            {
                button_Search.BackColor = System.Drawing.Color.DarkRed;
                button_Search.ForeColor = System.Drawing.Color.White;
            }
        }
    }
}