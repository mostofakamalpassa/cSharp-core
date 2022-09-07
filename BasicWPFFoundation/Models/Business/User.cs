using BasicWPFFoundation.DataModels;
using BasicWPFFoundation.DataModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWPFFoundation.Models.Business
{
    public class User: IAuditable
    {

        private Auditable auditable;

        public Auditable Auditable
        {
            get { return auditable; }
            set { auditable = value; }
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime CreatedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public User CreatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? UpdatedOn { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public User UpdatedBy { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        

        public User(Guid id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
       
    }
}
