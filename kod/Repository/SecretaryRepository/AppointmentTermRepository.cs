/***********************************************************************
 * Module:  MedicalFavourTermRepository.cs
 * Purpose: Definition of the Class Repository.SecretaryRepository.MedicalFavourTermRepository
 ***********************************************************************/

using Model.Patient;
using System;
using System.Collections.Generic;

namespace Repository.SecretaryRepository
{
   public class AppointmentTermRepository
   {
      /// Ovo je radnja koja vrsi citanje i pisanje u datoteku AppointmentTermRepository.txt.
      public List<Appointment> GetAllAppointments()
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAppointments(DateTime beginTimePoint, DateTime endTimePoint)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAppointments(Model.Patient.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAppointments(Model.Doctor.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAppointments(Model.Doctor.DoctorSpecialist doctorSpecialist)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment GetAppointment(String id)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment ModifyAppointment(Model.Patient.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteAppointment(String id)
      {
         // TODO: implement
      }
   
      private String Path;
   
   }
}