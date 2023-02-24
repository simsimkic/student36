/***********************************************************************
 * Module:  Medicine.cs
 * Purpose: Definition of the Class Lekar.Medicine
 ***********************************************************************/

using Model.Doctor;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Model.Manager
{
   public class Medicine
   {
      public MedicineApproval medicineApproval;
      public List<Medicine> medicineIngredients;
   
      private String name;
      private String Id;
      private int Amount;
      private String PurposeOfMedicine;
      private System.DateTime LastDelivery;

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public Medicine()
        {
            
            medicineIngredients = new List<Medicine>();
            
        }

        public List<Medicine> MedicineIngredients
        {
            get
            {
                return medicineIngredients;
            }
            set
            {
                medicineIngredients = value;
                OnPropertyChanged("Ingredients");
            }
        }


        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
