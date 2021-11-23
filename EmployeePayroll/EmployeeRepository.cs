using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data.SqlClient;
namespace EmployeePayroll
{
    class EmployeeRepository
    {
        public static string connectionString = @"Data Source = (localdb)\ProjectsV13;Initial Catalog = Payroll_Services_Database;";
        SqlConnection connection = new SqlConnection(connectionString);
    }
}
