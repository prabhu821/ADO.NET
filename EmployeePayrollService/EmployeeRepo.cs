using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService
{
    class EmployeeRepo
    {
        public static void EmpDatabase()
        {
            SqlConnection sqlConnection = new SqlConnection("data source=(localdb)\\MSSQLLocalDB; initial catalog=master; integrated security=true");
            try
            {
                string query = "create database Employee_Service_Payroll";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine("Database created successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something is not right");
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
