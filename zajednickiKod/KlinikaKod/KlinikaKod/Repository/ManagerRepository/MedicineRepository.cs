/***********************************************************************
 * Module:  MedicineRepository.cs
 * Purpose: Definition of the Class Repository.ManagerRepository.MedicineRepository
 ***********************************************************************/

using Model.Manager;
using System;
using System.Collections.Generic;

namespace Repository.ManagerRepository
{
   public class MedicineRepository
   {
      public Model.Manager.Medicine GetMedicine(String medicineID)
      {
         // TODO: implement
         return null;
      }
      
      public List<MedicineIngredient> GetIngredientsList(String medicineID)
      {
         // TODO: implement
         return null;
      }
      
      public List<Medicine> GetMedicineList()
      {
         // TODO: implement
         return null;
      }
      
      public int GetMedicineAmountInStorage(String medicineID)
      {
         // TODO: implement
         return 0;
      }
   
      private String Path;
   
   }
}