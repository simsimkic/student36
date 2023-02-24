/***********************************************************************
 * Module:  Schedule.cs
 * Purpose: Definition of the Class Model.Secretary.Schedule
 ***********************************************************************/

using System;

namespace Model.Secretary
{
   public class Schedule
   {
      public Model.Patient.Appointment[] appointment;
      public Model.Doctor.Recovery[] recovery;
      public Model.Doctor.RefferalToOperation[] refferalToOperation;
   
   }
}