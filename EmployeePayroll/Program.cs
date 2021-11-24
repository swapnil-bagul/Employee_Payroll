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
            //model.Startdate = DateTime.Now;
            // model.Gender = 'M';
            model.EmplyeeID = 7;
           // model.Salary = 55320.32;
            employeeRepository.DeleteEmplyeeContact(model);
            Console.ReadLine();
        }
    }
}
