/***********************************************************************
 * Module:  Secretary.cs
 * Purpose: Definition of the Class Sekretar.Secretary
 ***********************************************************************/

using System;

namespace Model.Secretary
{
   public class Secretary : Model.User.User
   {
      public Model.Manager.WorkPeriod workPeriod;
      public System.Collections.ArrayList patient;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetPatient()
      {
         if (patient == null)
            patient = new System.Collections.ArrayList();
         return patient;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetPatient(System.Collections.ArrayList newPatient)
      {
         RemoveAllPatient();
         foreach (Model.Patient.Patient oPatient in newPatient)
            AddPatient(oPatient);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddPatient(Model.Patient.Patient newPatient)
      {
         if (newPatient == null)
            return;
         if (this.patient == null)
            this.patient = new System.Collections.ArrayList();
         if (!this.patient.Contains(newPatient))
            this.patient.Add(newPatient);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemovePatient(Model.Patient.Patient oldPatient)
      {
         if (oldPatient == null)
            return;
         if (this.patient != null)
            if (this.patient.Contains(oldPatient))
               this.patient.Remove(oldPatient);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllPatient()
      {
         if (patient != null)
            patient.Clear();
      }
      public Schedule schedule;
   
      private int SecretaryID;
   
   }
}