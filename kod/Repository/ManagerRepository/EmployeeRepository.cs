/***********************************************************************
 * Module:  EmployeeRepository.cs
 * Purpose: Definition of the Class Repository.ManagerRepository.EmployeeRepository
 ***********************************************************************/

using System;

namespace Repository.ManagerRepository
{
   public class EmployeeRepository
   {
      public Model.Manager.Employee GetAllEmployees()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Secretary.Secretary GetSecretary(int secretaryID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Doctor GetDoctor(int doctorID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.WorkPeriod GetSecretaryWorkSchedule(int secretaryID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.WorkPeriod GetDoctorWorkSchedule(int doctorID)
      {
         // TODO: implement
         return null;
      }
   
      private String Path;
   
   }
}