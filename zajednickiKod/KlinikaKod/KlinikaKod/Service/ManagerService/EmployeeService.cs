/***********************************************************************
 * Module:  EmployeeService.cs
 * Purpose: Definition of the Class Service.ManagerService.EmployeeService
 ***********************************************************************/

using Controller.ManagerController;
using Model.Patient;
using System;
using System.Collections.Generic;

namespace Service.ManagerService
{
   public class EmployeeService
   {
      public Model.Secretary.Secretary HireSecretary(int secretaryID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Doctor HireDoctor(int doctorID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.WorkPeriod AddWorkingTime(Model.Manager.Employee employee)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.Employee SeeAllEmployees()
      {
         // TODO: implement
         return null;
      }
      
      public void FireSecretary(Model.Secretary.Secretary secretary)
      {
         // TODO: implement
      }
      
      public Model.Doctor.Doctor FireDoctor(Model.Doctor.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public List<Appointment> GetAppointmentSchedule(Model.Doctor.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public List<Operation> GetOperationSchedule(Model.Doctor.DoctorSpecialist doctor)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.ManagerRepository.EmployeeRepository employeeRepository;
   
   }
}