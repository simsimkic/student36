/***********************************************************************
 * Module:  Pacijent.cs
 * Purpose: Definition of the Class Pacijent
 ***********************************************************************/

using System;

namespace Model.Patient
{
   public class Patient : Model.User.User
   {
      public void NotificationReading()
      {
         // TODO: implement
      }
   
      public MedicalRecord medicalRecord;
      public Feedback[] feedback;
      public Survey[] surveys;
      public System.Collections.ArrayList appointments;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetAppointments()
      {
         if (appointments == null)
            appointments = new System.Collections.ArrayList();
         return appointments;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetAppointments(System.Collections.ArrayList newAppointments)
      {
         RemoveAllAppointments();
         foreach (Appointment oAppointment in newAppointments)
            AddAppointments(oAppointment);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddAppointments(Appointment newAppointment)
      {
         if (newAppointment == null)
            return;
         if (this.appointments == null)
            this.appointments = new System.Collections.ArrayList();
         if (!this.appointments.Contains(newAppointment))
         {
            this.appointments.Add(newAppointment);
            newAppointment.SetPatient(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveAppointments(Appointment oldAppointment)
      {
         if (oldAppointment == null)
            return;
         if (this.appointments != null)
            if (this.appointments.Contains(oldAppointment))
            {
               this.appointments.Remove(oldAppointment);
               oldAppointment.SetPatient((Patient)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllAppointments()
      {
         if (appointments != null)
         {
            System.Collections.ArrayList tmpAppointments = new System.Collections.ArrayList();
            foreach (Appointment oldAppointment in appointments)
               tmpAppointments.Add(oldAppointment);
            appointments.Clear();
            foreach (Appointment oldAppointment in tmpAppointments)
               oldAppointment.SetPatient((Patient)null);
            tmpAppointments.Clear();
         }
      }
   
      private String EmergencyCall;
      private int PatientID;
   
   }
}