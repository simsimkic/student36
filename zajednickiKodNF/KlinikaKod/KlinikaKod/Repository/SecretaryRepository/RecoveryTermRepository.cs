/***********************************************************************
 * Module:  MedicalFavourTermRepository.cs
 * Purpose: Definition of the Class Repository.SecretaryRepository.MedicalFavourTermRepository
 ***********************************************************************/

using Model.Doctor;
using System;
using System.Collections.Generic;

namespace Repository.SecretaryRepository
{
   public class RecoveryTermRepository
   {
      public List<Recovery> GetAllRecoveries(DateTime beginTimePoint, DateTime endTimePoint)
      {
         // TODO: implement
         return null;
      }
      
      public List<Recovery> GetAllRecoveries(Model.Manager.RecoveryRoom recoveryRoom)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Recovery GetRecovery(Model.Patient.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Recovery GetRecovery(String id)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Recovery ModifyRecovery(Model.Doctor.Recovery recovery)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteRecovery(String id)
      {
         // TODO: implement
      }
   
      private String Path;
   
   }
}