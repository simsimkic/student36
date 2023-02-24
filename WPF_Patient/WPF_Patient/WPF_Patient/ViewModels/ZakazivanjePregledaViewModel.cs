using Controller.PatientController;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Patient.Commands;
using WPF_Patient.Xml;

namespace WPF_Patient.ViewModels
{
    class ZakazivanjePregledaViewModel : BindableBase
    {
        
        private string doktor;
        private DateTime datum;
        private DateTime vreme;
        private string appointmentID;
        private XmlReaderWriter xmlReaderWriter;
        private string termin;
        private string prostorija;

        public ZakazivanjePregledaViewModel()
        {
            ScheduleCommand = new MyICommand(OnScheduling);
            CancelCommand = new MyICommand(OnCancelling);
            appointmentController = new AppointmentController();
            xmlReaderWriter = new XmlReaderWriter();
        }
        public MyICommand CancelCommand { get; set; }
        public delegate void CancelEventHandler(object source, EventArgs args);
        public event CancelEventHandler Cancelling;


        private void OnCancelling()
        {
            Cancelling?.Invoke(this, null);

        }

        public MyICommand ScheduleCommand { get; set; }
        private AppointmentController appointmentController;

        public string Doktor
        {
            get { return doktor; }
            set
            {
                SetField(ref doktor, value);
                ScheduleCommand.RaiseCanExecuteChanged();
            }
        }

        public DateTime Datum
        {
            get { return datum; }
            set
            {
                SetField(ref datum, value);
                ScheduleCommand.RaiseCanExecuteChanged();
            }
        }


        private void OnScheduling()
        {
            // kod za zakazivanje pregleda
            Appointment newAppointment = new Appointment();

          //  appointmentController.ScheduleAppointment(newAppointment);
        }


    }
}
