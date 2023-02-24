/***********************************************************************
 * Module:  Appointment.cs
 * Purpose: Definition of the Class Model.Doctor.Appointment
 ***********************************************************************/

using Model.Doctor;
using System;
using System.ComponentModel;

namespace Model.Patient
{
   public class Appointment
   {
        public Model.Doctor.Doctor Doctor;  //treba doktor, ne doktor speciajlista..
        public AppointmentReport appointmentReport;
        public Patient Patient { get; set; }

        public Model.Doctor.Doctor doctor
        {
            get
            {
                return Doctor;
            }
            set
            {
                Doctor = value;
                OnPropertyChanged("doctor");
            }
        }

        public Patient GetPatient()
        {
            return Patient;
        }

       
        public void SetPatient(Patient newPatient)
        {
            if (this.Patient != newPatient)
            {
                if (this.Patient != null)
                {
                    Patient oldPatient = this.Patient;
                    this.Patient = null;
                    oldPatient.RemoveAppointments(this);
                }
                if (newPatient != null)
                {
                    this.Patient = newPatient;
                    this.Patient.AddAppointments(this);
                }
            }
        }

        long appointmentID;
        public long AppointmentID
        {
            get
            {
                return appointmentID;
            }
            set
            {
                appointmentID = value;
                OnPropertyChanged("AppointmentID");
            }
        }
        DateTime beginDate;
        public DateTime BeginDate
        {
            get
            {
                return beginDate;
            }
            set
            {
                beginDate = value;
                OnPropertyChanged("BeginDate");
            }
        }
        public DateTime endDate;
        public DateTime EndDate
        {
            get
            {
                return endDate;
            }
            set
            {
                endDate = value;
                OnPropertyChanged("EndDate");
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