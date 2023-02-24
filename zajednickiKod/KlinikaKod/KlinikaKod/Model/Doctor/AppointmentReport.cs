/***********************************************************************
 * Module:  Appointment.cs
 * Purpose: Definition of the Class Doctor.Appointment
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class AppointmentReport : MedicalFavourTerm
   {
      public RefferalToOperation refferalToOperation;
      public Model.Patient.MedicalRecord medicalRecord;
      public Diagnosis[] diagnosis;
      public Symptom[] symptom;
      public Model.Patient.Appointment appointment;
      public RefferalToSpecialist refferalToSpecialist;
      public Doctor doctor;
   
      private String TypeOfAppointment;
      private System.Boolean AppoitmentHeld = false;
   
   }
}