using System;
using System.Data.SqlClient;


namespace EmployeePayroll
{
    class EmployeeRepository
    {
        public static string connectionString = @"Data Source = (localdb)\ProjectsV13;Initial Catalog = Payroll_Services_Database;";   
        //created connection object to connect database
        SqlConnection sqlconnection = new SqlConnection(connectionString);
    
        public void GetEmployeeAllDeatils()
        {
            string query = @"select * from Employee_Payroll";
            //command object for excuting query against database
            SqlCommand sqlCommand = new SqlCommand(query, sqlconnection);
            sqlconnection.Open();
            //excuting command object
            SqlDataReader reader = sqlCommand.ExecuteReader();
            EmployeeModel employeeModel = new EmployeeModel();
            if(reader .HasRows )
            {
                try
                {
                    while (reader.Read())
                    {
                        employeeModel.EmplyeeID = Convert.ToInt32(reader["Id"] == DBNull.Value ? default : reader["Id"]);
                        employeeModel.EmplyeeName = reader["Name"] == DBNull.Value ? default : reader["Name"].ToString();
                        employeeModel.BasicPay = Convert.ToDouble(reader["Salary"] == DBNull.Value ? default : reader["Salary"]);
                        employeeModel.Gender = Convert.ToChar(reader["Gender"] == DBNull.Value ? default : reader["Gender"]);
                        employeeModel.Startdate = Convert.ToDateTime(reader["StartDate"] == DBNull.Value ? default : reader["StartDate"]);
                        employeeModel.PhoneNumber = Convert.ToDouble(reader["Phone"] == DBNull.Value ? default : reader["Phone"]);
                        employeeModel.Department = reader["Department"] == DBNull.Value ? default : reader["Department"].ToString();
                        employeeModel.Deduction = Convert.ToDouble(reader["Deduction"] == DBNull.Value ? default : reader["Deduction"]);
                        employeeModel.TaxablePay = Convert.ToDouble(reader["Taxable_Pay"] == DBNull.Value ? default : reader["Taxable_Pay"]);
                        employeeModel.IncomeTax = Convert.ToDouble(reader["Income_Tax"] == DBNull.Value ? default : reader["Income_Tax"]);
                        employeeModel.NetPay = Convert.ToDouble(reader["Net_Pay"] == DBNull.Value ? default : reader["Net_Pay"]);
                        Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}", employeeModel.EmplyeeID, employeeModel.EmplyeeName, employeeModel.Address, employeeModel.Department, employeeModel.PhoneNumber, employeeModel.Startdate, employeeModel.BasicPay, employeeModel.Deduction, employeeModel.TaxablePay, employeeModel.IncomeTax, employeeModel.NetPay);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message );
                }
                finally
                {
                    sqlconnection.Close();
                }

            }
            else
            {
                Console.WriteLine("No data Found");
            }
        }
    }
}
