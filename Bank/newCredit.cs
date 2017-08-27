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

namespace Bank
{
    public partial class newCredit : Form
    {
        ArrayList allCustomers;
        DataAccsess data = new DataAccsess();

        public newCredit()
        {
            InitializeComponent();
            txtBox_Id.Text = data.GetNextCreditID();
            allCustomers = data.GetAllCustomers();

            if (allCustomers == null)
            {
                txtBox_Amount.Enabled =
                    txtBox_Balance.Enabled =
                    btn_Open.Enabled = false;
            }

            listBox_Id.DataSource = allCustomers;
            listBox_Name.DataSource = allCustomers;
        }

        private void txtBox_Amount_TextChanged(object sender, EventArgs e)
        {
            txtBox_Balance.Text = txtBox_Amount.Text;
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            // TODO: стринг билдер накапливает тексты для месcедж бокса указывающего что не заполнено

            int amount = 0;
            StringBuilder inputError = new StringBuilder();
            if (string.IsNullOrWhiteSpace(txtBox_Amount.Text))
            {
                inputError.AppendLine("Не заполнена сумма");
            }
            else
            {

                int.TryParse(txtBox_Amount.Text, out amount);
            }
            int id = Convert.ToInt32(listBox_Id.SelectedValue);

            if (data.SaveNewCredit(id, amount, datetime_Open.Value))
            {
                this.DialogResult = DialogResult.OK;
                MessageBox.Show($"Добален новый кредит на сумму: {amount} для клиента {listBox_Name.Text}", "Запись добавлена", MessageBoxButtons.OK);
            }

        }

        private void txtBox_Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtBox_Amount_Leave(object sender, EventArgs e)
        {
            if (txtBox_Amount.Text == string.Empty ||
                Int32.Parse(txtBox_Amount.Text) < 100 ||
                Int32.Parse(txtBox_Amount.Text) > 10000000)
            {
                lbl_Amount.Text = "Недопустимое значение суммы кредита";
                lbl_Amount.ForeColor = Color.Red;
                btn_Open.Enabled = false;
            }
            else
            {
                lbl_Amount.Text = "Сумма одобрена";
                lbl_Amount.ForeColor = Color.Green;
                btn_Open.Enabled = true;
            }
        }
    }
}
