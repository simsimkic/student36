/***********************************************************************
 * Module:  DoctorRepository.cs
 * Purpose: Definition of the Class Repository.DoctorRepository.DoctorRepository
 ***********************************************************************/

using KlinikaKod.Xml;
using Model.Doctor;
using System;
using System.Collections.Generic;

namespace Repository.DoctorRepository
{
   public class DoctorRepository
   {

        private string doctorsFilename = @"C:\Users\Maja\simsfinalni\projekat\data\doctor.xml";
        private string doctorsFileName = @"C:\Users\Lenovo\Desktop\SIMS\projekat\data\doctors.xml";
        private XmlReaderWriter xmlReaderWriter = new XmlReaderWriter();

        public Model.Manager.WorkPeriod GetWorkingPeriod(System.DateTime beginDate, System.DateTime endDate)
      {
         // TODO: implement
         return null;
      }

        public List<Doctor> GetDoctorsByTime(DateTime time)
        {
            List<Doctor> doctors = new List<Doctor>();
            foreach (var item in xmlReaderWriter.DeSerializeObject<List<Doctor>>(doctorsFilename))
            {
                if (item.WorkPeriod.BeginDate.TimeOfDay <= time.TimeOfDay && item.WorkPeriod.EndDate.TimeOfDay >= time.TimeOfDay)
                    doctors.Add(item);
            }

            return doctors;
        }
      
      public Model.Patient.Appointment GetAllAppointments()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment GetAppointment(Model.Patient.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Appointment SetAppointment(Model.Patient.Appointment appointment)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.WorkPeriod GetWorkingPeriod(System.DateTime date)
      {
         // TODO: implement
         return null;
      }

      public List<Doctor> GetAllDoctors()
      {
          List<Doctor> doctors = xmlReaderWriter.DeSerializeObject<List<Doctor>>(doctorsFileName);
          return doctors;
      }
        private String Path;
   
   }
}