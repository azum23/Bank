using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Globalization;

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

        internal string GetNextCreditID()
        {
            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
            {
                connection.Open();
                string cmdTxt = @"select ident_current('Credits')";
                SqlCommand com = new SqlCommand(cmdTxt, connection);

                int id = Convert.ToInt32(com.ExecuteScalar());
                id++;
                return id.ToString();
            }
        }

        internal bool SaveNewCredit(int customerId, int amount, DateTime openDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
            {

                string cmdTxt = String.Format(
                    $"insert into Credits " +
                    $" (CustomerId, Amount, Balance, OpenDate) values " +
                    $"({customerId.ToString()},{amount},{amount},'{openDate.ToString()}')");

                SqlCommand cmd = new SqlCommand(cmdTxt, connection);

                try
                {
                    connection.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                        return true;
                }
                catch
                {

                }
            }
            return false;
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

        internal bool SaveNewPayment(int creditId, decimal payAmmount, DateTime date)
        {
            payAmmount = decimal.Round(payAmmount, 2);
            string payToString = payAmmount.ToString(CultureInfo.InvariantCulture.NumberFormat);

            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionString.ConnectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                
                try
                {
                    SqlCommand com1 = connection.CreateCommand();
                    com1.Transaction = transaction;
                    com1.CommandText = String.Format($"Insert into Payments (CreditId, Amount, PayDate) " +
                        $"Values ({creditId},'{payToString}','{date.ToShortDateString()}')");
                    com1.ExecuteNonQuery();

                    SqlCommand com2 = connection.CreateCommand();
                    com2.Transaction = transaction;
                    com2.CommandText = String.Format($"Update [Credits] " +
                        $"set [Balance] = [Balance] - '{payToString}' " +
                        $"where [Id] = {creditId}");
                    com2.ExecuteNonQuery();

                    transaction.Commit();
                    result = true;
                }
                catch
                {
                    transaction.Rollback();
                }
                finally
                {

                }

            }

            return result;
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
