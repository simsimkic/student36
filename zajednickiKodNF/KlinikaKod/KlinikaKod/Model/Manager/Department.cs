/***********************************************************************
 * Module:  Department.cs
 * Purpose: Definition of the Class Model.Manager.Department
 ***********************************************************************/

using System;

namespace Model.Manager
{
   public class Department
   {
      public System.Collections.ArrayList rooms;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetRooms()
      {
         if (rooms == null)
            rooms = new System.Collections.ArrayList();
         return rooms;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetRooms(System.Collections.ArrayList newRooms)
      {
         RemoveAllRooms();
         foreach (Room oRoom in newRooms)
            AddRooms(oRoom);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddRooms(Room newRoom)
      {
         if (newRoom == null)
            return;
         if (this.rooms == null)
            this.rooms = new System.Collections.ArrayList();
         if (!this.rooms.Contains(newRoom))
         {
            this.rooms.Add(newRoom);
            newRoom.SetDepartment(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveRooms(Room oldRoom)
      {
         if (oldRoom == null)
            return;
         if (this.rooms != null)
            if (this.rooms.Contains(oldRoom))
            {
               this.rooms.Remove(oldRoom);
               oldRoom.SetDepartment((Department)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllRooms()
      {
         if (rooms != null)
         {
            System.Collections.ArrayList tmpRooms = new System.Collections.ArrayList();
            foreach (Room oldRoom in rooms)
               tmpRooms.Add(oldRoom);
            rooms.Clear();
            foreach (Room oldRoom in tmpRooms)
               oldRoom.SetDepartment((Department)null);
            tmpRooms.Clear();
         }
      }
   
      private String DepartmentName;
   
   }
}