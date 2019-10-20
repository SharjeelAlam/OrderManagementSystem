namespace PresentationLayer
{
    partial class AddCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_Heading = new System.Windows.Forms.Label();
            this.label_CustomerID = new System.Windows.Forms.Label();
            this.textBox_CustomerID = new System.Windows.Forms.TextBox();
            this.label_CustomerName = new System.Windows.Forms.Label();
            this.textBox_CompanyName = new System.Windows.Forms.TextBox();
            this.label_ContactName = new System.Windows.Forms.Label();
            this.textBox_ContactName = new System.Windows.Forms.TextBox();
            this.label_ContactTitle = new System.Windows.Forms.Label();
            this.textBox_ContactTitle = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.label_City = new System.Windows.Forms.Label();
            this.textBox_City = new System.Windows.Forms.TextBox();
            this.label_Region = new System.Windows.Forms.Label();
            this.textBox_Region = new System.Windows.Forms.TextBox();
            this.label_PostalCode = new System.Windows.Forms.Label();
            this.textBox_PostalCode = new System.Windows.Forms.TextBox();
            this.label_Country = new System.Windows.Forms.Label();
            this.textBox_Country = new System.Windows.Forms.TextBox();
            this.label_Phone = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label_Fax = new System.Windows.Forms.Label();
            this.textBox_Fax = new System.Windows.Forms.TextBox();
            this.button_SaveCustomer = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1168, 56);
            this.panel1.TabIndex = 5;
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
            this.button_Exit.Location = new System.Drawing.Point(1108, 0);
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
            // label_CustomerID
            // 
            this.label_CustomerID.AutoSize = true;
            this.label_CustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerID.ForeColor = System.Drawing.Color.DarkRed;
            this.label_CustomerID.Location = new System.Drawing.Point(412, 182);
            this.label_CustomerID.Name = "label_CustomerID";
            this.label_CustomerID.Size = new System.Drawing.Size(86, 15);
            this.label_CustomerID.TabIndex = 7;
            this.label_CustomerID.Text = "Customer ID";
            // 
            // textBox_CustomerID
            // 
            this.textBox_CustomerID.Location = new System.Drawing.Point(504, 180);
            this.textBox_CustomerID.Name = "textBox_CustomerID";
            this.textBox_CustomerID.Size = new System.Drawing.Size(274, 20);
            this.textBox_CustomerID.TabIndex = 6;
            // 
            // label_CustomerName
            // 
            this.label_CustomerName.AutoSize = true;
            this.label_CustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CustomerName.ForeColor = System.Drawing.Color.DarkRed;
            this.label_CustomerName.Location = new System.Drawing.Point(390, 219);
            this.label_CustomerName.Name = "label_CustomerName";
            this.label_CustomerName.Size = new System.Drawing.Size(108, 15);
            this.label_CustomerName.TabIndex = 9;
            this.label_CustomerName.Text = "Company Name";
            this.label_CustomerName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_CompanyName
            // 
            this.textBox_CompanyName.Location = new System.Drawing.Point(504, 218);
            this.textBox_CompanyName.Name = "textBox_CompanyName";
            this.textBox_CompanyName.Size = new System.Drawing.Size(274, 20);
            this.textBox_CompanyName.TabIndex = 8;
            // 
            // label_ContactName
            // 
            this.label_ContactName.AutoSize = true;
            this.label_ContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ContactName.ForeColor = System.Drawing.Color.DarkRed;
            this.label_ContactName.Location = new System.Drawing.Point(401, 258);
            this.label_ContactName.Name = "label_ContactName";
            this.label_ContactName.Size = new System.Drawing.Size(97, 15);
            this.label_ContactName.TabIndex = 11;
            this.label_ContactName.Text = "Contact Name";
            // 
            // textBox_ContactName
            // 
            this.textBox_ContactName.Location = new System.Drawing.Point(504, 256);
            this.textBox_ContactName.Name = "textBox_ContactName";
            this.textBox_ContactName.Size = new System.Drawing.Size(274, 20);
            this.textBox_ContactName.TabIndex = 10;
            // 
            // label_ContactTitle
            // 
            this.label_ContactTitle.AutoSize = true;
            this.label_ContactTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ContactTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.label_ContactTitle.Location = new System.Drawing.Point(411, 296);
            this.label_ContactTitle.Name = "label_ContactTitle";
            this.label_ContactTitle.Size = new System.Drawing.Size(87, 15);
            this.label_ContactTitle.TabIndex = 13;
            this.label_ContactTitle.Text = "Contact Title";
            // 
            // textBox_ContactTitle
            // 
            this.textBox_ContactTitle.Location = new System.Drawing.Point(504, 294);
            this.textBox_ContactTitle.Name = "textBox_ContactTitle";
            this.textBox_ContactTitle.Size = new System.Drawing.Size(274, 20);
            this.textBox_ContactTitle.TabIndex = 12;
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Address.Location = new System.Drawing.Point(440, 336);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(58, 15);
            this.label_Address.TabIndex = 15;
            this.label_Address.Text = "Address";
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(504, 334);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(274, 20);
            this.textBox_Address.TabIndex = 14;
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_City.ForeColor = System.Drawing.Color.DarkRed;
            this.label_City.Location = new System.Drawing.Point(468, 373);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(30, 15);
            this.label_City.TabIndex = 17;
            this.label_City.Text = "City";
            // 
            // textBox_City
            // 
            this.textBox_City.Location = new System.Drawing.Point(504, 371);
            this.textBox_City.Name = "textBox_City";
            this.textBox_City.Size = new System.Drawing.Size(274, 20);
            this.textBox_City.TabIndex = 16;
            // 
            // label_Region
            // 
            this.label_Region.AutoSize = true;
            this.label_Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Region.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Region.Location = new System.Drawing.Point(445, 410);
            this.label_Region.Name = "label_Region";
            this.label_Region.Size = new System.Drawing.Size(53, 15);
            this.label_Region.TabIndex = 19;
            this.label_Region.Text = "Region";
            // 
            // textBox_Region
            // 
            this.textBox_Region.Location = new System.Drawing.Point(504, 408);
            this.textBox_Region.Name = "textBox_Region";
            this.textBox_Region.Size = new System.Drawing.Size(274, 20);
            this.textBox_Region.TabIndex = 18;
            // 
            // label_PostalCode
            // 
            this.label_PostalCode.AutoSize = true;
            this.label_PostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PostalCode.ForeColor = System.Drawing.Color.DarkRed;
            this.label_PostalCode.Location = new System.Drawing.Point(414, 445);
            this.label_PostalCode.Name = "label_PostalCode";
            this.label_PostalCode.Size = new System.Drawing.Size(84, 15);
            this.label_PostalCode.TabIndex = 21;
            this.label_PostalCode.Text = "Postal Code";
            // 
            // textBox_PostalCode
            // 
            this.textBox_PostalCode.Location = new System.Drawing.Point(504, 443);
            this.textBox_PostalCode.Name = "textBox_PostalCode";
            this.textBox_PostalCode.Size = new System.Drawing.Size(274, 20);
            this.textBox_PostalCode.TabIndex = 20;
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Country.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Country.Location = new System.Drawing.Point(443, 478);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(55, 15);
            this.label_Country.TabIndex = 23;
            this.label_Country.Text = "Country";
            // 
            // textBox_Country
            // 
            this.textBox_Country.Location = new System.Drawing.Point(504, 476);
            this.textBox_Country.Name = "textBox_Country";
            this.textBox_Country.Size = new System.Drawing.Size(274, 20);
            this.textBox_Country.TabIndex = 22;
            // 
            // label_Phone
            // 
            this.label_Phone.AutoSize = true;
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Phone.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Phone.Location = new System.Drawing.Point(450, 517);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(48, 15);
            this.label_Phone.TabIndex = 25;
            this.label_Phone.Text = "Phone";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(504, 515);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(274, 20);
            this.textBox_Phone.TabIndex = 24;
            // 
            // label_Fax
            // 
            this.label_Fax.AutoSize = true;
            this.label_Fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fax.ForeColor = System.Drawing.Color.DarkRed;
            this.label_Fax.Location = new System.Drawing.Point(468, 560);
            this.label_Fax.Name = "label_Fax";
            this.label_Fax.Size = new System.Drawing.Size(30, 15);
            this.label_Fax.TabIndex = 27;
            this.label_Fax.Text = "Fax";
            // 
            // textBox_Fax
            // 
            this.textBox_Fax.Location = new System.Drawing.Point(504, 558);
            this.textBox_Fax.Name = "textBox_Fax";
            this.textBox_Fax.Size = new System.Drawing.Size(274, 20);
            this.textBox_Fax.TabIndex = 26;
            // 
            // button_SaveCustomer
            // 
            this.button_SaveCustomer.AutoSize = true;
            this.button_SaveCustomer.BackColor = System.Drawing.Color.DarkRed;
            this.button_SaveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_SaveCustomer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveCustomer.ForeColor = System.Drawing.Color.White;
            this.button_SaveCustomer.Location = new System.Drawing.Point(504, 594);
            this.button_SaveCustomer.Name = "button_SaveCustomer";
            this.button_SaveCustomer.Size = new System.Drawing.Size(134, 33);
            this.button_SaveCustomer.TabIndex = 28;
            this.button_SaveCustomer.Text = "Save Customer";
            this.button_SaveCustomer.UseVisualStyleBackColor = false;
            this.button_SaveCustomer.Click += new System.EventHandler(this.button_SaveCustomer_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.AutoSize = true;
            this.button_Cancel.BackColor = System.Drawing.Color.DarkRed;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cancel.ForeColor = System.Drawing.Color.White;
            this.button_Cancel.Location = new System.Drawing.Point(644, 594);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(134, 33);
            this.button_Cancel.TabIndex = 29;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(500, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Enter Customer Information";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_SaveCustomer);
            this.Controls.Add(this.label_Fax);
            this.Controls.Add(this.textBox_Fax);
            this.Controls.Add(this.label_Phone);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.textBox_Country);
            this.Controls.Add(this.label_PostalCode);
            this.Controls.Add(this.textBox_PostalCode);
            this.Controls.Add(this.label_Region);
            this.Controls.Add(this.textBox_Region);
            this.Controls.Add(this.label_City);
            this.Controls.Add(this.textBox_City);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.label_ContactTitle);
            this.Controls.Add(this.textBox_ContactTitle);
            this.Controls.Add(this.label_ContactName);
            this.Controls.Add(this.textBox_ContactName);
            this.Controls.Add(this.label_CustomerName);
            this.Controls.Add(this.textBox_CompanyName);
            this.Controls.Add(this.label_CustomerID);
            this.Controls.Add(this.textBox_CustomerID);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_Heading;
        private System.Windows.Forms.Label label_CustomerID;
        private System.Windows.Forms.TextBox textBox_CustomerID;
        private System.Windows.Forms.Label label_CustomerName;
        private System.Windows.Forms.TextBox textBox_CompanyName;
        private System.Windows.Forms.Label label_ContactName;
        private System.Windows.Forms.TextBox textBox_ContactName;
        private System.Windows.Forms.Label label_ContactTitle;
        private System.Windows.Forms.TextBox textBox_ContactTitle;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.Label label_City;
        private System.Windows.Forms.TextBox textBox_City;
        private System.Windows.Forms.Label label_Region;
        private System.Windows.Forms.TextBox textBox_Region;
        private System.Windows.Forms.Label label_PostalCode;
        private System.Windows.Forms.TextBox textBox_PostalCode;
        private System.Windows.Forms.Label label_Country;
        private System.Windows.Forms.TextBox textBox_Country;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label_Fax;
        private System.Windows.Forms.TextBox textBox_Fax;
        private System.Windows.Forms.Button button_SaveCustomer;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
    }
}