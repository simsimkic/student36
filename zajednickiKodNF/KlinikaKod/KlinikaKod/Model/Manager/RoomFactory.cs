/***********************************************************************
 * Module:  RoomFactory.cs
 * Purpose: Definition of the Interface Model.Manager.RoomFactory
 ***********************************************************************/

using System;

namespace Model.Manager
{
   public interface RoomFactory
   {
      Room CreateRoom();
   }
}