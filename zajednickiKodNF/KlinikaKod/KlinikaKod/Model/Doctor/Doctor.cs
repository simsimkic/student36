/***********************************************************************
 * Module:  Doctor.cs
 * Purpose: Definition of the Class Doctor.Doctor
 ***********************************************************************/

using System;

namespace Model.Doctor
{
    [Serializable]
    public class Doctor : Model.User.User
   {
      public Term[] term;
      public System.Collections.ArrayList nonStorageRoom;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetNonStorageRoom()
      {
         if (nonStorageRoom == null)
            nonStorageRoom = new System.Collections.ArrayList();
         return nonStorageRoom;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetNonStorageRoom(System.Collections.ArrayList newNonStorageRoom)
      {
         RemoveAllNonStorageRoom();
         foreach (Model.Manager.NonStorageRoom oNonStorageRoom in newNonStorageRoom)
            AddNonStorageRoom(oNonStorageRoom);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddNonStorageRoom(Model.Manager.NonStorageRoom newNonStorageRoom)
      {
         if (newNonStorageRoom == null)
            return;
         if (this.nonStorageRoom == null)
            this.nonStorageRoom = new System.Collections.ArrayList();
         if (!this.nonStorageRoom.Contains(newNonStorageRoom))
            this.nonStorageRoom.Add(newNonStorageRoom);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveNonStorageRoom(Model.Manager.NonStorageRoom oldNonStorageRoom)
      {
         if (oldNonStorageRoom == null)
            return;
         if (this.nonStorageRoom != null)
            if (this.nonStorageRoom.Contains(oldNonStorageRoom))
               this.nonStorageRoom.Remove(oldNonStorageRoom);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllNonStorageRoom()
      {
         if (nonStorageRoom != null)
            nonStorageRoom.Clear();
      }
        public Model.Manager.WorkPeriod WorkPeriod;
        public System.Collections.ArrayList medicineApprovals;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetMedicineApprovals()
      {
         if (medicineApprovals == null)
            medicineApprovals = new System.Collections.ArrayList();
         return medicineApprovals;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetMedicineApprovals(System.Collections.ArrayList newMedicineApprovals)
      {
         RemoveAllMedicineApprovals();
         foreach (MedicineApproval oMedicineApproval in newMedicineApprovals)
            AddMedicineApprovals(oMedicineApproval);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddMedicineApprovals(MedicineApproval newMedicineApproval)
      {
         if (newMedicineApproval == null)
            return;
         if (this.medicineApprovals == null)
            this.medicineApprovals = new System.Collections.ArrayList();
         if (!this.medicineApprovals.Contains(newMedicineApproval))
            this.medicineApprovals.Add(newMedicineApproval);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveMedicineApprovals(MedicineApproval oldMedicineApproval)
      {
         if (oldMedicineApproval == null)
            return;
         if (this.medicineApprovals != null)
            if (this.medicineApprovals.Contains(oldMedicineApproval))
               this.medicineApprovals.Remove(oldMedicineApproval);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllMedicineApprovals()
      {
         if (medicineApprovals != null)
            medicineApprovals.Clear();
      }
      public AppointmentReport appointmentReport;
      public Model.Patient.Appointment appointment;
      public Specialisation specialisation;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public Specialisation GetSpecialisation()
      {
         return specialisation;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newSpecialisation</param>
      public void SetSpecialisation(Specialisation newSpecialisation)
      {
         if (this.specialisation != newSpecialisation)
         {
            if (this.specialisation != null)
            {
               Specialisation oldSpecialisation = this.specialisation;
               this.specialisation = null;
               oldSpecialisation.RemoveDoctor(this);
            }
            if (newSpecialisation != null)
            {
               this.specialisation = newSpecialisation;
               this.specialisation.AddDoctor(this);
            }
         }
      }
   
      public int DoctorID;
   
   }
}