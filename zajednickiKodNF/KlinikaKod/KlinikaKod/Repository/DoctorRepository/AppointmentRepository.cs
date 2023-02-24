/***********************************************************************
 * Module:  AppointmentRepository.cs
 * Purpose: Definition of the Class Repository.DoctorRepository.AppointmentRepository
 ***********************************************************************/

using KlinikaKod.Xml;
using Model.Doctor;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.DoctorRepository
{
   public class AppointmentRepository
   {

        private string medicalRecordsFilename = @"C:\Users\Maja\simsfinalni\projekat\data\medicalRecords.xml";
        private string symptomsFilename = @"C:\Users\Maja\simsfinalni\projekat\data\symptoms.xml";
        private string patientsFilename = @"C:\Users\Maja\simsfinalni\projekat\data\patients.xml";
        private string allergiesFilename = @"C:\Users\Maja\simsfinalni\projekat\data\allergies.xml";
        private string diagnosisFilename = @"C:\Users\Maja\simsfinalni\projekat\data\diagnosis.xml";
        private string appointmentsFilename = @"C:\Users\Maja\simsfinalni\projekat\data\appointments.xml";
        private XmlReaderWriter xmlReaderWriter = new XmlReaderWriter();

        public AppointmentRepository()
        {
            List<Symptom> symptoms = xmlReaderWriter.DeSerializeObject<List<Symptom>>(symptomsFilename);
            if (symptoms == null)
            {
                symptoms = new List<Symptom>();
                symptoms.Add(new Symptom() { Name = "kijavica" });
                symptoms.Add(new Symptom() { Name = "temperatura" });
                symptoms.Add(new Symptom() { Name = "kasalj" });
                symptoms.Add(new Symptom() { Name = "malaksalost" });
                xmlReaderWriter.SerializeObject(symptoms, symptomsFilename);
            }

            List<Allergie> allergies = xmlReaderWriter.DeSerializeObject<List<Allergie>>(allergiesFilename);
            if (allergies == null)
            {
                allergies = new List<Allergie>();
                allergies.Add(new Allergie() {Allergens = "polen", AllergicReaction = AllergicReaction.HeavyBreathing });
                allergies.Add(new Allergie() { Allergens = "kikiriki", AllergicReaction = AllergicReaction.Rash });
                allergies.Add(new Allergie() { Allergens = "prasina", AllergicReaction = AllergicReaction.HeavyBreathing });
                allergies.Add(new Allergie() { Allergens = "grinje", AllergicReaction = AllergicReaction.HeavyBreathing });
                allergies.Add(new Allergie() { Allergens = "jagode", AllergicReaction = AllergicReaction.Itch });
                allergies.Add(new Allergie() { Allergens = "mleko", AllergicReaction = AllergicReaction.Itch });

                xmlReaderWriter.SerializeObject(allergies, allergiesFilename);
            }

            List<Diagnosis> diagnosis = xmlReaderWriter.DeSerializeObject<List<Diagnosis>>(diagnosisFilename);
            if (diagnosis == null)
            {
                diagnosis = new List<Diagnosis>();
                diagnosis.Add(new Diagnosis() { Name = "prehlada" });
                diagnosis.Add(new Diagnosis() { Name = "grip" });
                diagnosis.Add(new Diagnosis() { Name = "upala pluca" });
                diagnosis.Add(new Diagnosis() { Name = "prelom" });
                diagnosis.Add(new Diagnosis() { Name = "upala slepog creva" });
                diagnosis.Add(new Diagnosis() { Name = "virusna infekcija" });

                xmlReaderWriter.SerializeObject(diagnosis, diagnosisFilename);
            }
        }


        public List<Appointment> GetDoctorAppointments(string jmbg)
        {
            List<Appointment> appointments = xmlReaderWriter.DeSerializeObject<List<Appointment>>(appointmentsFilename);

            List<Appointment> retVal = new List<Appointment>();

            foreach (var item in appointments)
            {
                if (item.Doctor.Jmbg == jmbg)
                {
                    retVal.Add(item);
                }
            }

            return retVal;
        }

        public List<Patient> GetAllPatients()
        {
            List<Model.Patient.Patient> patients = xmlReaderWriter.DeSerializeObject<List<Model.Patient.Patient>>(patientsFilename);
            if (patients == null)
            {
                return new List<Patient>();
            }
            return patients;
        }

       

        public Model.Manager.NonStorageRoom GetFreeRooms(Dto.DTOGetFreeRooms dTOGetFreeRooms)
        {
            // TODO: implement
            return null;
        }

      

       

        public List<Symptom> GetMostCommonSymptoms()
        {
            // TODO: implement
            List<Symptom> symptoms = xmlReaderWriter.DeSerializeObject<List<Symptom>>(symptomsFilename);

            return symptoms;
        }

        public List<Diagnosis> GetMostCommonDiagnosis()
        {
            // TODO: implement
            List<Diagnosis> diagnoses = xmlReaderWriter.DeSerializeObject<List<Diagnosis>>(diagnosisFilename);

            return diagnoses;
        }

        public List<Symptom> SetMostCommonSymptoms(Model.Doctor.Symptom symptom)
        {

            // TODO: implement
            Symptom s = new Symptom();
            s.Name = symptom.Name;


            List<Symptom> symptoms = xmlReaderWriter.DeSerializeObject<List<Symptom>>(symptomsFilename);
            symptoms.Add(s);
            xmlReaderWriter.SerializeObject(symptoms, symptomsFilename);

            return symptoms;
        }

        public List<Allergie> GetMostCommonAllergies()
        {
            // TODO: implement
            List<Allergie> allergies = xmlReaderWriter.DeSerializeObject<List<Allergie>>(allergiesFilename);

            return allergies;
        }

        public List<Allergie> SetMostCommonAllergies(Model.Patient.Allergie allergie)
        {

            // TODO: implement
            Allergie a = new Allergie();
            a.Allergens = allergie.Allergens;
            a.AllergicReaction = allergie.AllergicReaction;


            List<Allergie> allergies = xmlReaderWriter.DeSerializeObject<List<Allergie>>(allergiesFilename);
            allergies.Add(a);
            xmlReaderWriter.SerializeObject(allergies, allergiesFilename);

            return allergies;
        }

        public List<Diagnosis> SetMostCommonDiagnosis(Model.Doctor.Diagnosis diagnosis)
        {

            // TODO: implement
            Diagnosis d = new Diagnosis();
            d.Name = diagnosis.Name;

            List<Diagnosis> diagnoses = xmlReaderWriter.DeSerializeObject<List<Diagnosis>>(diagnosisFilename);
            diagnoses.Add(d);
            xmlReaderWriter.SerializeObject(diagnoses, diagnosisFilename);

            return diagnoses;
        }

        public Model.Doctor.AppointmentReport SetAppiontment(Model.Patient.MedicalRecord medicalRecord)
        {
            // TODO: implement
            return null;
        }

       

        private String Path;

    }
}