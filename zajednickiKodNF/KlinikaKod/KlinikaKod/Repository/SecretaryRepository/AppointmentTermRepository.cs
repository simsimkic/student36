/***********************************************************************
 * Module:  MedicalFavourTermRepository.cs
 * Purpose: Definition of the Class Repository.SecretaryRepository.MedicalFavourTermRepository
 ***********************************************************************/

using KlinikaKod.Xml;
using Model.Patient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Repository.SecretaryRepository
{
   public class AppointmentTermRepository
   {
       private string doctorsFilename = 
@"D:\Specifikacija_i_modeliranje_softvera\Master_grana_28_jun\projekat\data\doctors.xml";
       private string patientsFilename = 
@"D:\Specifikacija_i_modeliranje_softvera\Master_grana_28_jun\projekat\data\patients.xml";
       private string appointmentTermsFilename = 
@"D:\Specifikacija_i_modeliranje_softvera\Master_grana_28_jun\projekat\data\appointmentTerms.xml";
       
       private XmlReaderWriter xmlReaderWriter = new XmlReaderWriter();

       public AppointmentTermRepository()
       {
           List<Model.Patient.Appointment> appointmentTerms = 
               xmlReaderWriter.DeSerializeObject<List<Model.Patient.Appointment>>(appointmentTermsFilename);

           List<Model.Doctor.Doctor> doctors = 
               xmlReaderWriter.DeSerializeObject<List<Model.Doctor.Doctor>>(doctorsFilename);

           List<Model.Patient.Patient> patients = 
               xmlReaderWriter.DeSerializeObject<List<Model.Patient.Patient>>(patientsFilename);

           if (appointmentTerms == null)
           {
               appointmentTerms = new List<Model.Patient.Appointment>();

               Model.Patient.Appointment appointment1 = new Model.Patient.Appointment();

               if (doctors.Count > 0)
               {
                   appointment1.doctor = doctors[0];
               }
               else
               {
                   appointment1.doctor = null;
               }

               if (patients.Count > 0)
               {
                   appointment1.SetPatient(patients[0]);
               }
               else
               {
                   appointment1.SetPatient(null);
               }

               appointment1.AppointmentID = 999111;

               appointment1.appointmentReport = null;

               appointment1.BeginDate = DateTime.ParseExact
                   ("30.06.2020. 8:00", "dd.MM.yyyy. hh:mm", CultureInfo.InvariantCulture);

               appointment1.EndDate = DateTime.ParseExact
                   ("30.06.2020. 8:30", "dd.MM.yyyy. hh:mm", CultureInfo.InvariantCulture);

               appointmentTerms.Add(appointment1);

               xmlReaderWriter.SerializeObject(appointmentTerms, appointmentTermsFilename);
           }
       }

      public List<Model.Patient.Appointment> GetAllAppointments()
      {
          List<Model.Patient.Appointment> appointments = 
              xmlReaderWriter.DeSerializeObject<List<Model.Patient.Appointment>>(appointmentTermsFilename);

          if (appointments == null)
          {
              return new List<Model.Patient.Appointment>();
          }

          return appointments;
      }
      
      public List<Model.Patient.Appointment> GetAppointments(DateTime beginTimePoint, DateTime endTimePoint)
      {
          List<Model.Patient.Appointment> appointments =
              xmlReaderWriter.DeSerializeObject<List<Model.Patient.Appointment>>(appointmentTermsFilename);

          if (appointments == null)
          {
              return new List<Model.Patient.Appointment>();
          }

          List<Model.Patient.Appointment> corespondentAppointments = new List<Model.Patient.Appointment>();

          for (int i = 0; i < appointments.Count; i++)
          {
              if ((appointments[i].BeginDate.CompareTo(beginTimePoint) >= 0) && 
                  (appointments[i].EndDate.CompareTo(endTimePoint) <= 0))
              {
                  corespondentAppointments.Add(appointments[i]);
              }
          }

          return corespondentAppointments;
      }
      
      public List<Model.Patient.Appointment> GetAppointments(Model.Patient.Patient patient)
      {
          if (patient.appointments == null)
          {
              return new List<Model.Patient.Appointment>();
          }

          List<Model.Patient.Appointment> corespondentAppointments = new List<Model.Patient.Appointment>();
          ArrayList patientAppointments = (ArrayList) patient.appointments;

          for (int i = 0; i < patient.appointments.Count; i++)
          {
              corespondentAppointments.Add((Model.Patient.Appointment) patientAppointments[i]);
          }

          return corespondentAppointments;
      }
      
      public List<Model.Patient.Appointment> GetAppointments(Model.Doctor.Doctor doctor)
      {
          List<Model.Patient.Appointment> appointments =
              xmlReaderWriter.DeSerializeObject<List<Model.Patient.Appointment>>(appointmentTermsFilename);

          if (appointments == null)
          {
              return new List<Model.Patient.Appointment>();
          }

          List<Model.Patient.Appointment> corespondentAppointments = new List<Model.Patient.Appointment>();

          for (int i = 0; i < appointments.Count; i++)
          {
              if (appointments[i].doctor == doctor)
              {
                  corespondentAppointments.Add(appointments[i]);
              }
          }

          return corespondentAppointments;
      }
      
      public List<Model.Patient.Appointment> GetAppointments(Model.Doctor.DoctorSpecialist doctorSpecialist)
      {
          List<Model.Patient.Appointment> appointments =
    xmlReaderWriter.DeSerializeObject<List<Model.Patient.Appointment>>(appointmentTermsFilename);

          if (appointments == null)
          {
              return new List<Model.Patient.Appointment>();
          }

          List<Model.Patient.Appointment> corespondentAppointments = new List<Model.Patient.Appointment>();

          for (int i = 0; i < appointments.Count; i++)
          {
              if (appointments[i].doctor == doctorSpecialist)
              {
                  corespondentAppointments.Add(appointments[i]);
              }
          }

          return corespondentAppointments;
      }
      
      public Model.Patient.Appointment GetAppointment(String id)
      {
          List<Model.Patient.Appointment> appointments =
    xmlReaderWriter.DeSerializeObject<List<Model.Patient.Appointment>>(appointmentTermsFilename);

          if (appointments == null)
          {
              return null;
          }

          Model.Patient.Appointment returnAppointment = null;

          for (int i = 0; i < appointments.Count; i++)
          {
              if (appointments[i].AppointmentID.ToString().Equals(id) == true)
              {
                  returnAppointment = appointments[i];
                  break;
              }
          }

          return returnAppointment;
      }

      public Model.Patient.Appointment CreateAppointment(Model.Patient.Appointment newAppointment)
      {
          List<Model.Patient.Appointment> allAppointments = this.GetAllAppointments();

          allAppointments.Add(newAppointment);

          xmlReaderWriter.SerializeObject<List<Model.Patient.Appointment>>(allAppointments, appointmentTermsFilename);

          return newAppointment;
      }
      
      public Model.Patient.Appointment ModifyAppointment(Model.Patient.Appointment appointment)
      {
          List<Model.Patient.Appointment> appointments = 
              xmlReaderWriter.DeSerializeObject<List<Model.Patient.Appointment>>(appointmentTermsFilename);

          Model.Patient.Appointment appointmentToBeModified = this.GetAppointment(appointment.AppointmentID.ToString());

          appointmentToBeModified.doctor = appointment.doctor;
          appointmentToBeModified.Patient = appointment.Patient;
          appointmentToBeModified.appointmentReport = appointment.appointmentReport;
          appointmentToBeModified.BeginDate = appointment.BeginDate;
          appointmentToBeModified.EndDate = appointment.endDate;

          xmlReaderWriter.SerializeObject(appointments, appointmentTermsFilename);

          return appointmentToBeModified;
      }
      
      public void DeleteAppointment(String id)
      {
          List<Model.Patient.Appointment> appointments =
    xmlReaderWriter.DeSerializeObject<List<Model.Patient.Appointment>>(appointmentTermsFilename);

          Model.Patient.Appointment appointmentToBeDeleted = this.GetAppointment(id);

          appointments.Remove(appointmentToBeDeleted);

          xmlReaderWriter.SerializeObject(appointments, appointmentTermsFilename);
      }
   
      private String Path;
   
   }
}