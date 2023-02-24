/***********************************************************************
 * Module:  GuestPatientService.cs
 * Purpose: Definition of the Class Service.SecretaryService.GuestPatientService
 ***********************************************************************/

using System;

namespace Service.SecretaryService
{
   public class GuestPatientService
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
   
      public Repository.SecretaryRepository.GuestPatientRepository guestPatientRepository;
   
   }
}