using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.UserService
{
    public class SecretaryService
    {
        public List<Model.Manager.OperationRoom> GetFreeOperationRooms(System.DateTime beginTime, System.DateTime endTime)
        {
            return null;
        }

        public Model.Manager.WorkPeriod GetWorkingPeriod(Model.Doctor.Doctor doctor)
        {
            Model.Manager.WorkPeriod doctorWorkPeriod = secretaryRepository.GetWorkingPeriod(doctor);

            return doctorWorkPeriod;
        }

        public Model.Secretary.Secretary ModifySecretary(Model.Secretary.Secretary secretaryToModify)
        {
            return null;
        }

        public List<Model.Doctor.Doctor> GetAvailableDoctors(Model.Doctor.Specialisation specialisation, System.DateTime day)
        {
            return null;
        }

        public Model.User.Notification SendCancelNotif(Model.Doctor.Doctor doctor, Model.Patient.Patient patient)
        {
            return null;
        }

        public void UpdateNotifications()
        {

        }

        public Repository.SecretaryRepository.SecretaryRepository secretaryRepository;

        // Dodao sam konstruktor.
        public SecretaryService()
        {
            this.secretaryRepository = new Repository.SecretaryRepository.SecretaryRepository();
        }
    }
}
