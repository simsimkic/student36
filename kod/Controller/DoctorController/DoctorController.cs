/***********************************************************************
 * Module:  DoctorController.cs
 * Purpose: Definition of the Class Controller.DoctorController.DoctorController
 ***********************************************************************/

using System;

namespace Controller.DoctorController
{
   public class DoctorController
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
   
      public Service.UserService.DoctorService doctorService;
   
   }
}