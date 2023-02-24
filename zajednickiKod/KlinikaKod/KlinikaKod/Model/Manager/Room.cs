/***********************************************************************
 * Module:  Prostor.cs
 * Purpose: Definition of the Class Sekretar.Prostor
 ***********************************************************************/

using System;

namespace Model.Manager
{
   public abstract class Room
   {
      public Department department;
      
      /// <pdGenerated>default parent getter</pdGenerated>
      public Department GetDepartment()
      {
         return department;
      }
      
      /// <pdGenerated>default parent setter</pdGenerated>
      /// <param>newDepartment</param>
      public void SetDepartment(Department newDepartment)
      {
         if (this.department != newDepartment)
         {
            if (this.department != null)
            {
               Department oldDepartment = this.department;
               this.department = null;
               oldDepartment.RemoveRooms(this);
            }
            if (newDepartment != null)
            {
               this.department = newDepartment;
               this.department.AddRooms(this);
            }
         }
      }
      public Equipment[] equipmentInRoom;
      public Renovation renovation;
   
      protected String RoomID;
      protected double SquareArea;
      protected System.Boolean Usable = false;
      protected String Floor;
   
   }
}