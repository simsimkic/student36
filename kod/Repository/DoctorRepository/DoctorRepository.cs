/***********************************************************************
 * Module:  DoctorRepository.cs
 * Purpose: Definition of the Class Repository.DoctorRepository.DoctorRepository
 ***********************************************************************/

using System;

namespace Repository.DoctorRepository
{
   public class DoctorRepository
   {
      public Model.Manager.WorkPeriod GetWorkingPeriod(System.DateTime beginDate, System.DateTime endDate)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.AppointmentReport SetAppointmentReport(Model.Doctor.AppointmentReport appointmentReport)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.AppointmentReport GetAppointmentReport(Model.Doctor.AppointmentReport appointmentReport)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment GetAllAppointments()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment GetAppointment(Model.Patient.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment SetAppointment(Model.Patient.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.WorkPeriod GetWorkingPeriod(System.DateTime date)
      {
         // TODO: implement
         return null;
      }
   
      private String Path;
   
   }
}