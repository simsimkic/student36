/***********************************************************************
 * Module:  MedicalRecordRepository.cs
 * Purpose: Definition of the Class Repository.PatientRepository.MedicalRecordRepository
 ***********************************************************************/

using Model.Doctor;
using Model.Patient;
using System;
using System.Collections.Generic;

namespace Repository.PatientRepository
{
   public class MedicalRecordRepository
   {
      public Model.Patient.MedicalRecord GetMedicalRecord(String medicalRecordID)
      {
         // TODO: implement
         return null;
      }
      
      public List<Prescription> GetAllPrescriptions(int patitentID)
      {
         // TODO: implement
         return null;
      }
      
      public List<Allergie> GetAllergies()
      {
         // TODO: implement
         return null;
      }
      
      public List<HospitalTreatment> GetHospitalTreatment()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.MedicalHistory GetMedicalHistory()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Prescription GetPrescription(String prescriptionID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.AppointmentReport GetAppointmentReport(String appointmentRepID)
      {
         // TODO: implement
         return null;
      }
   
      private String Path;
   
   }
}