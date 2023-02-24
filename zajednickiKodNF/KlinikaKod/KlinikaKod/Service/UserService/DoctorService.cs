/***********************************************************************
 * Module:  DoctorService.cs
 * Purpose: Definition of the Class Service.DoctorService.DoctorService
 ***********************************************************************/

using System;

namespace Service.UserService
{
   public class DoctorService
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

      // Izbacivalo je gresku posto je ova radnja bila apstraktna i sadrzana u neapstraktnoj klasi.
      // Zbog toga sam stavio da nije apstraktna.
      public void UpdateNotifications()
      {
      }
   
      public Repository.DoctorRepository.DoctorRepository doctorRepository;
   
   }
}