/***********************************************************************
 * Module:  AppointmentController.cs
 * Purpose: Definition of the Class Controller.DoctorController.AppointmentController
 ***********************************************************************/

using Model.Doctor;
using Model.Patient;
using System;
using System.Collections.Generic;

namespace Controller.DoctorController
{
   public class AppointmentController
   {
      public Model.Doctor.Prescription WritePrescription(Model.Doctor.Prescription prescription)
      {
         // TODO: implement
         return null;
      }
      
      public String EstablishDiagnosis(List<Diagnosis> diagnosis)
      {
         // TODO: implement
         return null;
      }

      public Model.Patient.MedicalRecord UpdateRecord(Model.Patient.MedicalRecord medicalRecord)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Symptom EnterSymptoms(List<Symptom> symptoms)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Allergie EnterAllergies(List<Allergie> allergies)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.AppointmentReport SaveNewAppointment(Model.Doctor.AppointmentReport appointmentReport, Model.Patient.MedicalRecord medicalRecord)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.MedicalRecord CatchMedicalRecord(Model.Patient.Patient patient)
      {
         // TODO: implement
         return null;
      }
   
      public Service.DoctorService.AppointmentService appointmentService;
   
   }
}