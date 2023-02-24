/***********************************************************************
 * Module:  MedicineController.cs
 * Purpose: Definition of the Class Controller.DoctorController.MedicineController
 ***********************************************************************/

using Model.Manager;
using System;
using System.Collections.Generic;

namespace Controller.DoctorController
{
   public class MedicineController
   {
      public Model.Manager.Medicine ApproveMedicine(Model.Manager.Medicine medicine)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.Medicine PrescribeMedicine(List<Medicine> medicines)
      {
         // TODO: implement
         return null;
      }
      
      public String SearchMedicineIngredients(Model.Manager.Medicine medicine)
      {
         // TODO: implement
         return null;
      }
   
      public Service.DoctorService.MedicineService medicineService;
   
   }
}