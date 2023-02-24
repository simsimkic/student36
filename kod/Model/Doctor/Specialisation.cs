/***********************************************************************
 * Module:  Specialisation.cs
 * Purpose: Definition of the Class Doctor.Specialisation
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class Specialisation
   {
      public System.Collections.ArrayList doctor;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDoctor()
      {
         if (doctor == null)
            doctor = new System.Collections.ArrayList();
         return doctor;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDoctor(System.Collections.ArrayList newDoctor)
      {
         RemoveAllDoctor();
         foreach (Doctor oDoctor in newDoctor)
            AddDoctor(oDoctor);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDoctor(Doctor newDoctor)
      {
         if (newDoctor == null)
            return;
         if (this.doctor == null)
            this.doctor = new System.Collections.ArrayList();
         if (!this.doctor.Contains(newDoctor))
         {
            this.doctor.Add(newDoctor);
            newDoctor.SetSpecialisation(this);      
         }
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDoctor(Doctor oldDoctor)
      {
         if (oldDoctor == null)
            return;
         if (this.doctor != null)
            if (this.doctor.Contains(oldDoctor))
            {
               this.doctor.Remove(oldDoctor);
               oldDoctor.SetSpecialisation((Specialisation)null);
            }
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDoctor()
      {
         if (doctor != null)
         {
            System.Collections.ArrayList tmpDoctor = new System.Collections.ArrayList();
            foreach (Doctor oldDoctor in doctor)
               tmpDoctor.Add(oldDoctor);
            doctor.Clear();
            foreach (Doctor oldDoctor in tmpDoctor)
               oldDoctor.SetSpecialisation((Specialisation)null);
            tmpDoctor.Clear();
         }
      }
   
      private String Name;
   
   }
}