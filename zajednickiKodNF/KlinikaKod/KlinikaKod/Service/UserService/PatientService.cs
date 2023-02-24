/***********************************************************************
 * Module:  PatientService.cs
 * Purpose: Definition of the Class Service.PatientService.PatientService
 ***********************************************************************/

using Model.Patient;
using Repository.PatientRepository;
using System;

namespace Service.UserService
{
   public class PatientService
   {
        
        public PatientService()
        {
            patientRepository = new Repository.PatientRepository.PatientRepository();
            medicalRecordRepository = new Repository.PatientRepository.MedicalRecordRepository();

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
            // TODO: implement
            return patientRepository.SetPatient(patient);
        }

        public bool RegisterPatient(Model.Patient.Patient newPatient) //izmeniti tip u klasnom
        {
            medicalRecordRepository.SetMedicalRecord(newPatient);
            return patientRepository.RegisterPatient(newPatient);
        }

        public Model.Patient.Patient GetPatientData(string jmbg)
        {
            return patientRepository.GetPatient(jmbg);  //dodati ovu metodu u klasnom!
        }


        public Model.Patient.Appointment ScheduleAppointment(Model.Doctor.Doctor doctor, DateTime date)
        {
            // TODO: implement
            return null;
        }
        
        public void UpdateNotifications()
        {

        }

        public bool SignIn(String jmbg, String password, out Patient p)
        {
            p = null;
            return patientRepository.SignIn(jmbg, password, out p);
        }
        public Repository.PatientRepository.PatientRepository patientRepository;
        public Repository.PatientRepository.MedicalRecordRepository medicalRecordRepository;

    }
}