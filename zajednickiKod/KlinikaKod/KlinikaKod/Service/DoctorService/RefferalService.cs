/***********************************************************************
 * Module:  RefferalService.cs
 * Purpose: Definition of the Class Service.DoctorService.RefferalService
 ***********************************************************************/

using Model.Doctor;
using System;

namespace Service.DoctorService
{
   public class RefferalService
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
   
      public Repository.DoctorRepository.RefferalRepository refferalRepository;
   
   }
}