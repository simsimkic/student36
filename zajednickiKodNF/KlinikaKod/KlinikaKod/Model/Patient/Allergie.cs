/***********************************************************************
 * Module:  Allergies.cs
 * Purpose: Definition of the Class Pacijent.Allergies
 ***********************************************************************/

using System;
using System.ComponentModel;

namespace Model.Patient
{
   public class Allergie
   {
        private string allergens;
        private AllergicReaction allergicReactions;

        public String Allergens
        {
            get
            {
                return allergens;
            }
            set
            {
                allergens = value;
                OnPropertyChanged("Allergens");
            }
        }

        public AllergicReaction AllergicReaction
        {
            get
            {
                return allergicReactions;
            }
            set
            {
                allergicReactions = value;
                OnPropertyChanged("AllergicReactions");
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