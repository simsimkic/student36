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
   
      public Repository.PatientRepository.AppointmentRepository appointmentRepository;
   
   }
}