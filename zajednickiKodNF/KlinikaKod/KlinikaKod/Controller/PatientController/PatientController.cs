/***********************************************************************
 * Module:  PatientService.cs
 * Purpose: Definition of the Class Service.PatientService.PatientService
 ***********************************************************************/

using Model.Patient;
using System;

namespace Controller.PatientController
{
   public class PatientController
   {
      public PatientController()
      {
            patientService = new Service.UserService.PatientService();
      }

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
            
            return patientService.ChangeProfileData(patient);
      }

      public bool RegisterPatient(Model.Patient.Patient newPatient)
      {
          return patientService.RegisterPatient(newPatient);
      }

        public Model.Patient.Patient GetPatientData(string jmbg)
      {
            return patientService.GetPatientData(jmbg);
      }

        public Model.Patient.Appointment ScheduleAppointment(Model.Doctor.Doctor doctor, DateTime date)
      {
         // TODO: implement
         return null;
      }

      public bool SignIn(String jmbg, String password, out Patient p)
      {
           p = null;
           return patientService.SignIn(jmbg, password, out p);
      }

        public Service.UserService.PatientService patientService;
   
   }
}