using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryXmlToJsonConversion
{
    public class EmployeeDestinationFormat
    {
        public string personName { get; set; }
        public Salary salary { get; set; }
        public string hireDate { get; set; }
    }

    public class Salary
    {
        public double monthly { get; set; }
    }
}
