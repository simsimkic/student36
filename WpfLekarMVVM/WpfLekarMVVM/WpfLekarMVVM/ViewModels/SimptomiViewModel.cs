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
	public class SimptomiViewModel : BindableBase
	{
		private string patientFilename = @"C:\Users\Maja\simsfinalni\projekat\data\patients.xml";
		private string appointmentFilename = @"C:\Users\Maja\simsfinalni\projekat\data\appointmentReport.xml";
        private string symptomFileName = @"C:\Users\Maja\simsfinalni\projekat\data\symptoms.xml";

        private XmlReaderWriter xmlReaderWriter;
		private Patient currentPatient;
        public Patient CurrentPatient
        {
            get { return currentPatient; }
            set
            {
                SetField(ref currentPatient, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }

        private Symptom currentSymptom;
        public Symptom CurrentSymptom
        {
            get { return currentSymptom; }
            set
            {
                SetField(ref currentSymptom, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }
        ObservableCollection<Symptom> symptoms = new ObservableCollection<Symptom>();
        public ObservableCollection<Symptom> Symptoms { get { return symptoms; } set 
            {
                SetField(ref symptoms, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            } }
        private AppointmentController appointmentController;

        public MyICommand ZakaziCommand { get; set; }
        public delegate void ZakaziEventHandler(object source, EventArgs args);
        public event ZakaziEventHandler ZakaziPregled;

        public MyICommand NazadCommand { get; set; }
        public delegate void NazadEventHandler(object source, EventArgs args);
        public event NazadEventHandler Nazad;

        public bool selected1;
        public bool selected2;
        public bool selected3;
        public bool selected4;


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

        public SimptomiViewModel()
        {
			xmlReaderWriter = new XmlReaderWriter();
			ZakaziCommand = new MyICommand(OnZakazi, OnZakaziCanExecute);
            NazadCommand = new MyICommand(OnNazad);
            Symptoms = new ObservableCollection<Symptom>();
            appointmentController = new AppointmentController();



        }

        private void OnZakazi()
        {
            NoviPregledViewModel.AppointmentReport.symptoms.Add(CurrentSymptom);
            //Patient currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilename);
            // List<Symptom> symptoms = xmlReaderWriter.DeSerializeObject<List<Symptom>>(symptomFileName);
            //appointmentController.EnterSymptoms(symptoms);
            // xmlReaderWriter.SerializeObject(currentSymptom, symptomFileName);
            //symptom.Name = "Kijanje";

            // AppointmentReport currentAppointment = xmlReaderWriter.DeSerializeObject<AppointmentReport>(appointmentFilename);
            //currentAppointment.symptom.Add(symptom);
            //xmlReaderWriter.SerializeObject(currentAppointment, appointmentFilename);
            ZakaziPregled?.Invoke(this, null);
        }

        private bool OnZakaziCanExecute()
        {
            //if (selected1 == true || selected2 == true || selected3 == true || selected4 == true)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return true;
        }

        private void OnNazad()
        {
            Nazad?.Invoke(this, null);
        }

		public void Update()
		{
			// Iscitamo iz fajla podatke o trenutnom pacijentu
			// Izvucemo sve podatke o pacijentu pomocu kontrolera
			// Koristimo te podatke po potrebi
			Patient currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilename);
            Symptoms.Clear();
            Symptoms  = new ObservableCollection<Symptom>(xmlReaderWriter.DeSerializeObject<List<Symptom>>(symptomFileName));
            

        }
    }
}
