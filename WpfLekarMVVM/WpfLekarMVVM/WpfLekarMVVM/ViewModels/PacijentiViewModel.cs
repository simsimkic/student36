using Model.Doctor;
using Model.Manager;
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
	public class PacijentiViewModel : BindableBase
	{
        //private string patientFilename = "patient.xml";
        private string patientFileName = @"C:\Users\Maja\simsfinalni\projekat\data\patients.xml";
        private string curpatientFileName = @"C:\Users\Maja\simsfinalni\projekat\data\patient.xml";
        private string appointmentFilename = "appointmentReport.xml";
		private XmlReaderWriter xmlReaderWriter;
		private Patient currentPatient;
		public Patient CurrentPatient
		{
			get { return currentPatient; }
			set
			{
				SetField(ref currentPatient, value);
			}
		}

		public MyICommand NazadCommand { get; set; }
        public delegate void NazadEventHandler(object source, EventArgs args);
        public event NazadEventHandler Nazad;
        public MyICommand NovPregledCommand { get; set; }
        public delegate void DaljeEventHandler(object source, EventArgs args);
        public event DaljeEventHandler Dalje;

        public ObservableCollection<Patient> Patients { get; set; }
        public ObservableCollection<Allergie> Allergies { get; set; }
        public ObservableCollection<Medicine> Medicines { get; set; }
        public ObservableCollection<AppointmentReport> Reports { get; set; }

        public PacijentiViewModel()
        {
			xmlReaderWriter = new XmlReaderWriter();
			NovPregledCommand = new MyICommand(OnNovPregled);
            NazadCommand = new MyICommand(OnNazad);
            Patients = new ObservableCollection<Patient>();
            //Patients.Add(new Patient() { Name = "Pera", Surname = "Peric", Jmbg = "1234567891234", PatientContact = "060123456", PatientAdress = "Karadjordjeva 10", City = "Valjevo", Email = "pera@gmail.com" });

            Allergies = new ObservableCollection<Allergie>();
            /*Allergies.Add(new Allergie() { allergens = "polen", Reaction = "kijavica" });
            Allergies.Add(new Allergie() { allergens = "kikiriki", Reaction = "gusenje" });
            Allergies.Add(new Allergie() { allergens = "malina", Reaction = "osip" });

            Medicines = new ObservableCollection<Medicine>();
            Medicines.Add(new Medicine() { name = "febricet", Ingredient = "2", Date = "16.5.2020" });
            Medicines.Add(new Medicine() { name = "amoksicilin", Ingredient = "1", Date = "1.6.2020" });
            Medicines.Add(new Medicine() { name = "andol", Ingredient = "3", Date = "6.6.2020" });
            Medicines.Add(new Medicine() { name = "febricet", Ingredient = "1", Date = "26.6.2020" });

            Reports = new ObservableCollection<AppointmentReport>();
            Reports.Add(new AppointmentReport() { Symp = "malaksalost, kasalj", Diagn = "prehlada", Date = "6.3.2020" });
            Reports.Add(new AppointmentReport() { Symp = "temperatura, povracanje", Diagn = "grip", Date = "3.5.2020" });
            Reports.Add(new AppointmentReport() { Symp = "malaksalost, temperatura", Diagn = "grip", Date = "16.6.2020" });*/
        }

        private void OnNazad()
        {
            Nazad?.Invoke(this, null);
        }

        private void OnNovPregled()
        {
			// Sacuvamo tj. kreiramo ako ne postoji fajl koji cuva podatke o trenutnom pregledu
			AppointmentReport appointmentReport = new AppointmentReport();
			xmlReaderWriter.SerializeObject(appointmentReport, appointmentFilename);
            Dalje?.Invoke(this, null);
        }

		public void Update()
		{
			Patients.Clear();
            // Patients.Add(xmlReaderWriter.DeSerializeObject<Patient>(patientFileName));
            Patients = new ObservableCollection<Patient>(xmlReaderWriter.DeSerializeObject<List<Patient>>(patientFileName));
            CurrentPatient = xmlReaderWriter.DeSerializeObject<Patient>(curpatientFileName);
            //da iz kontrolera izvucem podatke o inf pacijenta,getPatient i prosledim jmg koji sam tamo ucitala

        }
    }
}
