/***********************************************************************
 * Module:  SecretaryRepository.cs
 * Purpose: Definition of the Class Repository.SecretaryRepository.SecretaryRepository
 ***********************************************************************/

using Model.Doctor;
using Model.Manager;
using System;
using System.Collections.Generic;

namespace Repository.SecretaryRepository
{
   public class SecretaryRepository
   {
      public Model.Manager.WorkPeriod GetWorkingPeriod(Model.Doctor.Doctor doctor)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Secretary.Secretary ModifySecretary(Model.Secretary.Secretary secretaryToModify)
      {
         // TODO: implement
         return null;
      }
      
      public List<Doctor> GetAvailableDoctors(Model.Doctor.Specialisation specialisation, System.DateTime day)
      {
         // TODO: implement
         return null;
      }
      
      public List<OperationRoom> GetFreeOperationRooms(System.DateTime beginTime, System.DateTime endTime)
      {
         // TODO: implement
         return null;
      }
      
      public List<OperationRoom> GetAllOperationRooms()
      {
         // TODO: implement
         return null;
      }
      
      public List<RefferalToOperation> GetOperationRoomSchedule(Model.Manager.OperationRoom operationRoom, System.DateTime beginTime, System.DateTime endTime)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.RefferalToOperation AddOperation(Model.Doctor.RefferalToOperation operation)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.RefferalToOperation ChangeOperationTime(String idOfOperation)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteOperation(String idOfOperation)
      {
         // TODO: implement
      }
   
      private String Path;
   
   }
}