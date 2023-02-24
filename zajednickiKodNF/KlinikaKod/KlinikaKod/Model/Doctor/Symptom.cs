/***********************************************************************
 * Module:  Symptom.cs
 * Purpose: Definition of the Class Model.Doctor.Symptom
 ***********************************************************************/

using System;
using System.ComponentModel;

namespace Model.Doctor
{
   public class Symptom
   {
        public AppointmentReport appointmentReport;

        String name;
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
        #endregion
    }

}
