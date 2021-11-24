using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll
{
    class EmployeeModel
    {
        public int EmplyeeID { get; set; }
        public string  EmplyeeName { get; set; }
        public double PhoneNumber { get; set; }
        public double  Salary { get; set; }
        public string  Address { get; set; }
        public string  Department { get; set; }
        public char  Gender { get; set; }
        public double  BasicPay { get; set; }
        public double Deduction { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }
        public DateTime  Startdate { get; set; }

    }
}
