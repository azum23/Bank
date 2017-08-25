namespace Bank
{
    partial class Form1
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.Customers = new System.Windows.Forms.GroupBox();
            this.dgv_Customers = new System.Windows.Forms.DataGridView();
            this.CustomerDetails = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Phone = new System.Windows.Forms.TextBox();
            this.txtBox_PostNumber = new System.Windows.Forms.TextBox();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_DebitorID = new System.Windows.Forms.TextBox();
            this.Credits = new System.Windows.Forms.GroupBox();
            this.dgv_Credits = new System.Windows.Forms.DataGridView();
            this.Payments = new System.Windows.Forms.GroupBox();
            this.dgv_Payments = new System.Windows.Forms.DataGridView();
            this.grb_Search = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Customers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).BeginInit();
            this.CustomerDetails.SuspendLayout();
            this.Credits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credits)).BeginInit();
            this.Payments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payments)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Customers
            // 
            this.Customers.Controls.Add(this.dgv_Customers);
            this.Customers.Location = new System.Drawing.Point(9, 124);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(347, 148);
            this.Customers.TabIndex = 0;
            this.Customers.TabStop = false;
            this.Customers.Text = "Customers";
            // 
            // dgv_Customers
            // 
            this.dgv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Customers.Location = new System.Drawing.Point(3, 16);
            this.dgv_Customers.MultiSelect = false;
            this.dgv_Customers.Name = "dgv_Customers";
            this.dgv_Customers.Size = new System.Drawing.Size(341, 129);
            this.dgv_Customers.TabIndex = 0;
            // 
            // CustomerDetails
            // 
            this.CustomerDetails.Controls.Add(this.label4);
            this.CustomerDetails.Controls.Add(this.label3);
            this.CustomerDetails.Controls.Add(this.label2);
            this.CustomerDetails.Controls.Add(this.label1);
            this.CustomerDetails.Controls.Add(this.txtBox_Phone);
            this.CustomerDetails.Controls.Add(this.txtBox_PostNumber);
            this.CustomerDetails.Controls.Add(this.txtBox_Name);
            this.CustomerDetails.Controls.Add(this.txtBox_DebitorID);
            this.CustomerDetails.Location = new System.Drawing.Point(365, 124);
            this.CustomerDetails.Name = "CustomerDetails";
            this.CustomerDetails.Size = new System.Drawing.Size(322, 148);
            this.CustomerDetails.TabIndex = 1;
            this.CustomerDetails.TabStop = false;
            this.CustomerDetails.Text = "Customer Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Post";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // txtBox_Phone
            // 
            this.txtBox_Phone.Location = new System.Drawing.Point(72, 112);
            this.txtBox_Phone.Name = "txtBox_Phone";
            this.txtBox_Phone.ReadOnly = true;
            this.txtBox_Phone.Size = new System.Drawing.Size(244, 20);
            this.txtBox_Phone.TabIndex = 0;
            // 
            // txtBox_PostNumber
            // 
            this.txtBox_PostNumber.Location = new System.Drawing.Point(72, 86);
            this.txtBox_PostNumber.Name = "txtBox_PostNumber";
            this.txtBox_PostNumber.ReadOnly = true;
            this.txtBox_PostNumber.Size = new System.Drawing.Size(244, 20);
            this.txtBox_PostNumber.TabIndex = 0;
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(72, 60);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.ReadOnly = true;
            this.txtBox_Name.Size = new System.Drawing.Size(244, 20);
            this.txtBox_Name.TabIndex = 0;
            // 
            // txtBox_DebitorID
            // 
            this.txtBox_DebitorID.Location = new System.Drawing.Point(72, 34);
            this.txtBox_DebitorID.Name = "txtBox_DebitorID";
            this.txtBox_DebitorID.ReadOnly = true;
            this.txtBox_DebitorID.Size = new System.Drawing.Size(244, 20);
            this.txtBox_DebitorID.TabIndex = 0;
            // 
            // Credits
            // 
            this.Credits.Controls.Add(this.dgv_Credits);
            this.Credits.Location = new System.Drawing.Point(9, 278);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(678, 137);
            this.Credits.TabIndex = 1;
            this.Credits.TabStop = false;
            this.Credits.Text = "Credits";
            // 
            // dgv_Credits
            // 
            this.dgv_Credits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Credits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Credits.Location = new System.Drawing.Point(3, 16);
            this.dgv_Credits.Name = "dgv_Credits";
            this.dgv_Credits.Size = new System.Drawing.Size(672, 118);
            this.dgv_Credits.TabIndex = 0;
            // 
            // Payments
            // 
            this.Payments.Controls.Add(this.dgv_Payments);
            this.Payments.Location = new System.Drawing.Point(12, 421);
            this.Payments.Name = "Payments";
            this.Payments.Size = new System.Drawing.Size(675, 144);
            this.Payments.TabIndex = 1;
            this.Payments.TabStop = false;
            this.Payments.Text = "Payments";
            // 
            // dgv_Payments
            // 
            this.dgv_Payments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Payments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Payments.Location = new System.Drawing.Point(3, 16);
            this.dgv_Payments.Name = "dgv_Payments";
            this.dgv_Payments.Size = new System.Drawing.Size(669, 125);
            this.dgv_Payments.TabIndex = 0;
            // 
            // grb_Search
            // 
            this.grb_Search.Location = new System.Drawing.Point(9, 27);
            this.grb_Search.Name = "grb_Search";
            this.grb_Search.Size = new System.Drawing.Size(678, 91);
            this.grb_Search.TabIndex = 2;
            this.grb_Search.TabStop = false;
            this.grb_Search.Text = "Search";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.creditsToolStripMenuItem,
            this.paymentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataToCSVToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveDataToCSVToolStripMenuItem
            // 
            this.saveDataToCSVToolStripMenuItem.Name = "saveDataToCSVToolStripMenuItem";
            this.saveDataToCSVToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.saveDataToCSVToolStripMenuItem.Text = "Save Data To CSV";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCreditToolStripMenuItem});
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // openCreditToolStripMenuItem
            // 
            this.openCreditToolStripMenuItem.Name = "openCreditToolStripMenuItem";
            this.openCreditToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openCreditToolStripMenuItem.Text = "Open Credit";
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPaymentToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // addNewPaymentToolStripMenuItem
            // 
            this.addNewPaymentToolStripMenuItem.Name = "addNewPaymentToolStripMenuItem";
            this.addNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addNewPaymentToolStripMenuItem.Text = "Add New Payment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 577);
            this.Controls.Add(this.grb_Search);
            this.Controls.Add(this.Payments);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.CustomerDetails);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bank";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Customers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customers)).EndInit();
            this.CustomerDetails.ResumeLayout(false);
            this.CustomerDetails.PerformLayout();
            this.Credits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credits)).EndInit();
            this.Payments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Payments)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox Customers;
        private System.Windows.Forms.DataGridView dgv_Customers;
        private System.Windows.Forms.GroupBox CustomerDetails;
        private System.Windows.Forms.TextBox txtBox_Phone;
        private System.Windows.Forms.TextBox txtBox_PostNumber;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_DebitorID;
        private System.Windows.Forms.GroupBox Credits;
        private System.Windows.Forms.DataGridView dgv_Credits;
        private System.Windows.Forms.GroupBox Payments;
        private System.Windows.Forms.DataGridView dgv_Payments;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_Search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPaymentToolStripMenuItem;
    }
}

