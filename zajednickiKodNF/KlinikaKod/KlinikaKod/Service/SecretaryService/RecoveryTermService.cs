/***********************************************************************
 * Module:  AppointmentTermService.cs
 * Purpose: Definition of the Class Service.SecretaryService.AppointmentTermService
 ***********************************************************************/

using System;

namespace Service.SecretaryService
{
    public class RecoveryTermService
    {
        public Model.Doctor.Recovery CreateRecoveryTerm(Model.Doctor.Recovery recoveryTerm)
        {
            // TODO: implement
            return null;
        }

        public Model.Doctor.Recovery ChangeRecoveryTerm(String idOfRecovery)
        {
            // TODO: implement
            return null;
        }

        public void CancelRecoveryTerm(String idOfRecovery)
        {
            // TODO: implement
        }

        public Repository.SecretaryRepository.RecoveryTermRepository recoveryTermRepository;

        // Dodao sam kontruktor.
        public RecoveryTermService()
        {
            this.recoveryTermRepository = new Repository.SecretaryRepository.RecoveryTermRepository();
        }
    }
}