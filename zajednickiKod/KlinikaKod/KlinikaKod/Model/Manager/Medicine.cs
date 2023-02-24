/***********************************************************************
 * Module:  Medicine.cs
 * Purpose: Definition of the Class Lekar.Medicine
 ***********************************************************************/

using Model.Doctor;
using System;

namespace Model.Manager
{
   public class Medicine
   {
      public MedicineApproval medicineApproval;
      public MedicineIngredient[] medicineIngredients;
   
      private String Name;
      private String Id;
      private int Amount;
      private String PurposeOfMedicine;
      private System.DateTime LastDelivery;
   
   }
}