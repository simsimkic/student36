/***********************************************************************
 * Module:  Appointment.cs
 * Purpose: Definition of the Class Model.Doctor.Appointment
 ***********************************************************************/

using Model.Doctor;
using System;

namespace Model.Patient
{
   public class Appointment
   {
      public DoctorSpecialist doctor;  //treba doktor, ne doktor speciajlista..
      public AppointmentReport appointmentReport;
      public Patient patient;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public Patient GetPatient()
      {
         return patient;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newPatient</param>
      public void SetPatient(Patient newPatient)
      {
         if (this.patient != newPatient)
         {
            if (this.patient != null)
            {
               Patient oldPatient = this.patient;
               this.patient = null;
               oldPatient.RemoveAppointments(this);
            }
            if (newPatient != null)
            {
               this.patient = newPatient;
               this.patient.AddAppointments(this);
            }
         }
      }
   
      private String AppointmentID;
      private DateTime BeginDate;
      private DateTime EndDate;
   
   }
}