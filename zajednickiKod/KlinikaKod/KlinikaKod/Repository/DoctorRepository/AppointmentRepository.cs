/***********************************************************************
 * Module:  AppointmentRepository.cs
 * Purpose: Definition of the Class Repository.DoctorRepository.AppointmentRepository
 ***********************************************************************/

using Model.Doctor;
using Model.Patient;
using System;
using System.Collections.Generic;

namespace Repository.DoctorRepository
{
   public class AppointmentRepository
   {
      public Model.Patient.MedicalRecord GetMedicalRecord(Model.Patient.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.NonStorageRoom GetFreeRooms(Dto.DTOGetFreeRooms dTOGetFreeRooms)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.MedicalRecord SetMedicalRecord(Model.Patient.Patient parameter1)
      {
         // TODO: implement
         return null;
      }
      
      public List<Allergie> GetAllergies()
      {
         // TODO: implement
         return null;
      }
      
      public List<Symptom> GetMostCommonSymptoms()
      {
         // TODO: implement
         return null;
      }
      
      public List<Allergie> GetMostCommonAllergies()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.AppointmentReport SetAppiontment(Model.Patient.MedicalRecord medicalRecord)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.AppointmentReport AddAppointment(Model.Doctor.AppointmentReport appointment, Model.Patient.MedicalRecord medicalRecord)
      {
         // TODO: implement
         return null;
      }
   
      private String Path;
   
   }
}