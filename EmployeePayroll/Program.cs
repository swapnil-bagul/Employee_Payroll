using System;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            employeeRepository.GetEmployeeAllDeatils();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
