/***********************************************************************
 * Module:  GuestPatientService.cs
 * Purpose: Definition of the Class Service.SecretaryService.GuestPatientService
 ***********************************************************************/

using System;

namespace Service.SecretaryService
{
    public class GuestPatientService
    {
        public Model.Secretary.GuestPatient AddGuestPatient(Model.Secretary.GuestPatient newGuestPatient)
        {
            guestPatientRepository.AddGuestPatient(newGuestPatient);

            return newGuestPatient;
        }

        // Dodao sam radnju za promenu podataka gostujuceg pacijenta.
        public Model.Secretary.GuestPatient ModifyGuestPatient(Model.Secretary.GuestPatient modifiedGuestPatient)
        {
            guestPatientRepository.ModifyGuestPatient(modifiedGuestPatient);

            return modifiedGuestPatient;
        }

        public Model.Patient.Patient ActivatePatientAccount(Model.Secretary.GuestPatient guestPatient)
        {
            // TODO: implement
            return null;
        }

        public void DeleteGuestPatient(Model.Secretary.GuestPatient guestPatient)
        {
            guestPatientRepository.DeleteGuestPatient(guestPatient);
        }

        public Repository.SecretaryRepository.GuestPatientRepository guestPatientRepository;

        // Dodao sam kontruktor.
        public GuestPatientService()
        {
            this.guestPatientRepository = new Repository.SecretaryRepository.GuestPatientRepository();
        }
    }
}