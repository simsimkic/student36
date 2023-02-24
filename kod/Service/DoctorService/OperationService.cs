/***********************************************************************
 * Module:  OperationService.cs
 * Purpose: Definition of the Class Service.DoctorService.OperationService
 ***********************************************************************/

using System;

namespace Service.DoctorService
{
   public class OperationService
   {
      public void SendToHospitalStay(int roomID)
      {
         // TODO: implement
      }
      
      public Model.Doctor.RefferalToOperation CancelOperation(Model.Doctor.RefferalToOperation operation)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.DoctorRepository.OperationRepository operationRepository;
   
   }
}