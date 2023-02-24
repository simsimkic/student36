//using Controller.DoctorController;
using Model.Doctor;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPF_Patient.Commands;
using WPF_Patient.CustomEventArgs;
using Controller.PatientController;
namespace WPF_Patient.ViewModels
{
	public class ZakazivanjePregledaPrioritetDatumViewModel :  BindableBase
	{
		public MyICommand ZakaziCommand { get; set; }
		public delegate void ZakaziEventHandler(object source, AppointmentEventArgs args);
		public event ZakaziEventHandler Zakazivanje;

		private List<Appointment> AllAppointments;
		ObservableCollection<Appointment> appointments;
		public ObservableCollection<Appointment> Appointments { get { return appointments; } 
			set {
				appointments = value;
				OnPropertyChanged("Appointments");
			} }
		private Appointment appointment;
		public Appointment Appointment
		{
			get { return appointment; }
			set
			{
				SetField(ref appointment, value);
			}
		}
		AppointmentController appointmentController = new AppointmentController();
        PatientController patientController = new PatientController();

		List<Appointment> app;
		public ZakazivanjePregledaPrioritetDatumViewModel(ChosenPriorityEventArgs args)
		{
			app = appointmentController.GetAllAppointments();
			List<Doctor> doctors = appointmentController.GetAllDoctors();
			Appointments = new ObservableCollection<Appointment>();
			
			for (DateTime dt = args.OdDate; dt < args.DoDate; dt = dt + new TimeSpan(0, 0, 30, 0, 0))
			{
				List<string> zauzeti = new List<string>();
				foreach (var item in app)
				{
					if (dt >= item.BeginDate && dt <= item.EndDate)
						zauzeti.Add(item.Doctor.Jmbg);

					
				}

				foreach (var item in doctors)
				{
					if(!zauzeti.Contains(item.Jmbg))
						Appointments.Add(new Appointment() { BeginDate = dt, EndDate = dt + new TimeSpan(0, 0, 30, 0, 0), Doctor = new Model.Doctor.Doctor() { Name = item.Name, Surname = item.Surname, Jmbg = item.Jmbg } });

				}
			}
			ZakaziCommand = new MyICommand(OnZakazi);
		}
		private void OnZakazi()
		{

			Appointment.AppointmentID = app.Max(x=>x.AppointmentID);
			appointment.Patient = PocetnaViewModel.Patient;
            //MedicalRecord mr = appointmentController.CatchMedicalRecord(PocetnaViewModel.Patient.Jmbg);
            //AppointmentReport appointmentr = new AppointmentReport();
            //Appointment appointment = new Appointment();
            //appointmentr.appointment = Appointment;
            appointment = Appointment;
            appointmentController.SaveNewAppointment(appointment);
			Zakazivanje?.Invoke(this, new AppointmentEventArgs(Appointment));
		}
	}
}
