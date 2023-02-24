/***********************************************************************
 * Module:  GuestPatientController.cs
 * Purpose: Definition of the Class Controller.SecretaryController.GuestPatientController
 ***********************************************************************/

using System;

namespace Controller.SecretaryController
{
    public class GuestPatientController
    {
        public Model.Secretary.GuestPatient AddGuestPatient(Model.Secretary.GuestPatient newGuestPatient)
        {
            guestPatientService.AddGuestPatient(newGuestPatient);

            return newGuestPatient;
        }

        public Model.Secretary.GuestPatient ModifyGuestPatient(Model.Secretary.GuestPatient modifiedGuestPatient)
        {
            guestPatientService.ModifyGuestPatient(modifiedGuestPatient);

            return modifiedGuestPatient;
        }

        public Model.Patient.Patient ActivatePatientAccount(Model.Secretary.GuestPatient guestPatient)
        {
            Model.Patient.Patient newFullPatient = guestPatientService.ActivatePatientAccount(guestPatient);

            return newFullPatient;
        }

        public void DeleteGuestPatient(Model.Secretary.GuestPatient guestPatient)
        {
            guestPatientService.DeleteGuestPatient(guestPatient);
        }

        public Service.SecretaryService.GuestPatientService guestPatientService;

        public GuestPatientController()
        {
            this.guestPatientService = new Service.SecretaryService.GuestPatientService();
        }
    }
}