/***********************************************************************
 * Module:  GuestPatientController.cs
 * Purpose: Definition of the Class Controller.SecretaryController.GuestPatientController
 ***********************************************************************/

using System;

namespace Controller.SecretaryController
{
   public class GuestPatientController
   {
      public Model.Secretary.GuestPatient AddGuestPatient(Model.Secretary.GuestPatient guestPatient)
      {
         // TODO: implement
         return null;
      }
      
      public Model.Patient.Patient ActivatePatientAccount(Model.Secretary.GuestPatient guestPatient)
      {
         // TODO: implement
         return null;
      }
      
      public void DeleteGuestPatient(long idOfGuestPatient)
      {
         // TODO: implement
      }
   
      public Service.SecretaryService.GuestPatientService guestPatientService;
   
   }
}