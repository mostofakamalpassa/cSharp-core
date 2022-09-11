using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.DynamicProg
{
    class Customer : Person { public decimal CreditLimit { get; set; } }
    class Employee : Person { public decimal Salary { get; set; } }
}
