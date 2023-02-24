/***********************************************************************
 * Module:  OperationRepository.cs
 * Purpose: Definition of the Class Repository.DoctorRepository.OperationRepository
 ***********************************************************************/

using Model.Doctor;
using System;
using System.Collections.Generic;
namespace Repository.DoctorRepository
{
   public class OperationRepository
   {
      public List<RefferalToOperation> GetAllOperations(DateTime beginTimePoint, DateTime endTimePoint)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.RefferalToOperation GetOperation(Model.Patient.Patient patient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.RefferalToOperation GetOperation(String id)
      {
         // TODO: implement
         return null;
      }
      
      public List<Recovery> GetFreeRecoveryRooms()
      {
         // TODO: implement
         return null;
      }
   
   }
}