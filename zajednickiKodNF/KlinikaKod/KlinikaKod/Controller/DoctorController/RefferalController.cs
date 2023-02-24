/***********************************************************************
 * Module:  RefferalController.cs
 * Purpose: Definition of the Class Controller.DoctorController.RefferalController
 ***********************************************************************/

using Model.Doctor;
using System;

namespace Controller.DoctorController
{
   public class RefferalController
   {
      public Model.Doctor.RefferalToSpecialist WriteRefferalToSpeciallist(Model.Doctor.RefferalToSpecialist refferal)
      {
         // TODO: implement
         return null;
      }
      
      public RefferalToOperation WriteRefferalToOperation(RefferalToOperation refferal)
      {
         // TODO: implement
         return null;
      }
      
      public System.Boolean AreThereFreeRooms(System.DateTime date)
      {
         // TODO: implement
         return false;
      }
      
      public Dto.DTOGetFreeTerms AreThereFreeTerms()
      {
         // TODO: implement
         return null;
      }
   
      public Service.DoctorService.RefferalService refferalService;
   
   }
}