using BasicWPFFoundation.Models.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BasicWPFFoundation.ViewModels.Business
{
    public class UserViewModel :  BaseBusinessViewModel
    {
        private User model;
        private bool isSelected = false;

        public UserViewModel(User model, bool isSelected)
        {
           
            this.model = model;
            this.isSelected = isSelected;
        }

        public User Model
        {
            get { return model; }
            set { if (model != null) { model = value; NotifyPropertyChanged("Model"); } }
        }

        //public event PropertyChangedEventHandler? PropertyChanged;
        //public void NotifyPropertyChanged(string propertyName = "")
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        public Guid Id
        {
            get { return Model.Id; }
            set {  Model.Id = value; NotifyPropertyChanged(nameof(Id));  }
        }
        public string Name
        {
            get { return Model.Name; }
            set { Model.Name = value; NotifyPropertyChanged(nameof(Name)); }
        }
        public int Age
        {
            get { return Model.Age; }
            set { Model.Age = value; NotifyPropertyChanged(nameof(Age)); }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set { isSelected = value; NotifyPropertyChanged(nameof(IsSelected)); }
        }
    }
}
