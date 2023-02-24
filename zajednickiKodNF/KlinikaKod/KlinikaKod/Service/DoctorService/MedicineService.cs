/***********************************************************************
 * Module:  MedicineService.cs
 * Purpose: Definition of the Class Service.DoctorService.MedicineService
 ***********************************************************************/

using Model.Manager;
using System;
using System.Collections.Generic;

namespace Service.DoctorService
{
   public class MedicineService
   {


        public MedicineService()
        {
           
            medicineRepository = new Repository.DoctorRepository.MedicineRepository();

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
            return medicineRepository.GetApprovedMedicineList();
        }

        public List<Medicine> CatchAllMedicines()
        {
            return medicineRepository.GetMedicineList();
        }


        public String SearchMedicineIngredients(Model.Manager.Medicine medicine)
      {
         // TODO: implement
         return null;
      }
   
      public Repository.DoctorRepository.MedicineRepository medicineRepository;
   
   }
}