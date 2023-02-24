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

        public MedicineController()
        {
            medicineService = new Service.DoctorService.MedicineService();
        }

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

        public List<Medicine> CatchAllApprovedMedicines()
        {
            return medicineService.CatchAllApprovedMedicines();
        }

        public List<Medicine> CatchAllMedicines()
        {
            return medicineService.CatchAllMedicines();
        }
        public String SearchMedicineIngredients(Model.Manager.Medicine medicine)
      {
         // TODO: implement
         return null;
      }
   
      public Service.DoctorService.MedicineService medicineService;
   
   }
}