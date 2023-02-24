/***********************************************************************
 * Module:  MedicalRecordService.cs
 * Purpose: Definition of the Class Service.PatientService.MedicalRecordService
 ***********************************************************************/

using Model.Patient;
using System;
using System.Collections.Generic;

namespace Controller.PatientController
{
   public class MedicalRecordController
   {
      public Model.Patient.MedicalRecord OverviewOfRecord()
      {
         // TODO: implement
         return null;
      }
      
      public List<Allergie> OverviewAllergies()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.HospitalTreatment OverviewHospitalTreatment()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.MedicalHistory OverviewMedicalHistory()
      {
         // TODO: implement
         return null;
      }
   
      public Service.PatientService.MedicalRecordService medicalRecordService;
   
   }
}