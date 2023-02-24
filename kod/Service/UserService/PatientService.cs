/***********************************************************************
 * Module:  PatientService.cs
 * Purpose: Definition of the Class Service.PatientService.PatientService
 ***********************************************************************/

using System;

namespace Service.UserService
{
   public abstract class PatientService
   {
      public void SubmitFeedback(Model.Patient.Feedback feedback)
      {
         // TODO: implement
      }
      
      public void SubmitSurvey(Model.Patient.Survey survey)
      {
         // TODO: implement
      }
      
      public Model.Patient.Patient ChangeProfileData(Model.Patient.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Patient RegisterPatient(Model.Patient.Patient newPatient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment ScheduleAppointment(Model.Doctor.Doctor doctor, DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public abstract void UpdateNotifications();
   
      public Repository.PatientRepository.PatientRepository patientRepository;
   
   }
}