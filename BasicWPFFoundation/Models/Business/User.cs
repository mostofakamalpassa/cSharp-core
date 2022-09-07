using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWPFFoundation.Models.Business
{
    public class User
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public User(Guid id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
       
    }
}
