/***********************************************************************
 * Module:  AppointmentController.cs
 * Purpose: Definition of the Class Controller.DoctorController.AppointmentController
 ***********************************************************************/

using Model.Doctor;
using Model.Patient;
using System;
using System.Collections.Generic;

namespace Controller.DoctorController
{
   public class AppointmentController
   {
        public AppointmentController()
        {
            appointmentService = new Service.DoctorService.AppointmentService();
        }

        public Model.Doctor.Prescription WritePrescription(Model.Doctor.Prescription prescription)
        {
            // TODO: implement
            return null;
        }

        public List<Appointment> GetDoctorAppointments(string jmbg)
        {
            return appointmentService.GetDoctorAppointments(jmbg);
        }

        public List<Patient> CatchAllPatients()
        {
            // TODO: implement
            return appointmentService.CatchAllPatients();
        }

        public List<Diagnosis> EstablishDiagnosis()
        {
            // TODO: implement
            return appointmentService.EstablishDiagnosis();
        }

        public Model.Patient.MedicalRecord UpdateRecord(Model.Patient.MedicalRecord medicalRecord)
        {
            // TODO: implement
            return null;
        }

        public List<Symptom> EnterSymptoms()
        {
            // TODO: implement
            return appointmentService.EnterSymptoms();
        }

        public List<Allergie> EnterAllergies()
        {
            // TODO: implement
            return appointmentService.EnterAllergies();
        }

        public Model.Doctor.AppointmentReport SaveNewAppointment(Model.Doctor.AppointmentReport appointmentReport, Model.Patient.MedicalRecord medicalRecord)
        {
            // TODO: implement
            return appointmentService.SaveNewAppointment(appointmentReport, medicalRecord);
        }

        public Model.Patient.MedicalRecord CatchMedicalRecord(string patientID)
        {
            // TODO: implement
            return appointmentService.CatchMedicalRecord(patientID);
        }

        public Service.DoctorService.AppointmentService appointmentService;

    }
}