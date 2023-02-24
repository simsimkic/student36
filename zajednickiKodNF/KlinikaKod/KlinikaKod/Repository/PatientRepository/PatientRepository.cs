/***********************************************************************
 * Module:  PatientRepository.cs
 * Purpose: Definition of the Class Repository.PatientRepository.PatientRepository
 ***********************************************************************/

using KlinikaKod.Xml;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.PatientRepository
{
   public class PatientRepository {

        private string patientFilename = @"C:\Users\Lenovo\Desktop\SIMS\projekat\data\patients.xml";
        private XmlReaderWriter xmlReaderWriter = new XmlReaderWriter();

        public Model.Patient.Patient GetPatient(String jmbg)
        {
            List<Model.Patient.Patient> patients = xmlReaderWriter.DeSerializeObject<List<Model.Patient.Patient>>(patientFilename);
            return patients.FirstOrDefault(p => p.Jmbg == jmbg);
        }

        public Model.Patient.Patient SetPatient(Model.Patient.Patient patient)
        {
            List<Model.Patient.Patient> patients = xmlReaderWriter.DeSerializeObject<List<Model.Patient.Patient>>(patientFilename);
            Model.Patient.Patient p = patients.FirstOrDefault(pat => pat.Jmbg == patient.Jmbg);
            if (p == null)
            {
                patients.Add(patient);
            }
            else
            {
                // izmeni sve propertije
                // NOTE: ako se menjaju jmbg i sifra, obavezno izmeniti i u fajlu
                p.Jmbg = patient.Jmbg;
                p.Name = patient.Name;
                p.Surname = patient.Surname;
                p.Password = patient.Password;
                p.Email = patient.Email;
                p.DateOfBirth = patient.DateOfBirth;
                // TODO: dodati ostale propertije
            }
            xmlReaderWriter.SerializeObject(patients, patientFilename);

            return patient;
        }

        public bool RegisterPatient(Model.Patient.Patient patient)
        {
            List<Model.Patient.Patient> patients = xmlReaderWriter.DeSerializeObject<List<Model.Patient.Patient>>(patientFilename);
            Model.Patient.Patient p = patients.FirstOrDefault(pat => pat.Jmbg == patient.Jmbg);
            if (p == null)
            {
                patients.Add(patient);
                xmlReaderWriter.SerializeObject(patients, patientFilename);
                return true;
            }
            else
            {
                return false;
            }

        }


        public Model.Patient.Feedback GetFeedback()
        {
            // TODO: implement
            return null;
        }

        public Model.Patient.Feedback SetFeedback(Model.Patient.Feedback feedback)
        {
            // TODO: implement
            return null;
        }

        public Model.Patient.Survey GetSurvey()
        {
            // TODO: implement
            return null;
        }

        public Model.Patient.Survey SetSurvey(Model.Patient.Survey survey)
        {
            // TODO: implement
            return null;
        }

        public bool SignIn(String jmbg, String password, out Patient p)
        {
            List<Model.Patient.Patient> patients = xmlReaderWriter.DeSerializeObject<List<Model.Patient.Patient>>(patientFilename);
            p = null;
            foreach (var item in patients)
            {
                if (item.Jmbg == jmbg && item.Password == password)
                {
                    p = item;
                    return true;
                }

            }

            return false;
        }

        private String Path;


    }
}