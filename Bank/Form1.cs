using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Bank
{
    public partial class Form1 : Form
    {
        DataAccsess data = new DataAccsess();

        public Form1()
        {
            InitializeComponent();

            dgv_Customers.DataSource = data.GetAllCustomers();
            Settings();

        }

        void Settings()
        {
            dgv_Customers.TopLeftHeaderCell.Value = "#";
            dgv_Customers.Columns["Id"].Visible = false;
            dgv_Customers.Columns["PostNumber"].Visible = false;
            dgv_Customers.Columns["Phone"].Visible = false;
            dgv_Customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_Customers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Задаполняем детали заемщица
            try
            {
                txtBox_DebitorID.Text = dgv_Customers.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtBox_Name.Text = dgv_Customers.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtBox_PostNumber.Text = dgv_Customers.Rows[e.RowIndex].Cells["PostNumber"].Value.ToString();

                string phone = dgv_Customers.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                txtBox_Phone.Text = (phone == String.Empty) ? "Нет данных" : phone;
            }
            catch
            {

            }

            dgv_Credits.DataSource = data.GetCustomerCredits(dgv_Customers.CurrentRow.Cells["Id"].Value.ToString());
        }

        private void dgv_Payments_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgv_Customers.CellEnter += new DataGridViewCellEventHandler(dgv_Customers_CellEnter);
            dgv_Credits.CellEnter += new DataGridViewCellEventHandler(dgv_Credits_CellEnter);
        }

        private void dgv_Credits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string customerId = dgv_Customers.CurrentRow.Cells["Id"].Value.ToString();
            dgv_Payments.DataSource = data.GetPaymentsData(customerId);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Действительно закрыть?", "Bank Manager", MessageBoxButtons.OKCancel) == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newCustomer newCustomerForm = new newCustomer(data.GetNextCustomerID());
            if( newCustomerForm.ShowDialog() == DialogResult.OK)
            {
                dgv_Customers.DataSource = data.GetAllCustomers();
            }
        }
    }
}
