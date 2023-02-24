/***********************************************************************
 * Module:  AppointmentService.cs
 * Purpose: Definition of the Class Service.DoctorService.AppointmentService
 ***********************************************************************/

using Model.Doctor;
using Model.Patient;
using Repository.DoctorRepository;
using System;
using System.Collections.Generic;

namespace Service.DoctorService
{
   public class AppointmentService
   {

        

            public AppointmentService()
            {
                appointmentRepository = new Repository.DoctorRepository.AppointmentRepository();
                medicalRecordRepository = new Repository.PatientRepository.MedicalRecordRepository();

            }
        DoctorRepository doctorRepository = new DoctorRepository();

        public List<Doctor> GetDoctorsByTime(DateTime time)
        {
            return doctorRepository.GetDoctorsByTime(time);
        }

        public List<Appointment> GetDoctorAppointments(string jmbg)
        {
            return appointmentRepository.GetDoctorAppointments(jmbg);
        }

       

            public List<Diagnosis> EstablishDiagnosis()
            {
                // TODO: implement
                return appointmentRepository.GetMostCommonDiagnosis();
            }

            public Model.Patient.MedicalRecord UpdateMR(Model.Patient.MedicalRecord medicalRecord)
            {
                // TODO: implement
                return null;
            }
            public List<Patient> CatchAllPatients()
            {
                // TODO: implement
                return appointmentRepository.GetAllPatients();
            }


            public List<Symptom> EnterSymptoms()
            {
                // TODO: implement
                return appointmentRepository.GetMostCommonSymptoms();

            }

            public List<Allergie> EnterAllergies()
            {
            // TODO: implement
            return appointmentRepository.GetMostCommonAllergies();
            }

            public Model.Doctor.AppointmentReport SaveNewAppointment(Model.Doctor.AppointmentReport appointmentReport, Model.Patient.MedicalRecord medicalRecord)
            {
                // TODO: implement
                return medicalRecordRepository.AddAppointment(appointmentReport, medicalRecord);
            }

            public Model.Patient.MedicalRecord CatchMedicalRecord(string patientID)
            {
                // TODO: implement
                return medicalRecordRepository.GetMedicalRecord(patientID);
            }

            public Repository.DoctorRepository.AppointmentRepository appointmentRepository;
            private Repository.PatientRepository.MedicalRecordRepository medicalRecordRepository;
        }
    }