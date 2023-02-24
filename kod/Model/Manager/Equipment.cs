/***********************************************************************
 * Module:  Oprema.cs
 * Purpose: Definition of the Class Sekretar.Oprema
 ***********************************************************************/

using System;

namespace Model.Manager
{
   public class Equipment
   {
      public Room room;
      public TypeOfEquipment typeOfEquipment;
   
      private System.Boolean InStorage = true;
      private System.Boolean InFunction = true;
      private int Amount;
   
   }
}