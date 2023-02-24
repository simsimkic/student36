/***********************************************************************
 * Module:  MedicineApproval.cs
 * Purpose: Definition of the Class Doctor.MedicineApproval
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class MedicineApproval
   {
      public Model.Manager.Medicine medicine;
      public Doctor[] doctors;
   
      private System.Boolean FirstApproval = false;
      private System.Boolean SecondApproval = false;
   
   }
}