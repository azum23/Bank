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

            ArrayList customers = data.GetAllCustomers();
            dgv_Customers.DataSource = customers;
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
    }
}
