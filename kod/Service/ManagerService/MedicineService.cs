/***********************************************************************
 * Module:  MedicineService.cs
 * Purpose: Definition of the Class Service.ManagerService.MedicineService
 ***********************************************************************/

using Model.Manager;
using System;
using System.Collections.Generic;

namespace Service.ManagerService
{
   public class MedicineService
   {
      public Model.Manager.Medicine AddNewMedicine()
      {
         // TODO: implement
         return null;
      }
      
      public List<MedicineIngredient> AddMedicineIngredients()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.Medicine AddMedicineToStorage(Model.Manager.Medicine medicine, int amount)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.ManagerRepository.MedicineRepository medicineRepository;
   
   }
}