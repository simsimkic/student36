/***********************************************************************
 * Module:  MedicalRecordRepository.cs
 * Purpose: Definition of the Class Repository.PatientRepository.MedicalRecordRepository
 ***********************************************************************/

using KlinikaKod.Xml;
using Model.Doctor;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.PatientRepository
{
   public class MedicalRecordRepository
   {

      private string medicalRecordsFilename = @"C:\Users\Maja\simsfinalni\projekat\data\medicalRecords.xml";
        // private string appointmentsFilename = @"C:\Users\Lenovo\Desktop\SIMS\projekat\data\appointments.xml";
        private string appointmentsFilename = @"C:\Users\Maja\simsfinalni\projekat\data\appointment.xml";
        private XmlReaderWriter xmlReaderWriter = new XmlReaderWriter();

      public MedicalRecordRepository()
      {
          List<MedicalRecord> mrs = xmlReaderWriter.DeSerializeObject<List<MedicalRecord>>(medicalRecordsFilename);
          if (mrs == null)
          {
              mrs = new List<MedicalRecord>();
              xmlReaderWriter.SerializeObject(mrs, medicalRecordsFilename);
          }
      }

      public Model.Patient.MedicalRecord SetMedicalRecord(Model.Patient.Patient patient)
      {
          MedicalRecord mr = new MedicalRecord();
          mr.Patient = patient;

          List<MedicalRecord> mrs = xmlReaderWriter.DeSerializeObject<List<MedicalRecord>>(medicalRecordsFilename);
          
            if (mrs == null)
            {
                mrs = new List<MedicalRecord>();
                mrs.Add(mr);
            }
            else
            {
                mrs.Add(mr);
            }
          xmlReaderWriter.SerializeObject(mrs, medicalRecordsFilename);

          return mr;
      }


      public Model.Patient.MedicalRecord GetMedicalRecord(String jmbg)
      {
            // TODO: implement
            List<MedicalRecord> mrs = xmlReaderWriter.DeSerializeObject<List<MedicalRecord>>(medicalRecordsFilename);
            MedicalRecord mr = mrs.FirstOrDefault(m => m.Patient.Jmbg == jmbg);
            return mr;
        }
      
      public List<Prescription> GetAllPrescriptions(int patitentID)
      {
         // TODO: implement
         return null;
      }
      
      public List<Allergie> GetAllergies()
      {
         // TODO: implement
         return null;
      }
      
      public List<HospitalTreatment> GetHospitalTreatment()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.MedicalHistory GetMedicalHistory()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.Prescription GetPrescription(String prescriptionID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Doctor.AppointmentReport GetAppointmentReport(String appointmentRepID)
      {
         // TODO: implement
         return null;
      }

        public Model.Doctor.AppointmentReport AddAppointment(Model.Doctor.AppointmentReport appointment, Model.Patient.MedicalRecord medicalRecord)
        {
            List<Appointment> app = xmlReaderWriter.DeSerializeObject<List<Appointment>>(appointmentsFilename);
            List<MedicalRecord> mrs = xmlReaderWriter.DeSerializeObject<List<MedicalRecord>>(medicalRecordsFilename);
            foreach (MedicalRecord item in mrs)
            {
                if (item.Patient.Jmbg == medicalRecord.Patient.Jmbg)
                {
                    if (item.appointmentReports == null)
                    {
                        item.appointmentReports = new List<AppointmentReport>();
                    }
                    item.appointmentReports.Add(appointment);
                }
            }
            app.Add(appointment.appointment);
            xmlReaderWriter.SerializeObject<List<MedicalRecord>>(mrs, medicalRecordsFilename);
            xmlReaderWriter.SerializeObject<List<Appointment>>(app, appointmentsFilename);
            return appointment;
        }


    


    private String Path;
   
   }
}