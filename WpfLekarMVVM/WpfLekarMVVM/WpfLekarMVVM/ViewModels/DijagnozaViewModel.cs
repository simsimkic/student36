using Controller.DoctorController;
using Model.Doctor;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLekarMVVM.Commands;
using WpfLekarMVVM.Xml;

namespace WpfLekarMVVM.ViewModels
{
	public class DijagnozaViewModel : BindableBase
	{
        private string patientFilename = @"C:\Users\Maja\simsfinalni\projekat\data\patients.xml";
        private string appointmentFilename = @"C:\Users\Maja\simsfinalni\projekat\data\appointmentReport.xml";
        private string diagnosisFileName = @"C:\Users\Maja\simsfinalni\projekat\data\diagnosis.xml";
        private XmlReaderWriter xmlReaderWriter;
		private Patient currentPatient;

		public MyICommand ZakaziCommand { get; set; }
        public delegate void ZakaziEventHandler(object source, EventArgs args);
        public event ZakaziEventHandler ZakaziPregled;

        public MyICommand NazadCommand { get; set; }
        public delegate void NazadEventHandler(object source, EventArgs args);
        public event NazadEventHandler Nazad;

        private AppointmentController appointmentController;

        private Diagnosis currentDiagnosis;
        public Diagnosis CurrentDiagnosis
        {
            get { return currentDiagnosis; }
            set
            {
                SetField(ref currentDiagnosis, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }

        ObservableCollection<Diagnosis> diagnosis = new ObservableCollection<Diagnosis>();
        public ObservableCollection<Diagnosis> Diagnosis
        {
            get { return diagnosis; }
            set
            {
                SetField(ref diagnosis, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }

        }

        public bool selected1;

        public bool Selected1
        {
            get { return selected1; }
            set
            {
                SetField(ref selected1, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }

        public DijagnozaViewModel()
        {
			xmlReaderWriter = new XmlReaderWriter();
			ZakaziCommand = new MyICommand(OnZakazi);
            NazadCommand = new MyICommand(OnNazad);
            appointmentController = new AppointmentController();
            Diagnosis = new ObservableCollection<Diagnosis>();
        }

        private void OnNazad()
        {
            Nazad?.Invoke(this, null);
        }

        private void OnZakazi()
        {
            NoviPregledViewModel.AppointmentReport.diagnosis.Add(CurrentDiagnosis);
            //Patient currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilename);
            //AppointmentReport currentAppointment = xmlReaderWriter.DeSerializeObject<AppointmentReport>(appointmentFilename);
            ZakaziPregled?.Invoke(this, null);
        }

		internal void Update()
		{
            List<Model.Patient.Patient> patients = xmlReaderWriter.DeSerializeObject<List<Model.Patient.Patient>>(patientFilename);
            List<Diagnosis> d = appointmentController.EstablishDiagnosis();
            Diagnosis = new ObservableCollection<Diagnosis>(d);
            Diagnosis currentDiagnosis = xmlReaderWriter.DeSerializeObject<Diagnosis>(diagnosisFileName);
        }
	}
}
