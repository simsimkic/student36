/***********************************************************************
 * Module:  ManagerService.cs
 * Purpose: Definition of the Class Service.ManagerService.ManagerService
 ***********************************************************************/

using System;

namespace Service.UserService
{
   public abstract class ManagerService
   {
      public Model.User.Notification SendValidationRequest(Dto.DTOValidationRequest dTOValidationRequest)
      {
         // TODO: implement
         return null;
      }
      
      public abstract void UpdateNotifications();
   
      public Repository.ManagerRepository.ManagerRepository managerRepository;
   
   }
}