using BasicWPFFoundation.DataModels.Interfaces;
using BasicWPFFoundation.Models.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWPFFoundation.DataModels
{
    public class Invoice : BaseDataModel, IAuditable
    {
        private DateTime createdOn;
        private DateTime? updatedOn;
        private User createdBy, updatedBy;

        public DateTime CreatedOn
        {
            get { return createdOn; }
            set { createdOn = value; NotifyPropertyChanged(); }
        }
        public User CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; NotifyPropertyChanged(); }
        }
        public DateTime? UpdatedOn
        {
            get { return updatedOn; }
            set { updatedOn = value; NotifyPropertyChanged(); }
        }

        public User UpdatedBy
        {
            get { return updatedBy; }
            set { updatedBy = value; NotifyPropertyChanged(); }
        }
    }
}
