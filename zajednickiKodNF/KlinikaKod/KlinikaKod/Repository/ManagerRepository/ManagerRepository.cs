/***********************************************************************
 * Module:  ManagerRepository.cs
 * Purpose: Definition of the Class Repository.ManagerRepository.ManagerRepository
 ***********************************************************************/

using KlinikaKod.Xml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.ManagerRepository
{
   public class ManagerRepository
   {
      private String Path;
      private string managerFilename = "managers.xml";
      private XmlReaderWriter xmlReaderWriter = new XmlReaderWriter();

      public Model.Manager.Manager GetManager(String jmbg)
      {
          List<Model.Manager.Manager> managers = xmlReaderWriter.DeSerializeObject<List<Model.Manager.Manager>>(managerFilename);
          return managers.FirstOrDefault(m => m.Jmbg == jmbg);
      }

      public Model.Manager.Manager SetManager(Model.Manager.Manager manager)
      {
          List<Model.Manager.Manager> managers = xmlReaderWriter.DeSerializeObject<List<Model.Manager.Manager>>(managerFilename);
          Model.Manager.Manager m = managers.FirstOrDefault(man => man.Jmbg == manager.Jmbg);
            if (m == null)
            {
              managers.Add(manager);
            }
            else
            {
                // izmeni sve propertije
                // NOTE: ako se menjaju jmbg i sifra, obavezno izmeniti i u fajlu
                m.Jmbg = manager.Jmbg;
                m.Name = manager.Name;
                m.Surname = manager.Surname;
                // TODO: dodati ostale propertije
            }
            xmlReaderWriter.SerializeObject(managers, managerFilename);

            return manager;
        }

    }
}