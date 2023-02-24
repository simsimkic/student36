/***********************************************************************
 * Module:  ZdravstveniKarton.cs
 * Purpose: Definition of the Class ZdravstveniKarton
 ***********************************************************************/

using Model.Doctor;
using System;
using System.Collections.Generic;

namespace Model.Patient
{
   public class MedicalRecord
   {
     
      public List<Allergie> allergies;
      
      /// <pdGenerated>default getter</pdGenerated>
      public List<Allergie> GetAllergies()
      {
            if (allergies == null)
                allergies = new List<Allergie>();
         return allergies;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAllergies(System.Collections.ArrayList newAllergies)
      {
         RemoveAllAllergies();
         foreach (Allergie oAllergie in newAllergies)
            AddAllergies(oAllergie);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAllergies(Allergie newAllergie)
      {
         if (newAllergie == null)
            return;
         if (this.allergies == null)
            this.allergies = new List<Allergie>();
         if (!this.allergies.Contains(newAllergie))
            this.allergies.Add(newAllergie);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAllergies(Allergie oldAllergie)
      {
         if (oldAllergie == null)
            return;
         if (this.allergies != null)
            if (this.allergies.Contains(oldAllergie))
               this.allergies.Remove(oldAllergie);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAllergies()
      {
         if (allergies != null)
            allergies.Clear();
      }
      public System.Collections.ArrayList hospitalTreatment;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetHospitalTreatment()
      {
         if (hospitalTreatment == null)
            hospitalTreatment = new System.Collections.ArrayList();
         return hospitalTreatment;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetHospitalTreatment(System.Collections.ArrayList newHospitalTreatment)
      {
         RemoveAllHospitalTreatment();
         foreach (HospitalTreatment oHospitalTreatment in newHospitalTreatment)
            AddHospitalTreatment(oHospitalTreatment);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddHospitalTreatment(HospitalTreatment newHospitalTreatment)
      {
         if (newHospitalTreatment == null)
            return;
         if (this.hospitalTreatment == null)
            this.hospitalTreatment = new System.Collections.ArrayList();
         if (!this.hospitalTreatment.Contains(newHospitalTreatment))
         {
            this.hospitalTreatment.Add(newHospitalTreatment);
            newHospitalTreatment.SetMedicalRecord(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveHospitalTreatment(HospitalTreatment oldHospitalTreatment)
      {
         if (oldHospitalTreatment == null)
            return;
         if (this.hospitalTreatment != null)
            if (this.hospitalTreatment.Contains(oldHospitalTreatment))
            {
               this.hospitalTreatment.Remove(oldHospitalTreatment);
               oldHospitalTreatment.SetMedicalRecord((MedicalRecord)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllHospitalTreatment()
      {
         if (hospitalTreatment != null)
         {
            System.Collections.ArrayList tmpHospitalTreatment = new System.Collections.ArrayList();
            foreach (HospitalTreatment oldHospitalTreatment in hospitalTreatment)
               tmpHospitalTreatment.Add(oldHospitalTreatment);
            hospitalTreatment.Clear();
            foreach (HospitalTreatment oldHospitalTreatment in tmpHospitalTreatment)
               oldHospitalTreatment.SetMedicalRecord((MedicalRecord)null);
            tmpHospitalTreatment.Clear();
         }
      }
        public Patient Patient;
        public MedicalHistory medicalHistory;
        public Model.Secretary.GuestPatient guestPatient;
        public Prescription[] prescriptions;
        public List<AppointmentReport> appointmentReports;

        private String IdOfRecord;
        private Gender Gender;
        private MaritalStatus MaritalStatus;
        private BloodType BloodType;

      
   }
}