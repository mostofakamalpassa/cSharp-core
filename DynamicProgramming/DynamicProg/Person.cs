using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming.DynamicProg
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // The Friends collection may contain Customers & Employees:
        public readonly IList<Person> Friends = new Collection<Person>();
    }
}
