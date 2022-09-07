using BasicWPFFoundation.Models.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWPFFoundation.DataModels
{
    public class BaseDataModel : INotifyPropertyChanged
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

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void NotifyPropertyChanged(params string[] propertyNames)
        {
            if (PropertyChanged != null)
            {
                foreach (string propertyName in propertyNames)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }
        }


    }
}
