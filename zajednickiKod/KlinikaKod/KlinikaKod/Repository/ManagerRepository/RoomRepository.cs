/***********************************************************************
 * Module:  RoomRepository.cs
 * Purpose: Definition of the Class Repository.ManagerRepository.RoomRepository
 ***********************************************************************/

using Model.Manager;
using System;
using System.Collections.Generic;

namespace Repository.ManagerRepository
{
   public class RoomRepository
   {
      public Model.Manager.Room GetRoom(String roomID)
      {
         // TODO: implement
         return null;
      }
      
      public List<Room> GetAllRooms()
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.Department GetDepartment(String departmentName)
      {
         // TODO: implement
         return null;
      }
      
      public List<Department> GetAllDepartments()
      {
         // TODO: implement
         return null;
      }
      
      public List<Renovation> GetRoomsInRenovation()
      {
         // TODO: implement
         return null;
      }
      
      public List<Equipment> GetEquipmentList()
      {
         // TODO: implement
         return null;
      }
      
      public List<Equipment> GetEquipmentInRoom(String roomID)
      {
         // TODO: implement
         return null;
      }
   
      private String Path;
   
   }
}