/***********************************************************************
 * Module:  RefferalRepository.cs
 * Purpose: Definition of the Class Repository.DoctorRepository.RefferalRepository
 ***********************************************************************/

using Model.Doctor;
using System;
using System.Collections.Generic;

namespace Repository.DoctorRepository
{
   public class RefferalRepository
   {
      public List<Doctor> GetAllSpecDoctors(Model.Doctor.Specialisation specialisation, System.DateTime day)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.NonStorageRoom GetFreeRooms(Dto.DTOGetFreeRooms dTOGetFreeRooms)
      {
         // TODO: implement
         return null;
      }
      
      public List<Term> GetFreeTerms(Dto.DTOGetFreeTerms dTOGetFreeTerms)
      {
         // TODO: implement
         return null;
      }
   
      private String Path;
   
   }
}