/***********************************************************************
 * Module:  DoctorService.cs
 * Purpose: Definition of the Class Service.DoctorService.DoctorService
 ***********************************************************************/

using System;

namespace Service.UserService
{
   public abstract class DoctorService
   {
      public Model.Patient.Appointment ScheduleAppointment(Model.Patient.Appointment newAppointment)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment CancelAppointment(Model.Patient.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.WorkPeriod SeeWorkingPeriod(Model.Manager.WorkPeriod workingPeriod)
      {
         // TODO: implement
         return null;
      }
      
      public abstract void UpdateNotifications();
   
      public Repository.DoctorRepository.DoctorRepository doctorRepository;
   
   }
}