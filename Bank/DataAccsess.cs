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
                string cmdTxt = @"Select * from Customers Order by [Name]";
                SqlCommand command = new SqlCommand(cmdTxt, connection);

                try
                {
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
                catch
                {

                }

                return customers;
            }

        }

        public ArrayList GetCustomerCredits(string customerId)
        {
            ArrayList credits = new ArrayList();

            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
            {
                // TODO: заменить на команду с параметром
                string cmdTxt = String.Format($"Select * from Credits Where [CustomerId] = {customerId} order by [OpenDate]");
                SqlCommand command = new SqlCommand(cmdTxt, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        foreach (DbDataRecord item in reader)
                        {
                            credits.Add(item);
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                catch
                {

                }
            }
            return credits;
        }

        public ArrayList GetPaymentsData(string customerId)
        {
            ArrayList payments = new ArrayList();

            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
            {
                // TODO: заменить на команду с параметром
                string cmdTxt = String.Format($"select Payments.Id, Payments.CreditId, Payments.Amount, PayDate from Payments " +
                    $"join Credits on Payments.CreditId = Credits.Id " +
                    $"join Customers on Credits.CustomerId = Customers.Id " +
                    $"where CustomerId = {customerId}");

                SqlCommand command = new SqlCommand(cmdTxt, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        foreach (DbDataRecord item in reader)
                        {
                            payments.Add(item);
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                catch
                {

                }
            }
            return payments;
        }

        public bool SaveNewCustomer(string name, string postNubmer, string phone)
        {
            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
            {
                // TODO: проверить существование одинакового имени
                // TODO: phone check
                if (phone != string.Empty)
                    phone = "'" + phone + "'";
                else phone = "null";

                string cmdTxt = String.Format(
                    $"insert into Customers values " +
                    $"('{name}','{postNubmer}',{phone})");

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = cmdTxt;
                try
                {
                    connection.Open();
                    int x = cmd.ExecuteNonQuery();
                    if (x == 1)
                        return true;
                }
                catch
                {

                }
            }
            return false;
        }

        //  Заполняет поле Id при добавлении нового, т.к. identity сам не введешь
        public string GetNextCustomerID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
            {
                connection.Open();
                string cmdTxt = @"select ident_current('Customers')";
                SqlCommand com = new SqlCommand(cmdTxt, connection);

                int id = Convert.ToInt32(com.ExecuteScalar());
                id++;
                return id.ToString();
            }
        }
    }
}
