//using Controller.DoctorController;
using Model.Doctor;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Patient.Commands;
using WPF_Patient.CustomEventArgs;
using Controller.PatientController;

namespace WPF_Patient.ViewModels
{
	public class ZakazivanjePregledaPrioritetDoktorViewModel : BindableBase
	{
		public MyICommand ZakaziCommand { get; set; }
		public delegate void ZakaziEventHandler(object source, AppointmentEventArgs args);
		public event ZakaziEventHandler Zakazivanje;
		private Doctor doctor;
		ObservableCollection<Appointment> dates = new ObservableCollection<Appointment>();
		public ObservableCollection<Appointment> Dates { get { return dates; } set {
				SetField(ref dates, value);
			} }
		private Appointment selectedDate;
		public Appointment SelectedDate
		{
			get { return selectedDate; }
			set
			{
				SetField(ref selectedDate, value);
			}
		}
        AppointmentController appointmentController = new AppointmentController();
		List<Appointment> app = new List<Appointment>();
		public ZakazivanjePregledaPrioritetDoktorViewModel(ChosenPriorityEventArgs args)
		{
            app = appointmentController.GetAllAppointments();

			Dates = new ObservableCollection<Appointment>();
			bool imaVec = false;
			for (DateTime dt = args.OdDate; dt < args.DoDate; dt = dt + new TimeSpan(0, 0, 30, 0, 0))
			{
				imaVec = false;
				foreach (var item in app)
				{
					if(item.Doctor.Jmbg == args.Doctor.Jmbg)
						if(dt>= item.BeginDate && dt <= item.EndDate)
						{
							imaVec = true;
							break;
						}
				}
				if (!imaVec)
					Dates.Add(new Appointment() { BeginDate = dt, EndDate =  dt + new TimeSpan(0, 0, 30, 0, 0), Doctor = new Model.Doctor.Doctor() { Name = args.Doctor.Name, Surname = args.Doctor.Surname, Jmbg = args.Doctor.Jmbg } });
			}
			


			//Dates.Add(new Appointment() { BeginDate = DateTime.Now, EndDate = DateTime.Now.AddHours(1) });
		    //Dates.Add(new Appointment() { BeginDate = DateTime.Now.AddHours(2), EndDate = DateTime.Now.AddHours(3) });
			doctor = args.Doctor;
			SelectedDate = app[0];
			ZakaziCommand = new MyICommand(OnZakazi);
		}

		private void OnZakazi()
		{
			SelectedDate.AppointmentID = app.Max(x => x.AppointmentID);
			SelectedDate.Patient = PocetnaViewModel.Patient;
            Appointment appointment = new Appointment();
            appointment = SelectedDate;
            //MedicalRecord mr = appointmentController.CatchMedicalRecord(PocetnaViewModel.Patient.Jmbg);
            //AppointmentReport appointmentr = new AppointmentReport();
            //appointmentr.appointment = SelectedDate;

            appointmentController.SaveNewAppointment(appointment);
			//appointmentController.SaveNewAppointment(appointmentr, mr);
			Zakazivanje?.Invoke(this, new AppointmentEventArgs(SelectedDate));
		}
	}
}
