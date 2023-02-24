/***********************************************************************
 * Module:  EmployeeRepository.cs
 * Purpose: Definition of the Class Repository.ManagerRepository.EmployeeRepository
 ***********************************************************************/

using KlinikaKod.Xml;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.ManagerRepository
{
   public class EmployeeRepository
   {
      public Model.Manager.Employee GetAllEmployees()
      {
         // TODO: implement
         return null;
      }


       private string secretaryFilename = "D:\\Ispiti\\SIMS\\GitLab\\projekat\\data\\secretaries.xml";
       private string doctorFilename = "D:\\Ispiti\\SIMS\\GitLab\\projekat\\data\\doctors.xml";
       private XmlReaderWriter xmlReaderWriter = new XmlReaderWriter();
        
       public Model.Secretary.Secretary GetSecretary(int secretaryID)
        {
            List<Model.Secretary.Secretary> secretaries = xmlReaderWriter.DeSerializeObject<List<Model.Secretary.Secretary>>(SecretaryFilename);
            return secretaries.FirstOrDefault(s => s.SecretaryID == secretaryID);
       }

       public Model.Secretary.Secretary SetSecretary(Model.Secretary.Secretary secretary)
       {
            List<Model.Secretary.Secretary> secretaries = xmlReaderWriter.DeSerializeObject<List<Model.Secretary.Secretary>>(SecretaryFilename);
            Model.Secretary.Secretary s = secretaries.FirstOrDefault(sec => sec.Jmbg == secretary.Jmbg);
            if (s == null)
            {
                secretaries.Add(secretary);
            }
            else
            {
                // izmeni sve propertije
                // NOTE: ako se menjaju jmbg i sifra, obavezno izmeniti i u fajlu
                s.Jmbg = secretary.Jmbg;
                s.Name = secretary.Name;
                s.Surname = secretary.Surname;
                // TODO: dodati ostale propertije
            }
            xmlReaderWriter.SerializeObject(secretaries, SecretaryFilename);

            return secretary;
        }

        public Model.Doctor.Doctor GetDoctor(int doctorID)
        {
            List<Model.Doctor.Doctor> doctors = xmlReaderWriter.DeSerializeObject<List<Model.Doctor.Doctor>>(doctorFilename);
            return doctors.FirstOrDefault(d => d.DoctorID == doctorID);
        }

        public Model.Doctor.Doctor SetDoctor(Model.Doctor.Doctor doctor)
        {
            List<Model.Doctor.Doctor> doctors = xmlReaderWriter.DeSerializeObject<List<Model.Doctor.Doctor>>(doctorFilename);
            Model.Doctor.Doctor d = doctors.FirstOrDefault(doc => doc.Jmbg == doctor.Jmbg);
            if (d == null)
            {
                doctors.Add(doctor);
            }
            else
            {
                // izmeni sve propertije
                // NOTE: ako se menjaju jmbg i sifra, obavezno izmeniti i u fajlu
                d.Jmbg = doctor.Jmbg;
                d.Name = doctor.Name;
                d.Surname = doctor.Surname;
                // TODO: dodati ostale propertije
            }
            xmlReaderWriter.SerializeObject(doctors, doctorFilename);

            return doctor;
        }

        public Model.Manager.WorkPeriod GetSecretaryWorkSchedule(int secretaryID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.WorkPeriod GetDoctorWorkSchedule(int doctorID)
      {
         // TODO: implement
         return null;
      }
   
      private String Path;

        public string SecretaryFilename { get => secretaryFilename; set => secretaryFilename = value; }
    }
}