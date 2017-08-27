namespace Bank
{
    partial class newPayment
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
            this.lbox_Id = new System.Windows.Forms.ListBox();
            this.lbox_Name = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbox_CreditAmount = new System.Windows.Forms.ListBox();
            this.lbox_CreditId = new System.Windows.Forms.ListBox();
            this.datetime_Open = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbox_CreditBalnace = new System.Windows.Forms.ListBox();
            this.txtBox_Amount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_SaveNewPayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbox_Id
            // 
            this.lbox_Id.DisplayMember = "Id";
            this.lbox_Id.FormattingEnabled = true;
            this.lbox_Id.Location = new System.Drawing.Point(129, 47);
            this.lbox_Id.Name = "lbox_Id";
            this.lbox_Id.Size = new System.Drawing.Size(81, 108);
            this.lbox_Id.TabIndex = 9;
            this.lbox_Id.UseWaitCursor = true;
            this.lbox_Id.ValueMember = "Id";
            // 
            // lbox_Name
            // 
            this.lbox_Name.DisplayMember = "Name";
            this.lbox_Name.FormattingEnabled = true;
            this.lbox_Name.Location = new System.Drawing.Point(216, 47);
            this.lbox_Name.Name = "lbox_Name";
            this.lbox_Name.Size = new System.Drawing.Size(233, 108);
            this.lbox_Name.TabIndex = 8;
            this.lbox_Name.UseWaitCursor = true;
            this.lbox_Name.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Credits";
            this.label1.UseWaitCursor = true;
            // 
            // lbox_CreditAmount
            // 
            this.lbox_CreditAmount.DisplayMember = "Name";
            this.lbox_CreditAmount.FormattingEnabled = true;
            this.lbox_CreditAmount.Location = new System.Drawing.Point(216, 161);
            this.lbox_CreditAmount.Name = "lbox_CreditAmount";
            this.lbox_CreditAmount.Size = new System.Drawing.Size(113, 108);
            this.lbox_CreditAmount.TabIndex = 8;
            this.lbox_CreditAmount.UseWaitCursor = true;
            this.lbox_CreditAmount.ValueMember = "Id";
            // 
            // lbox_CreditId
            // 
            this.lbox_CreditId.DisplayMember = "Id";
            this.lbox_CreditId.FormattingEnabled = true;
            this.lbox_CreditId.Location = new System.Drawing.Point(129, 161);
            this.lbox_CreditId.Name = "lbox_CreditId";
            this.lbox_CreditId.Size = new System.Drawing.Size(81, 108);
            this.lbox_CreditId.TabIndex = 9;
            this.lbox_CreditId.UseWaitCursor = true;
            this.lbox_CreditId.ValueMember = "Id";
            // 
            // datetime_Open
            // 
            this.datetime_Open.Location = new System.Drawing.Point(129, 285);
            this.datetime_Open.Name = "datetime_Open";
            this.datetime_Open.Size = new System.Drawing.Size(200, 20);
            this.datetime_Open.TabIndex = 13;
            this.datetime_Open.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pay Date";
            this.label5.UseWaitCursor = true;
            // 
            // lbox_CreditBalnace
            // 
            this.lbox_CreditBalnace.DisplayMember = "Name";
            this.lbox_CreditBalnace.FormattingEnabled = true;
            this.lbox_CreditBalnace.Location = new System.Drawing.Point(336, 161);
            this.lbox_CreditBalnace.Name = "lbox_CreditBalnace";
            this.lbox_CreditBalnace.Size = new System.Drawing.Size(113, 108);
            this.lbox_CreditBalnace.TabIndex = 8;
            this.lbox_CreditBalnace.UseWaitCursor = true;
            this.lbox_CreditBalnace.ValueMember = "Id";
            // 
            // txtBox_Amount
            // 
            this.txtBox_Amount.Location = new System.Drawing.Point(129, 311);
            this.txtBox_Amount.MaxLength = 8;
            this.txtBox_Amount.Name = "txtBox_Amount";
            this.txtBox_Amount.Size = new System.Drawing.Size(200, 20);
            this.txtBox_Amount.TabIndex = 14;
            this.txtBox_Amount.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Pay Amount";
            this.label3.UseWaitCursor = true;
            // 
            // btn_SaveNewPayment
            // 
            this.btn_SaveNewPayment.Location = new System.Drawing.Point(129, 347);
            this.btn_SaveNewPayment.Name = "btn_SaveNewPayment";
            this.btn_SaveNewPayment.Size = new System.Drawing.Size(200, 23);
            this.btn_SaveNewPayment.TabIndex = 16;
            this.btn_SaveNewPayment.Text = "Pay";
            this.btn_SaveNewPayment.UseVisualStyleBackColor = true;
            this.btn_SaveNewPayment.UseWaitCursor = true;
            // 
            // newPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 429);
            this.Controls.Add(this.btn_SaveNewPayment);
            this.Controls.Add(this.txtBox_Amount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetime_Open);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbox_CreditId);
            this.Controls.Add(this.lbox_Id);
            this.Controls.Add(this.lbox_CreditBalnace);
            this.Controls.Add(this.lbox_CreditAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbox_Name);
            this.Controls.Add(this.label2);
            this.Name = "newPayment";
            this.Text = "New Payment";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_Id;
        private System.Windows.Forms.ListBox lbox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbox_CreditAmount;
        private System.Windows.Forms.ListBox lbox_CreditId;
        private System.Windows.Forms.DateTimePicker datetime_Open;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbox_CreditBalnace;
        private System.Windows.Forms.TextBox txtBox_Amount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_SaveNewPayment;
    }
}