/***********************************************************************
 * Module:  Operation.cs
 * Purpose: Definition of the Class Doctor.Operation
 ***********************************************************************/

using System;

namespace Model.Doctor
{
   public class RefferalToOperation : MedicalFavourTerm
   {
      public TypeOfOperation typeOfOperation;
      public DoctorSpecialist doctorSpecialist;
      public AppointmentReport appointmentReport;
      public Emergency emergency;
      public Recovery recovery;
      public KindOfAnesthesia kindOfAnesthesia;
   
      private System.Boolean HospitalStay = false;
      private System.Boolean IsPublished = false;
      private String ReasonOfRefferal;
   
   }
}