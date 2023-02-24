/***********************************************************************
 * Module:  UserService.cs
 * Purpose: Definition of the Class Service.UserService.UserService
 ***********************************************************************/

using Model.Patient;
using System;

namespace Controller.UserController
{
   public class UserController
   {
      
      public Boolean ForgottenPassword(String userName, String newPassword)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean IsUserNameValid(String userName)
      {
         // TODO: implement
         return false;
      }
      
      public Boolean IsPasswordValid(String password)
      {
         // TODO: implement
         return false;
      }
      
      public Model.User.Contact ChangeContactInformations()
      {
         // TODO: implement
         return null;
      }
   
      public Service.UserService.UserService userService = new Service.UserService.UserService();
      public Service.UserService.NotificationService notificationService;
   
   }
}