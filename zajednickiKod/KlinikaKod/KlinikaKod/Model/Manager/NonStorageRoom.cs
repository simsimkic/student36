/***********************************************************************
 * Module:  NonStorageRoom.cs
 * Purpose: Definition of the Class Model.Manager.NonStorageRoom
 ***********************************************************************/

using System;

namespace Model.Manager
{
   public class NonStorageRoom
   {
      public System.Collections.ArrayList ordination;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetOrdination()
      {
         if (ordination == null)
            ordination = new System.Collections.ArrayList();
         return ordination;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetOrdination(System.Collections.ArrayList newOrdination)
      {
         RemoveAllOrdination();
         foreach (Ordination oOrdination in newOrdination)
            AddOrdination(oOrdination);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddOrdination(Ordination newOrdination)
      {
         if (newOrdination == null)
            return;
         if (this.ordination == null)
            this.ordination = new System.Collections.ArrayList();
         if (!this.ordination.Contains(newOrdination))
            this.ordination.Add(newOrdination);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveOrdination(Ordination oldOrdination)
      {
         if (oldOrdination == null)
            return;
         if (this.ordination != null)
            if (this.ordination.Contains(oldOrdination))
               this.ordination.Remove(oldOrdination);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllOrdination()
      {
         if (ordination != null)
            ordination.Clear();
      }
      public System.Collections.ArrayList operationRoom;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetOperationRoom()
      {
         if (operationRoom == null)
            operationRoom = new System.Collections.ArrayList();
         return operationRoom;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetOperationRoom(System.Collections.ArrayList newOperationRoom)
      {
         RemoveAllOperationRoom();
         foreach (OperationRoom oOperationRoom in newOperationRoom)
            AddOperationRoom(oOperationRoom);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddOperationRoom(OperationRoom newOperationRoom)
      {
         if (newOperationRoom == null)
            return;
         if (this.operationRoom == null)
            this.operationRoom = new System.Collections.ArrayList();
         if (!this.operationRoom.Contains(newOperationRoom))
            this.operationRoom.Add(newOperationRoom);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveOperationRoom(OperationRoom oldOperationRoom)
      {
         if (oldOperationRoom == null)
            return;
         if (this.operationRoom != null)
            if (this.operationRoom.Contains(oldOperationRoom))
               this.operationRoom.Remove(oldOperationRoom);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllOperationRoom()
      {
         if (operationRoom != null)
            operationRoom.Clear();
      }
      public System.Collections.ArrayList recoveryRoom;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRecoveryRoom()
      {
         if (recoveryRoom == null)
            recoveryRoom = new System.Collections.ArrayList();
         return recoveryRoom;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRecoveryRoom(System.Collections.ArrayList newRecoveryRoom)
      {
         RemoveAllRecoveryRoom();
         foreach (RecoveryRoom oRecoveryRoom in newRecoveryRoom)
            AddRecoveryRoom(oRecoveryRoom);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRecoveryRoom(RecoveryRoom newRecoveryRoom)
      {
         if (newRecoveryRoom == null)
            return;
         if (this.recoveryRoom == null)
            this.recoveryRoom = new System.Collections.ArrayList();
         if (!this.recoveryRoom.Contains(newRecoveryRoom))
            this.recoveryRoom.Add(newRecoveryRoom);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRecoveryRoom(RecoveryRoom oldRecoveryRoom)
      {
         if (oldRecoveryRoom == null)
            return;
         if (this.recoveryRoom != null)
            if (this.recoveryRoom.Contains(oldRecoveryRoom))
               this.recoveryRoom.Remove(oldRecoveryRoom);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRecoveryRoom()
      {
         if (recoveryRoom != null)
            recoveryRoom.Clear();
      }
      //public Doctor[] doctor;
   
   }
}