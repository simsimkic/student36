/***********************************************************************
 * Module:  OperationTermController.cs
 * Purpose: Definition of the Class Controller.SecretaryController.OperationTermController
 ***********************************************************************/

using Controller.ManagerController;
using System;
using System.Collections.Generic;

namespace Controller.SecretaryController
{
    public class OperationTermController
    {
        public Model.Doctor.RefferalToOperation CreateOperationTerm(Model.Doctor.RefferalToOperation operationTerm)
        {
            Model.Doctor.RefferalToOperation createdOperationTerm = operationTermService.CreateOperationTerm(operationTerm);

            return createdOperationTerm;
        }

        public Model.Doctor.RefferalToOperation ChangeOperationTerm(String idOfOperation)
        {
            Model.Doctor.RefferalToOperation changedOperationTerm = operationTermService.ChangeOperationTerm(idOfOperation);

            return changedOperationTerm;
        }

        public void CancelOperationTerm(String idOfOperation)
        {
            operationTermService.CancelOperationTerm(idOfOperation);
        }

        public void SetAsUrgent(Model.Doctor.RefferalToOperation operation)
        {
            operationTermService.SetAsUrgent(operation);
        }

        public List<Model.Doctor.RefferalToOperation> GetOperationSchedule(Model.Doctor.DoctorSpecialist doctor)
        {
            List<Model.Doctor.RefferalToOperation> doctorOperationSchedule = operationTermService.GetOperationSchedule(doctor);

            return doctorOperationSchedule;
        }

        public List<Model.Doctor.RefferalToOperation> GetOperationRoomSchedule(Model.Manager.OperationRoom operationRoom)
        {
            List<Model.Doctor.RefferalToOperation> roomOperationSchedule =
                operationTermService.GetOperationRoomSchedule(operationRoom);

            return roomOperationSchedule;
        }

        public Service.SecretaryService.OperationTermService operationTermService;

        public OperationTermController()
        {
            this.operationTermService = new Service.SecretaryService.OperationTermService();
        }
    }
}