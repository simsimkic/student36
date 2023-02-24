using Model.Doctor;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Patient.Commands;
using WPF_Patient.CustomEventArgs;

namespace WPF_Patient.ViewModels
{
    class ZakazivanjePregledaPrioritetViewModel : BindableBase
    {
        public MyICommand CancelCommand { get; set; } //za generisanje izvestaja
        public delegate void CancelEventHandler(object source, EventArgs args);
        public event CancelEventHandler Cancelling;

		public MyICommand ConfirmCommand { get; set; }
		public delegate void ChoosePriorityEventHandler(object source, ChosenPriorityEventArgs args);
		public event ChoosePriorityEventHandler ChoosingPriority;

		public ObservableCollection<string> Prioriteti { get; set; }
		private string prioritet;
		public string Prioritet
		{
			get { return prioritet; }
			set
			{
				SetField(ref prioritet, value);
			}
		}
		public ObservableCollection<Doctor> Doctors { get; set; }
		private Doctor doctor;
		public Doctor Doctor
		{
			get { return doctor; }
			set
			{
				SetField(ref doctor, value);
			}
		}
        Controller.PatientController.AppointmentController appointmentController = new Controller.PatientController.AppointmentController();
		Controller.DoctorController.DoctorController doctorController = new Controller.DoctorController.DoctorController();
        public ZakazivanjePregledaPrioritetViewModel()
        {
			Prioriteti = new ObservableCollection<string>();
			Prioriteti.Add("Doktor");
			Prioriteti.Add("Datum");
			Prioritet = Prioriteti[0];
			Doctors = new ObservableCollection<Doctor>(appointmentController.GetAllDoctors());
			//Doctors.Add(new Doctor() { Name = "Pera", Surname = "Peric" });
			Doctor = Doctors[0];
			ConfirmCommand = new MyICommand(OnConfirm);
            CancelCommand = new MyICommand(OnCancelling);
            OdDate = DateTime.Now;
        }

		private void OnConfirm()
		{
			switch (Prioritet)
			{
				case "Doktor":
					var dcPriority = new ChosenPriorityEventArgs("Doktor");
					dcPriority.Doctor = Doctor;
					dcPriority.OdDate = OdDate;
					dcPriority.DoDate = DoDate;
					ChoosingPriority?.Invoke(this, dcPriority);
					break;
				case "Datum":
					var dtPriority = new ChosenPriorityEventArgs("Datum");
					dtPriority.OdDate = OdDate;
					dtPriority.DoDate = DoDate;
					dtPriority.Doctor = Doctor;
					ChoosingPriority?.Invoke(this, dtPriority);
					break;
			}
		}

		private void OnCancelling()
        {
            Cancelling?.Invoke(this, null);

        }

        private DateTime odDate;
        public DateTime OdDate
        {
            get { return odDate; }
            set
            {
                SetField(ref odDate, value);
                DoDate = OdDate;
            }
        }

        private DateTime doDate;
        public DateTime DoDate
        {
            get { return doDate; }
            set
            {
                SetField(ref doDate, value);
            }
        }
    }
}
