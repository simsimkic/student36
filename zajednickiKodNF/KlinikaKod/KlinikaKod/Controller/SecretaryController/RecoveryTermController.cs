/***********************************************************************
 * Module:  MedicalFavourTermController.cs
 * Purpose: Definition of the Class Controller.SecretaryController.MedicalFavourTermController
 ***********************************************************************/

using System;

namespace Controller.SecretaryController
{
    public class RecoveryTermController
    {
        public Model.Doctor.Recovery CreateRecoveryTerm(Model.Doctor.Recovery recoveryTerm)
        {
            Model.Doctor.Recovery createdRecoveryTerm = recoveryTermService.CreateRecoveryTerm(recoveryTerm);

            return createdRecoveryTerm;
        }

        public Model.Doctor.Recovery ChangeRecoveryTerm(String idOfRecovery)
        {
            Model.Doctor.Recovery changedRecoveryTerm = recoveryTermService.ChangeRecoveryTerm(idOfRecovery);

            return changedRecoveryTerm;
        }

        public void CancelRecoveryTerm(String idOfRecovery)
        {
            recoveryTermService.CancelRecoveryTerm(idOfRecovery);
        }

        public Service.SecretaryService.RecoveryTermService recoveryTermService;

        public RecoveryTermController()
        {
            this.recoveryTermService = new Service.SecretaryService.RecoveryTermService();
        }
    }
}