/***********************************************************************
 * Module:  DoctorController.cs
 * Purpose: Definition of the Class Controller.DoctorController.DoctorController
 ***********************************************************************/

using Model.Doctor;
using Service.DoctorService;
using System;
using System.Collections.Generic;

namespace Controller.DoctorController
{
   public class DoctorController
   {

        AppointmentService appointmentService = new AppointmentService();
        public Model.Patient.Appointment ScheduleAppointment(Model.Patient.Appointment newAppointment)
      {
         // TODO: implement
         return null;
      }

       
        public List<Doctor> GetDoctorsByTime(DateTime time)
        {
            return appointmentService.GetDoctorsByTime(time);
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