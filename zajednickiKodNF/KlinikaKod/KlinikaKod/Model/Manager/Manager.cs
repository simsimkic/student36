/***********************************************************************
 * Module:  Manager.cs
 * Purpose: Definition of the Class Manager.Manager
 ***********************************************************************/

using System;

namespace Model.Manager
{
   public class Manager : Model.User.User
   {
      public System.Collections.ArrayList department;
      
      /// <pdGenerated>default getter</pdGenerated>
      public System.Collections.ArrayList GetDepartment()
      {
         if (department == null)
            department = new System.Collections.ArrayList();
         return department;
      }
      
      /// <pdGenerated>default setter</pdGenerated>
      public void SetDepartment(System.Collections.ArrayList newDepartment)
      {
         RemoveAllDepartment();
         foreach (Department oDepartment in newDepartment)
            AddDepartment(oDepartment);
      }
      
      /// <pdGenerated>default Add</pdGenerated>
      public void AddDepartment(Department newDepartment)
      {
         if (newDepartment == null)
            return;
         if (this.department == null)
            this.department = new System.Collections.ArrayList();
         if (!this.department.Contains(newDepartment))
            this.department.Add(newDepartment);
      }
      
      /// <pdGenerated>default Remove</pdGenerated>
      public void RemoveDepartment(Department oldDepartment)
      {
         if (oldDepartment == null)
            return;
         if (this.department != null)
            if (this.department.Contains(oldDepartment))
               this.department.Remove(oldDepartment);
      }
      
      /// <pdGenerated>default removeAll</pdGenerated>
      public void RemoveAllDepartment()
      {
         if (department != null)
            department.Clear();
      }
      public Employee[] employees;
   
      private int Id;
   
   }
}