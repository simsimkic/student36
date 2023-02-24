/***********************************************************************
 * Module:  Employee.cs
 * Purpose: Definition of the Class Manager.Employee
 ***********************************************************************/

using System;
using Model.Doctor;
using Model.Secretary;

namespace Model.Manager
{
   public class Employee
   {
      public void Fire()
      {
         // TODO: implement
      }

      public Secretary.Secretary HireSecretary()
      {
         // TODO: implement
         return null;
      }

      public Model.Doctor.Doctor HireDoctor()
      {
         // TODO: implement
         return null;
      }
   
      public Manager manager;
      public WorkPeriod[] workPeriod;
   
   }
}