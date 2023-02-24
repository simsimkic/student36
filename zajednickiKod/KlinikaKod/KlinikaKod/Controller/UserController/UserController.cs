/***********************************************************************
 * Module:  UserService.cs
 * Purpose: Definition of the Class Service.UserService.UserService
 ***********************************************************************/

using System;

namespace Controller.UserController
{
   public class UserController
   {
      public void SignIn(String userName, String password)
      {
         // TODO: implement
      }
      
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
   
      public Service.UserService.UserService userService;
      public Service.UserService.NotificationService notificationService;
   
   }
}