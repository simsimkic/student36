/***********************************************************************
 * Module:  PatientService.cs
 * Purpose: Definition of the Class Service.PatientService.PatientService
 ***********************************************************************/

using Model.Patient;
using System;
using System.Collections.Generic;

namespace Service.PatientService
{
   public class AppointmentService
   {

      public AppointmentService()
      {
            appointmentRepository = new Repository.PatientRepository.AppointmentRepository();
            doctorRepository = new Repository.DoctorRepository.DoctorRepository();
      }
        public Model.Patient.Appointment ChangeAppointment(Model.Patient.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public void CancelAppointment(Model.Patient.Appointment appointment)
      {
         // TODO: implement
      }

      public List<Appointment> GetAllAppointments() //GetAll()
      {
            // TODO: implement
            return appointmentRepository.GetAllAppointments();
      }
      public List<Appointment> GetAppointment(string jmbg)
      {
          return appointmentRepository.GetAppointment(jmbg);
      }

        public List<Appointment> OverviewAppointments()
      {
         // TODO: implement
         return null;
      }

      public List<Model.Doctor.Doctor> GetAllDoctors()
      {
            return doctorRepository.GetAllDoctors();
      }

      
      public Model.Patient.Appointment RecommendAppointment(Model.Doctor.Doctor doctor, DateTime beginDate, DateTime endDate)
      {
         // TODO: implement
         return null;
      }

      public Appointment SaveNewAppointment(Appointment appointment)
      {
            return appointmentRepository.SetAppointment(appointment);
      }

      public Repository.PatientRepository.AppointmentRepository appointmentRepository = new Repository.PatientRepository.AppointmentRepository();
      public Repository.DoctorRepository.DoctorRepository doctorRepository = new Repository.DoctorRepository.DoctorRepository();

    }
}