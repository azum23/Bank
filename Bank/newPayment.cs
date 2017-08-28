using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Bank
{
    public partial class newPayment : Form
    {
        ArrayList customers;
        ArrayList credits;
        DataAccsess data = new DataAccsess();

        public newPayment()
        {
            InitializeComponent();

            customers = data.GetAllCustomers();
            lbox_Id.DataSource = customers;
            lbox_Name.DataSource = customers;

            if (customers == null || customers.Count == 0)
            {
                txtBox_Amount.Enabled = false;
                btn_SaveNewPayment.Enabled = false;
            }
            else
            {
                txtBox_Amount.Enabled = true;
                btn_SaveNewPayment.Enabled = true;
            }

        }

        private void lbox_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            credits = data.GetCustomerCredits(lbox_Id.SelectedValue.ToString());

            if (credits == null || credits.Count == 0)
            {
                txtBox_Amount.Enabled = false;
                btn_SaveNewPayment.Enabled = false;
            }
            else
            {
                txtBox_Amount.Enabled = true;
                btn_SaveNewPayment.Enabled = true;
            }

            lbox_CreditId.DataSource = credits;
            lbox_CreditId.ValueMember = "Id";
            lbox_CreditId.DisplayMember = "Id";

            lbox_CreditAmount.DataSource = credits;
            lbox_CreditAmount.ValueMember = "Id";
            lbox_CreditAmount.DisplayMember = "Amount";

            lbox_CreditBalnace.DataSource = credits;
            lbox_CreditBalnace.ValueMember = "Balance";
            lbox_CreditBalnace.DisplayMember = "Balance";


        }

        private void lbox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_SaveNewPayment_Click(object sender, EventArgs e)
        {
            int creditId = (int)lbox_CreditId.SelectedValue;
            DateTime date = datetime_Open.Value;
            decimal payAmmount = Convert.ToDecimal(txtBox_Amount.Text);
            if (data.SaveNewPayment(creditId, payAmmount, date))
            {
                MessageBox.Show($"Новый платеж {payAmmount} по кредиту {lbox_CreditId.SelectedValue} проведен", "Платеж", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show($"Платеж не проведен", "Платеж", MessageBoxButtons.OK);

        }

        private void txtBox_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                if (txtBox_Amount.Text.Trim().Contains(',') ||
                    txtBox_Amount.Text == String.Empty)
                {
                    e.Handled = true;
                    return;
                }
                else
                {
                    e.Handled = false;
                    return;
                }

            short res;
            if (short.TryParse(e.KeyChar.ToString(), out res))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBox_Amount_Leave(object sender, EventArgs e)
        {
            if (txtBox_Amount.Text.Trim() == string.Empty)
            {
                lbl_Amount.Text = "Сумма платежа не введена";
                lbl_Amount.ForeColor = Color.Red;
                btn_SaveNewPayment.Enabled = false;
            }

            decimal payAmount;
            decimal.TryParse(txtBox_Amount.Text.Trim(), out payAmount);
            
            if (payAmount < 100 ||
                payAmount > decimal.Parse(lbox_CreditBalnace.SelectedValue.ToString()))
            {
                lbl_Amount.Text = "Платеж не может быть проведен";
                lbl_Amount.ForeColor = Color.Red;
                btn_SaveNewPayment.Enabled = false;
            }
            else
            {
                lbl_Amount.Text = "Платеж одобрен";
                lbl_Amount.ForeColor = Color.Green;
                btn_SaveNewPayment.Enabled = true;
            }

        }
    }
}
