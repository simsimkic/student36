using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlinikaKod.Controller.SecretaryController
{
    public class SecretaryController
    {
        public List<Model.Manager.OperationRoom> GetFreeOperationRooms(System.DateTime beginTime, System.DateTime endTime)
        {
            List<Model.Manager.OperationRoom> freeOperationRooms = secretaryService.GetFreeOperationRooms(beginTime, endTime);

            return freeOperationRooms;
        }

        public Model.Manager.WorkPeriod GetWorkingPeriod(Model.Doctor.Doctor doctor)
        {
            Model.Manager.WorkPeriod doctorWorkPeriod = secretaryService.GetWorkingPeriod(doctor);

            return doctorWorkPeriod;
        }

        public Model.Secretary.Secretary ModifySecretary(Model.Secretary.Secretary secretaryToModify)
        {
            Model.Secretary.Secretary modifiedSecretary = secretaryService.ModifySecretary(secretaryToModify);

            return modifiedSecretary;
        }

        public List<Model.Doctor.Doctor> GetAvailableDoctors(Model.Doctor.Specialisation specialisation, System.DateTime day)
        {
            List<Model.Doctor.Doctor> availableDoctors = secretaryService.GetAvailableDoctors(specialisation, day);

            return availableDoctors;
        }

        public Model.User.Notification SendCancelNotif(Model.Doctor.Doctor doctor, Model.Patient.Patient patient)
        {
            Model.User.Notification sentCancelNotif = secretaryService.SendCancelNotif(doctor, patient);

            return sentCancelNotif;
        }

        public void UpdateNotifications()
        {
            secretaryService.UpdateNotifications();
        }

        public Service.UserService.SecretaryService secretaryService;

        public SecretaryController()
        {
            this.secretaryService = new Service.UserService.SecretaryService();
        }
    }
}