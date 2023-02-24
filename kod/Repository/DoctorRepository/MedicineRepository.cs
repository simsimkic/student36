/***********************************************************************
 * Module:  MedicineRepository.cs
 * Purpose: Definition of the Class Repository.DoctorRepository.MedicineRepository
 ***********************************************************************/

using Model.Manager;
using System;
using System.Collections.Generic;

namespace Repository.DoctorRepository
{
   public class MedicineRepository
   {
      public List<Medicine> GetMedicineList()
      {
         // TODO: implement
         return null;
      }
      
      public List<Medicine> GetApprovedMedicineList()
      {
         // TODO: implement
         return null;
      }
      
      public List<MedicineIngredient> GetIngredients()
      {
         // TODO: implement
         return null;
      }
      
      public int GetMedicineAmount(Model.Manager.Medicine medicine)
      {
         // TODO: implement
         return 0;
      }
   
      private String Path;
   
   }
}