using System;
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
    public partial class newCustomer : Form
    {
        // TODO: избавиться от поля оставить только в главной форме
        DataAccsess data = new DataAccsess();

        public newCustomer(string id)
        {
            InitializeComponent();
            txtBox_Id.Text = id;
        }

        private void btn_SaveNewCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBox_Name.Text) || !string.IsNullOrWhiteSpace(txtBox_PostNumber.Text))
            {
                bool result = data.SaveNewCustomer(txtBox_Name.Text.Trim(), txtBox_PostNumber.Text.Trim(), txtBox_Phone.Text.Trim());

                if (result)
                {
                    // MessageBox.Show($"Добален новый клиент: {txtBox_Name.Text}", "Запись добавлена", MessageBoxButtons.OK);
                    this.DialogResult = DialogResult.OK;
                }
                // в случае ошибки подключения
                else
                {
                    MessageBox.Show($"{txtBox_Name} не добавлен! что то не так!", "Запись не добавлена", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Заполните имя и пост", "Ошибка", MessageBoxButtons.OK);
            }

        }

        private void newCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
