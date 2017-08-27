namespace Bank
{
    partial class newCredit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_Id = new System.Windows.Forms.TextBox();
            this.listBox_Name = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_Id = new System.Windows.Forms.ListBox();
            this.txtBox_Amount = new System.Windows.Forms.TextBox();
            this.txtBox_Balance = new System.Windows.Forms.TextBox();
            this.datetime_Open = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Open = new System.Windows.Forms.Button();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Credit Id";
            // 
            // txtBox_Id
            // 
            this.txtBox_Id.Location = new System.Drawing.Point(189, 24);
            this.txtBox_Id.Name = "txtBox_Id";
            this.txtBox_Id.ReadOnly = true;
            this.txtBox_Id.Size = new System.Drawing.Size(320, 20);
            this.txtBox_Id.TabIndex = 6;
            this.txtBox_Id.TabStop = false;
            // 
            // listBox_Name
            // 
            this.listBox_Name.DisplayMember = "Name";
            this.listBox_Name.FormattingEnabled = true;
            this.listBox_Name.Location = new System.Drawing.Point(276, 50);
            this.listBox_Name.Name = "listBox_Name";
            this.listBox_Name.Size = new System.Drawing.Size(233, 108);
            this.listBox_Name.TabIndex = 0;
            this.listBox_Name.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer";
            // 
            // listBox_Id
            // 
            this.listBox_Id.DisplayMember = "Id";
            this.listBox_Id.FormattingEnabled = true;
            this.listBox_Id.Location = new System.Drawing.Point(189, 50);
            this.listBox_Id.Name = "listBox_Id";
            this.listBox_Id.Size = new System.Drawing.Size(81, 108);
            this.listBox_Id.TabIndex = 1;
            this.listBox_Id.ValueMember = "Id";
            // 
            // txtBox_Amount
            // 
            this.txtBox_Amount.Location = new System.Drawing.Point(189, 164);
            this.txtBox_Amount.MaxLength = 8;
            this.txtBox_Amount.Name = "txtBox_Amount";
            this.txtBox_Amount.Size = new System.Drawing.Size(200, 20);
            this.txtBox_Amount.TabIndex = 2;
            this.txtBox_Amount.TextChanged += new System.EventHandler(this.txtBox_Amount_TextChanged);
            this.txtBox_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_Amount_KeyPress);
            this.txtBox_Amount.Leave += new System.EventHandler(this.txtBox_Amount_Leave);
            // 
            // txtBox_Balance
            // 
            this.txtBox_Balance.Location = new System.Drawing.Point(189, 190);
            this.txtBox_Balance.Name = "txtBox_Balance";
            this.txtBox_Balance.ReadOnly = true;
            this.txtBox_Balance.Size = new System.Drawing.Size(200, 20);
            this.txtBox_Balance.TabIndex = 10;
            this.txtBox_Balance.TabStop = false;
            // 
            // datetime_Open
            // 
            this.datetime_Open.Location = new System.Drawing.Point(189, 216);
            this.datetime_Open.Name = "datetime_Open";
            this.datetime_Open.Size = new System.Drawing.Size(200, 20);
            this.datetime_Open.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Open Date";
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(189, 258);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(200, 23);
            this.btn_Open.TabIndex = 12;
            this.btn_Open.Text = "Open New Credit";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(396, 170);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(35, 13);
            this.lbl_Amount.TabIndex = 13;
            this.lbl_Amount.Text = "label6";
            // 
            // newCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 293);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.btn_Open);
            this.Controls.Add(this.datetime_Open);
            this.Controls.Add(this.txtBox_Balance);
            this.Controls.Add(this.txtBox_Amount);
            this.Controls.Add(this.listBox_Id);
            this.Controls.Add(this.listBox_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox_Id);
            this.Name = "newCredit";
            this.Text = "newCredit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Id;
        private System.Windows.Forms.ListBox listBox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_Id;
        private System.Windows.Forms.TextBox txtBox_Amount;
        private System.Windows.Forms.TextBox txtBox_Balance;
        private System.Windows.Forms.DateTimePicker datetime_Open;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Label lbl_Amount;
    }
}