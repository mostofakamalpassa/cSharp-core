using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DynamicProgramming.DynamicProg
{
    internal class ToXElementPersonVisitor
    {

        XElement Visit(Person p)
        {
            return new XElement("Person",
            new XAttribute("Type", p.GetType().Name),
            new XElement("FirstName", p.FirstName),
            new XElement("LastName", p.LastName),
            p.Friends.Select(f => (dynamic) Visit(f))
            );
        }

        XElement Visit(Customer c) // Specialized logic for customers
        {
            XElement xe = Visit((Person)c); // Call "base" method
            xe.Add(new XElement("CreditLimit", c.CreditLimit));
            return xe;
        }
        XElement Visit(Employee e) // Specialized logic for employees
        {
            XElement xe = Visit((Person)e); // Call "base" method
            xe.Add(new XElement("Salary", e.Salary));
            return xe;
        }
    }
}
