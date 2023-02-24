/***********************************************************************
 * Module:  Prescription.cs
 * Purpose: Definition of the Class Doctor.Prescription
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class Prescription
   {
      public Model.Patient.MedicalRecord medicalRecord;
      public Model.Manager.Medicine[] medicines;
   
      private String Name;
      private System.DateTime Date;
      private String IdOfPrescription;
   
   }
}