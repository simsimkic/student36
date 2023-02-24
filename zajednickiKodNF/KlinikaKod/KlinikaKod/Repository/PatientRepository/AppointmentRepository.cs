/***********************************************************************
 * Module:  AppointmentRepository.cs
 * Purpose: Definition of the Class Repository.PatientRepository.AppointmentRepository
 ***********************************************************************/

using KlinikaKod.Xml;
using Model.Patient;
using System;
using System.Collections.Generic;

namespace Repository.PatientRepository
{
   public class AppointmentRepository
   {

        private string appointmentsFilename = @"C:\Users\Lenovo\Desktop\SIMS\projekat\data\appointments.xml";
        private string patientsFilename = @"C:\Users\Lenovo\Desktop\SIMS\new\projekat\data\patients.xml";
        private XmlReaderWriter xmlReaderWriter = new XmlReaderWriter();

        public List<Appointment> GetAppointment(String jmbg)
        {
            List<Appointment> my = new List<Appointment>();
            foreach (var item in xmlReaderWriter.DeSerializeObject<List<Model.Patient.Appointment>>(appointmentsFilename))
            {
                if (item.Patient.Jmbg == jmbg)
                    my.Add(item);
            }
            return my;
        }

        public Model.Patient.Appointment SetAppointment(Model.Patient.Appointment appointment)
        {

            List<Model.Patient.Appointment> appointments = xmlReaderWriter.DeSerializeObject<List<Model.Patient.Appointment>>(appointmentsFilename);
            if (appointments == null)
            {
                appointments = new List<Appointment>();
                appointments.Add(appointment);
            }
            else
            {
                appointments.Add(appointment);
            }

            xmlReaderWriter.SerializeObject(appointments, appointmentsFilename);

            return appointment;
        }


        public List<Appointment> GetAllAppointments() //BEZ PARAMETARA, PROMENI  U SIMSU
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                appointments = xmlReaderWriter.DeSerializeObject<List<Model.Patient.Appointment>>(appointmentsFilename);
            }
            catch (Exception e)
            {
            }

            return appointments;
        }


        public Model.Patient.Appointment GetAvailableTermByDate(DateTime beginDate, DateTime endDate)
        {
            // TODO: implement
            return null;
        }

        public Model.Patient.Appointment GetAvailableTerm(Model.Doctor.Doctor doctor, DateTime beginDate, DateTime endDate)
        {
            // TODO: implement
            return null;
        }

        public Model.Patient.Appointment GetAvailableTermByDoctor(Model.Doctor.Doctor doctor)
        {
            // TODO: implement
            return null;
        }


        private String Path;

    }
}