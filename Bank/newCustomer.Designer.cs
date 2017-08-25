namespace Bank
{
    partial class newCustomer
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
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.txtBox_PostNumber = new System.Windows.Forms.TextBox();
            this.txtBox_Phone = new System.Windows.Forms.TextBox();
            this.btn_SaveNewCustomer = new System.Windows.Forms.Button();
            this.txtBox_Id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Location = new System.Drawing.Point(170, 43);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(188, 20);
            this.txtBox_Name.TabIndex = 1;
            // 
            // txtBox_PostNumber
            // 
            this.txtBox_PostNumber.Location = new System.Drawing.Point(170, 69);
            this.txtBox_PostNumber.Name = "txtBox_PostNumber";
            this.txtBox_PostNumber.Size = new System.Drawing.Size(188, 20);
            this.txtBox_PostNumber.TabIndex = 2;
            // 
            // txtBox_Phone
            // 
            this.txtBox_Phone.Location = new System.Drawing.Point(170, 95);
            this.txtBox_Phone.Name = "txtBox_Phone";
            this.txtBox_Phone.Size = new System.Drawing.Size(188, 20);
            this.txtBox_Phone.TabIndex = 3;
            // 
            // btn_SaveNewCustomer
            // 
            this.btn_SaveNewCustomer.Location = new System.Drawing.Point(170, 121);
            this.btn_SaveNewCustomer.Name = "btn_SaveNewCustomer";
            this.btn_SaveNewCustomer.Size = new System.Drawing.Size(188, 23);
            this.btn_SaveNewCustomer.TabIndex = 4;
            this.btn_SaveNewCustomer.Text = "Save Customer";
            this.btn_SaveNewCustomer.UseVisualStyleBackColor = true;
            this.btn_SaveNewCustomer.Click += new System.EventHandler(this.btn_SaveNewCustomer_Click);
            // 
            // txtBox_Id
            // 
            this.txtBox_Id.Location = new System.Drawing.Point(170, 17);
            this.txtBox_Id.Name = "txtBox_Id";
            this.txtBox_Id.ReadOnly = true;
            this.txtBox_Id.Size = new System.Drawing.Size(188, 20);
            this.txtBox_Id.TabIndex = 0;
            this.txtBox_Id.TabStop = false;
            // 
            // newCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 157);
            this.Controls.Add(this.btn_SaveNewCustomer);
            this.Controls.Add(this.txtBox_Id);
            this.Controls.Add(this.txtBox_Phone);
            this.Controls.Add(this.txtBox_PostNumber);
            this.Controls.Add(this.txtBox_Name);
            this.Name = "newCustomer";
            this.Text = "Add Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.newCustomer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.TextBox txtBox_PostNumber;
        private System.Windows.Forms.TextBox txtBox_Phone;
        private System.Windows.Forms.Button btn_SaveNewCustomer;
        private System.Windows.Forms.TextBox txtBox_Id;
    }
}