/***********************************************************************
 * Module:  MedicineIngredient.cs
 * Purpose: Definition of the Class Lekar.MedicineIngredient
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Model.Manager
{
   public class MedicineIngredient
   {
      public System.Collections.ArrayList medicine;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetMedicine()
      {
         if (medicine == null)
            medicine = new System.Collections.ArrayList();
         return medicine;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetMedicine(System.Collections.ArrayList newMedicine)
      {
         RemoveAllMedicine();
         foreach (Medicine oMedicine in newMedicine)
            AddMedicine(oMedicine);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddMedicine(Medicine newMedicine)
      {
         if (newMedicine == null)
            return;
         if (this.medicine == null)
            this.medicine = new System.Collections.ArrayList();
         if (!this.medicine.Contains(newMedicine))
            this.medicine.Add(newMedicine);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveMedicine(Medicine oldMedicine)
      {
         if (oldMedicine == null)
            return;
         if (this.medicine != null)
            if (this.medicine.Contains(oldMedicine))
               this.medicine.Remove(oldMedicine);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllMedicine()
      {
         if (medicine != null)
            medicine.Clear();
      }
   
      private String name;

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


        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public static implicit operator List<object>(MedicineIngredient v)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}