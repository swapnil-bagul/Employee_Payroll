using System;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeModel model = new EmployeeModel();
            EmployeeRepository employeeRepository = new EmployeeRepository();
           // employeeRepository.GetEmployeeAllDeatils();
           //Console.WriteLine("Hello World!");
            model.EmplyeeName = "Omkar";
            model.Startdate = DateTime.Now;
            model.Gender = 'M';
            model.Salary = 43566.32;
            employeeRepository.AddEmployee(model);
            Console.ReadLine();
        }
    }
}
