using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.SecretaryService
{
    public class AppointmentTermService
    {
        public Model.Patient.Appointment CreateAppointmentTerm(Model.Patient.Appointment appointmentTerm)
        {
            Model.Patient.Appointment createdAppointmentTerm = appointmentTermRepository.CreateAppointment(appointmentTerm);

            return createdAppointmentTerm;
        }

        public Model.Patient.Appointment ChangeAppointmentTerm(String idOfAppointment)
        {
            Model.Patient.Appointment changedAppointmentTerm = appointmentTermRepository.ModifyAppointment
                (appointmentTermRepository.GetAppointment(idOfAppointment));

            return changedAppointmentTerm;
        }

        public void CancelAppointmentTerm(String idOfAppointment)
        {
            appointmentTermRepository.DeleteAppointment(idOfAppointment);
        }

        public Repository.SecretaryRepository.AppointmentTermRepository appointmentTermRepository;

        // Dodao sam kontruktor.
        public AppointmentTermService()
        {
            this.appointmentTermRepository = new Repository.SecretaryRepository.AppointmentTermRepository();
        }
    }
}
