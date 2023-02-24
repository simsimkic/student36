//using Controller.DoctorController;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Patient.Commands;
using Controller.PatientController;

namespace WPF_Patient.ViewModels
{
    class PreglediViewModel : BindableBase
    {
        public MyICommand ZakazivanjePregledaCommand { get; set; }
        public delegate void ZakazivanjePregledaEventHandler(object source, EventArgs args);
        public event ZakazivanjePregledaEventHandler ZakazivanjePregleda;

        public MyICommand ZakazivanjePregledaPrioritetCommand { get; set; }
        public delegate void ZakazivanjePregledaPrioritetEventHandler(object source, EventArgs args);
        public event ZakazivanjePregledaEventHandler ZakazivanjePregledaPrioritet;
        ObservableCollection<Appointment> pregledi = new ObservableCollection<Appointment>();
        public ObservableCollection<Appointment> Pregledi { 
            get 
            {
                return pregledi;
            } set 
            {
                pregledi = value;
                OnPropertyChanged("Pregledi");
            } 
        }
        public MyICommand PrikaziCommand { get; set; }
        AppointmentController appointmentController = new AppointmentController();
        public PreglediViewModel()
        {
            PrikaziCommand = new MyICommand(OnPrikazi);
            ZakazivanjePregledaCommand = new MyICommand(OnZakazivanjePregleda);
            ZakazivanjePregledaPrioritetCommand = new MyICommand(OnZakazivanjePregledaPrioritet);
         }
        private void OnPrikazi()
        {
            Pregledi = new ObservableCollection<Appointment>(appointmentController.GetAppointment(PocetnaViewModel.Patient.Jmbg));

        }
        private void OnZakazivanjePregleda()
        {
            ZakazivanjePregleda?.Invoke(this, null);
        }

        private void OnZakazivanjePregledaPrioritet()
        {
            ZakazivanjePregledaPrioritet?.Invoke(this, null);
        }
        /* public MyICommand FilterCommand { get; set; }


         private void OnFilter()
         {
             Appointment appointment = new Appointment();
             appointment.doctor = Doctor;
             appointment.date = Date;
             DateTime begint = new DateTime(Date.Year, Date.Month, Date.Day, 7, 30, 0);
             DateTime endt = new DateTime(Date.Year, Date.Month, Date.Day, 15, 30, 0);

             Pregledi.Add(appointment);
         }*/

		public void AddAppointment(Appointment appointment)
		{
			Pregledi.Add(appointment);
		}
    }
}
