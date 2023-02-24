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
      public Model.Patient.Appointment ChangeAppointment(Model.Patient.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public void CancelAppointment(Model.Patient.Appointment appointment)
      {
         // TODO: implement
      }
      
      public List<Appointment> OverviewAppointments()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment OverviewAppointment(DateTime date)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment RecommendAppointment(Model.Doctor.Doctor doctor, DateTime beginDate, DateTime endDate)
      {
         // TODO: implement
         return null;
      }
   
      public Service.PatientService.AppointmentService appointmentService;
   
   }
}