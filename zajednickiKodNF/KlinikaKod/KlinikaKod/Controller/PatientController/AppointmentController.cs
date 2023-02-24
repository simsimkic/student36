/***********************************************************************
 * Module:  AppointmentController.cs
 * Purpose: Definition of the Class Controller.PatientController.AppointmentController
 ***********************************************************************/

using Model.Patient;
using System;
using System.Collections.Generic;

namespace Controller.PatientController
{
   public class AppointmentController
   {
      public AppointmentController()
      {
          appointmentService = new Service.PatientService.AppointmentService();
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

      public List<Appointment> GetAllAppointments()
      {
          return appointmentService.GetAllAppointments();
      }

      public List<Appointment> GetAppointment(string jmbg)
      {
          return appointmentService.GetAllAppointments();
      }
      
      public List<Model.Doctor.Doctor> GetAllDoctors()
      {
          return appointmentService.GetAllDoctors();
      }

        public Model.Patient.Appointment RecommendAppointment(Model.Doctor.Doctor doctor, DateTime beginDate, DateTime endDate)
      {
         // TODO: implement
         return null;
      }

      public Appointment SaveNewAppointment(Appointment appointment)
      {
          return appointmentService.SaveNewAppointment(appointment);
      }
        public Service.PatientService.AppointmentService appointmentService;
   
   }
}