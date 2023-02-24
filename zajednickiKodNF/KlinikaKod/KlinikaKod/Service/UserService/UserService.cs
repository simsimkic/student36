/***********************************************************************
 * Module:  UserService.cs
 * Purpose: Definition of the Class Service.UserService.UserService
 ***********************************************************************/

using Model.Patient;
using System;

namespace Service.UserService
{
   public class UserService
   {
      public UserService()
      {
          patientRepository = new Repository.PatientRepository.PatientRepository();
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
   
      public NotificationService notificationService;
      public Repository.DoctorRepository.DoctorRepository doctorRepository;
      public Repository.ManagerRepository.ManagerRepository managerRepository;
      public Repository.PatientRepository.PatientRepository patientRepository;
      public Repository.SecretaryRepository.SecretaryRepository secretaryRepository;

      private const int MinPasswordLength = 8;
      private const int UserNameLength = 13;
   
   }
}