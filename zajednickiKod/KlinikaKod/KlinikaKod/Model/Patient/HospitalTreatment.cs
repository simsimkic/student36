/***********************************************************************
 * Module:  HospitalTreatment.cs
 * Purpose: Definition of the Class Pacijent.HospitalTreatment
 ***********************************************************************/

using System;

namespace Model.Patient
{
   public class HospitalTreatment
   {
      public MedicalRecord medicalRecord;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public MedicalRecord GetMedicalRecord()
      {
         return medicalRecord;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newMedicalRecord</param>
      public void SetMedicalRecord(MedicalRecord newMedicalRecord)
      {
         if (this.medicalRecord != newMedicalRecord)
         {
            if (this.medicalRecord != null)
            {
               MedicalRecord oldMedicalRecord = this.medicalRecord;
               this.medicalRecord = null;
               oldMedicalRecord.RemoveHospitalTreatment(this);
            }
            if (newMedicalRecord != null)
            {
               this.medicalRecord = newMedicalRecord;
               this.medicalRecord.AddHospitalTreatment(this);
            }
         }
      }
   
      private DateTime dateOfReceipt;
      private DateTime ReleaseDate;
      private String CauseOfHospitalization;
   
   }
}