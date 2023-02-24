/***********************************************************************
 * Module:  Prescription.cs
 * Purpose: Definition of the Class Doctor.Prescription
 ***********************************************************************/

using Model.Manager;
using System;
using System.Collections.Generic;

namespace Model.Doctor
{
   public class Prescription
   {
      public Model.Patient.MedicalRecord medicalRecord;
      public List<Medicine> medicines;
   
      private String Name;
      private System.DateTime Date;
      private String IdOfPrescription;

        public Prescription()
        {
            medicines = new List<Medicine>();
        }
   
   }
}