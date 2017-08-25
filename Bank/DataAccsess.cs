using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace Bank
{
    class DataAccsess
    {
        private SqlConnectionStringBuilder connectionString;

        public DataAccsess()
        {
            connectionString = new SqlConnectionStringBuilder();
            connectionString.DataSource = "DESKTOP-9F1EJ9L";
            connectionString.InitialCatalog = "Bank";
            connectionString.IntegratedSecurity = true;
        }

        public ArrayList GetAllCustomers()
        {
            ArrayList customers = new ArrayList();

            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
            {
                string cmdTxt = @"Select * from Customers";
                SqlCommand command = new SqlCommand(cmdTxt, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    foreach (DbDataRecord item in reader)
                    {
                        customers.Add(item);
                    }
                }
                else
                {
                    return null;
                }
            }

            return customers;
        }

    }
}
