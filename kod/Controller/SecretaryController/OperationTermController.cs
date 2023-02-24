/***********************************************************************
 * Module:  OperationTermController.cs
 * Purpose: Definition of the Class Controller.SecretaryController.OperationTermController
 ***********************************************************************/

using Controller.ManagerController;
using System;
using System.Collections.Generic;

namespace Controller.SecretaryController
{
   public class OperationTermController
   {
      public Model.Doctor.RefferalToOperation CreateOperationTerm(Model.Doctor.RefferalToOperation operationTerm)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.RefferalToOperation ChangeOperationTerm(String idOfOperation)
      {
         // TODO: implement
         return null;
      }
      
      public void CancelOperationTerm(String idOfOperation)
      {
         // TODO: implement
      }
      
      public void SetAsUrgent(Model.Doctor.RefferalToOperation operation)
      {
         // TODO: implement
      }
      
      public List<Operation> GetOperationSchedule(Model.Doctor.DoctorSpecialist doctor)
      {
         // TODO: implement
         return null;
      }
      
      public List<Operation> GetOperationRoomSchedule(Model.Manager.OperationRoom operationRoom)
      {
         // TODO: implement
         return null;
      }
   
      //public Service.SecretaryService.OperationTermService operationTermService;
   
   }
}