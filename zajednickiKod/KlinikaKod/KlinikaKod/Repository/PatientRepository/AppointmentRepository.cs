/***********************************************************************
 * Module:  AppointmentRepository.cs
 * Purpose: Definition of the Class Repository.PatientRepository.AppointmentRepository
 ***********************************************************************/

using Model.Patient;
using System;
using System.Collections.Generic;

namespace Repository.PatientRepository
{
   public class AppointmentRepository
   {
      public Model.Patient.Appointment GetAppointment(String appointmentID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment SetAppointment(Model.Patient.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAllAppointments(int patientID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment GetAvailableTermByDate(DateTime beginDate, DateTime endDate)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment GetAvailableTerm(Model.Doctor.Doctor doctor, DateTime beginDate, DateTime endDate)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment GetAvailableTermByDoctor(Model.Doctor.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment SaveAppointment(Model.Patient.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
   
      private String Path;
   
   }
}