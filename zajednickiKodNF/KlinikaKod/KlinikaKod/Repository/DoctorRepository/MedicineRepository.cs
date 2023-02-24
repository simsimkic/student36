/***********************************************************************
 * Module:  MedicineRepository.cs
 * Purpose: Definition of the Class Repository.DoctorRepository.MedicineRepository
 ***********************************************************************/

using KlinikaKod.Xml;
using Model.Manager;
using System;
using System.Collections.Generic;

namespace Repository.DoctorRepository
{
   public class MedicineRepository
   {
        private string medicalRecordsFilename = @"C:\Users\Maja\simsfinalni\projekat\data\medicalRecords.xml";
        private string patientsFilename = @"C:\Users\Maja\simsfinalni\projekat\data\patients.xml";
        private string medicinesFilename = @"C:\Users\Maja\simsfinalni\projekat\data\medicines.xml";
        private XmlReaderWriter xmlReaderWriter = new XmlReaderWriter();

        public MedicineRepository()
        {
            List<Medicine> medicines = xmlReaderWriter.DeSerializeObject<List<Medicine>>(medicinesFilename);
            
            if (medicines == null)
            {
                medicines = new List<Medicine>();
                medicines.Add(new Medicine() { Name = "brufen" });
                medicines.Add(new Medicine() { Name = "amoksicilin" });
                medicines.Add(new Medicine() { Name = "febricet" });
                medicines.Add(new Medicine() { Name = "andol" });
                medicines.Add(new Medicine() { Name = "ranisan" });
                xmlReaderWriter.SerializeObject(medicines, medicinesFilename);
            }
        }

        public List<Medicine> GetMedicineList()
      {
            // TODO: implement
            List<Model.Manager.Medicine> medicines = xmlReaderWriter.DeSerializeObject<List<Model.Manager.Medicine>>(medicinesFilename);
            if (medicines == null)
            {
                return new List<Medicine>();
            }
            return medicines;
        }

        public List<Medicine> SetApprovedMedicineList(Model.Manager.Medicine medicine)
        {

            // TODO: implement
            Medicine m = new Medicine();
            m.Name = medicine.Name;


            List<Medicine> medicines = xmlReaderWriter.DeSerializeObject<List<Medicine>>(medicinesFilename);
            medicines.Add(m);
            xmlReaderWriter.SerializeObject(medicines, medicinesFilename);

            return medicines;
        }

        public List<Medicine> GetApprovedMedicineList()
      {
            // TODO: implement
            List<Model.Manager.Medicine> medicines = xmlReaderWriter.DeSerializeObject<List<Model.Manager.Medicine>>(medicinesFilename);
            if (medicines == null)
            {
                return new List<Medicine>();
            }
            return medicines;
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