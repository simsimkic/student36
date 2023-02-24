using Controller.DoctorController;
using Model.Doctor;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLekarMVVM.Commands;
using WpfLekarMVVM.Xml;

namespace WpfLekarMVVM.ViewModels
{
	public class UputSpecViewModel : BindableBase
	{
		private string patientFilename = "patient.xml";
		private string appointmentFilename = "appointmentReport.xml";
		private XmlReaderWriter xmlReaderWriter;
		private Patient currentPatient;
        DateTime selectedDate = DateTime.Now;
        string selectedShift;
        Doctor selectedDoctor;
        List<Appointment> free = new List<Appointment>();
        Appointment selectedFree = new Appointment();
        public Appointment SelectedFree
        {
            get
            {
                return selectedFree;
            }
            set
            {
                selectedFree = value;
                OnPropertyChanged("SelectedFree");
            }
        }
        public List<Appointment> Free
        {
            get
            {
                return free;
            }
            set
            {
                free = value;
                OnPropertyChanged("Free");
            }
        }

        public MyICommand ZakaziCommand { get; set; }
        public delegate void ZakaziEventHandler(object source, EventArgs args);
        public event ZakaziEventHandler ZakaziPregled;
        List<Doctor> doctors = new List<Doctor>();
        public Doctor SelectedDoctor
        {
            get
            {
                return selectedDoctor;
            }
            set
            {
                selectedDoctor = value;
                OnPropertyChanged("SelectedDoctor");
            }
        }

        public DateTime SelectedDate
        {
            get
            {
                return selectedDate;
            }
            set
            {
                selectedDate = value;
                OnPropertyChanged("SelectedDate");
            }
        }

        public string SelectedShift
        {
            get
            {
                return selectedShift;
            }
            set
            {
                selectedShift = value;
                OnPropertyChanged("SelectedShift");
            }
        }
        public List<Doctor> Doctors
        {
            get
            {
                return doctors;
            }
            set
            {
                doctors = value;
                OnPropertyChanged("Doctors");
            }
        }

        public MyICommand NazadCommand { get; set; }
        public delegate void NazadEventHandler(object source, EventArgs args);
        public event NazadEventHandler Nazad;

        public bool selected1;
        public bool selected2;
        public bool selected3;
        public bool selected4;
        public bool selected5;
        public bool selected6;

        public bool Selected1
        {
            get { return selected1; }
            set
            {
                SetField(ref selected1, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Selected2
        {
            get { return selected2; }
            set
            {
                SetField(ref selected2, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Selected3
        {
            get { return selected3; }
            set
            {
                SetField(ref selected3, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }
        public bool Selected4
        {
            get { return selected4; }
            set
            {
                SetField(ref selected4, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Selected5
        {
            get { return selected5; }
            set
            {
                SetField(ref selected5, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Selected6
        {
            get { return selected6; }
            set
            {
                SetField(ref selected6, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }
        public MyICommand PrikaziCommand { get; set; }
        
              public MyICommand PronadjiCommand { get; set; }
        DoctorController doctorController = new DoctorController();
        public UputSpecViewModel()
        {
			xmlReaderWriter = new XmlReaderWriter();
			ZakaziCommand = new MyICommand(OnZakazi, OnZakaziCanExecute);
            NazadCommand = new MyICommand(OnNazad);
            PrikaziCommand = new MyICommand(OnPrikazi);
            Doctors = doctorController.GetDoctorsByTime(DateTime.Now - new TimeSpan(2,0,0));
            PronadjiCommand = new MyICommand(OnPronadji);
        }
        AppointmentController appointmentController = new AppointmentController();
        private void OnPronadji()
        {
            List<Appointment> app = appointmentController.GetDoctorAppointments(SelectedDoctor.Jmbg);
            DoctorSpecialist d = new DoctorSpecialist();
            d.Name = selectedDoctor.Name;
            d.Surname = selectedDoctor.Surname;
            d.Jmbg = selectedDoctor.Jmbg;
            d.DateOfBirth = selectedDoctor.DateOfBirth;
            d.DoctorID = selectedDoctor.DoctorID;
           
            bool postoji = false;
            Free = new List<Appointment>();
            if (SelectedShift.Split(' ')[1] == "Prva")
            {
                for (DateTime i = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 8, 0, 0); i < new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 14, 0, 0); i = i + new TimeSpan(0, 30, 0))
                {
                    foreach (var item in app)
                    {
                        if(i == item.BeginDate)
                        {
                            postoji = true;
                            break;
                        }
                    }

                    if (!postoji) 
                        Free.Add(new Appointment() { BeginDate = i,EndDate = i + new TimeSpan(0, 30, 0) ,Doctor = d});
                }
            }
            else
            {
                for (DateTime i = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 14, 0, 0); i < new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 20, 0, 0); i = i + new TimeSpan(0, 30, 0))
                {
                    foreach (var item in app)
                    {
                        if (i == item.BeginDate)
                        {
                            postoji = true;
                            break;
                        }
                    }

                    if (!postoji)
                        Free.Add(new Appointment() { BeginDate = i, EndDate = i + new TimeSpan(0, 30, 0), Doctor = d });
                }
            }
            Free = Free;

        }

        private void OnPrikazi()
        {
            DateTime dateTime;

            if (SelectedShift == "Prva")
            {
                dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 0, 0);
            }
            else
            {
                dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 0, 0);
            }
            Doctors = doctorController.GetDoctorsByTime(dateTime);
        }
        private void OnZakazi()
        {
            //Patient currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilename);

            NoviPregledViewModel.AppointmentReport.appointment = SelectedFree;
			//AppointmentReport currentAppointment = xmlReaderWriter.DeSerializeObject<AppointmentReport>(appointmentFilename);
			ZakaziPregled?.Invoke(this, null);
        }

        private void OnNazad()
        {
            Nazad?.Invoke(this, null);
        }

        private bool OnZakaziCanExecute()
        {
            return true;

        }

        internal void Update()
		{
			Patient currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilename);
		}
	}
}
