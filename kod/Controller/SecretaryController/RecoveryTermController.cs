/***********************************************************************
 * Module:  MedicalFavourTermController.cs
 * Purpose: Definition of the Class Controller.SecretaryController.MedicalFavourTermController
 ***********************************************************************/

using System;

namespace Controller.SecretaryController
{
   public class RecoveryTermController
   {
      public Model.Doctor.Recovery CreateRecoveryTerm(Model.Doctor.Recovery recoveryTerm)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Recovery ChangeRecoveryTerm(String idOfRecovery)
      {
         // TODO: implement
         return null;
      }
      
      public void CancelRecoveryTerm(String idOfRecovery)
      {
         // TODO: implement
      }
   
      public Service.SecretaryService.RecoveryTermService recoveryTermService;
   
   }
}