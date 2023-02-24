/***********************************************************************
 * Module:  Appointment.cs
 * Purpose: Definition of the Class Doctor.Appointment
 ***********************************************************************/

using Model.Patient;
using System;
using System.Collections.Generic;

namespace Model.Doctor
{
  
        [Serializable]
        public class AppointmentReport : MedicalFavourTerm
        {
            public RefferalToOperation refferalToOperation;
            public Model.Patient.MedicalRecord medicalRecord;
            public List<Diagnosis> diagnosis;
            public List<Symptom> symptoms;
            public Model.Patient.Appointment appointment;
            public RefferalToSpecialist refferalToSpecialist;
            public Doctor doctor;
            public List<Allergie> allergies;

        private String TypeOfAppointment;
            private System.Boolean AppoitmentHeld = false;

            public AppointmentReport()
            {
                diagnosis = new List<Diagnosis>();
                symptoms = new List<Symptom>();
            //medicalRecord.allergies = new List<Allergie>();
            allergies = new List<Allergie>();
             
            }

        }
}