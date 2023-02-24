/***********************************************************************
 * Module:  AppointmentTermController.cs
 * Purpose: Definition of the Class Controller.SecretaryController.AppointmentTermController
 ***********************************************************************/

using System;

namespace Controller.SecretaryController
{
    public class AppointmentTermController
    {
        public Model.Patient.Appointment CreateAppointmentTerm(Model.Patient.Appointment appointmentTerm)
        {
            Model.Patient.Appointment createdAppointmentTerm = appointmentTermService.CreateAppointmentTerm(appointmentTerm);

            return createdAppointmentTerm;
        }

        public Model.Patient.Appointment ChangeAppointmentTerm(String idOfAppointment)
        {
            Model.Patient.Appointment changedAppointmentTerm = appointmentTermService.ChangeAppointmentTerm(idOfAppointment);

            return changedAppointmentTerm;
        }

        public void CancelAppointmentTerm(String idOfAppointment)
        {
            appointmentTermService.CancelAppointmentTerm(idOfAppointment);
        }

        public Service.SecretaryService.AppointmentTermService appointmentTermService;

        public AppointmentTermController()
        {
            this.appointmentTermService = new Service.SecretaryService.AppointmentTermService();
        }
    }
}