using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.SecretaryService
{
    public class OperationTermService
    {
        public Model.Doctor.RefferalToOperation CreateOperationTerm(Model.Doctor.RefferalToOperation operationTerm)
        {
            // TODO: implement
            return null;
        }

        public Model.Doctor.RefferalToOperation ChangeOperationTerm(String idOfOperation)
        {
            // TODO: implement
            return null;
        }

        public void CancelOperationTerm(String idOfOperation)
        {
            // TODO: implement
        }

        public void SetAsUrgent(Model.Doctor.RefferalToOperation operation)
        {
            // TODO: implement
        }

        public List<Model.Doctor.RefferalToOperation> GetOperationSchedule(Model.Doctor.DoctorSpecialist doctor)
        {
            // TODO: implement
            return null;
        }

        public List<Model.Doctor.RefferalToOperation> GetOperationRoomSchedule(Model.Manager.OperationRoom operationRoom)
        {
            // TODO: implement
            return null;
        }

        public Repository.DoctorRepository.OperationRepository operationRepository;

        // Dodao sam konstruktor.
        public OperationTermService()
        {
            this.operationRepository = new Repository.DoctorRepository.OperationRepository();
        }
    }
}
