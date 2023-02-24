/***********************************************************************
 * Module:  RoomController.cs
 * Purpose: Definition of the Class Controller.ManagerController.RoomController
 ***********************************************************************/

using System;
using System.Collections.Generic;

namespace Controller.ManagerController
{
   public class RoomController
   {
      public Model.Manager.Room ChangeRoomPurpose(String roomID)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.Room RenovateRoom(String roomID, Model.Manager.Renovation renovation)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Manager.Equipment AddEquipmentToRoom(String roomID, Model.Manager.Equipment equipment)
      {
         // TODO: implement
         return null;
      }
      
      public void RemoveEquipmentFromRoom(String roomID, String equipmentID)
      {
         // TODO: implement
      }
      
      public List<Operation> GetOperationRoomSchedule(Model.Manager.OperationRoom operationRoom)
      {
         // TODO: implement
         return null;
      }
   
      public Service.ManagerService.RoomService roomService;
   
   }
}