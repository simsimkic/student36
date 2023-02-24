/***********************************************************************
 * Module:  MedicineController.cs
 * Purpose: Definition of the Class Controller.ManagerController.MedicineController
 ***********************************************************************/

using Model.Manager;
using System;
using System.Collections.Generic;

namespace Controller.ManagerController
{
   public class MedicineController
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
   
      public Service.ManagerService.MedicineService medicineService;
   
   }
}