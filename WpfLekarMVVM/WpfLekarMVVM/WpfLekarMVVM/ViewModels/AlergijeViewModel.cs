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
	public class AlergijeViewModel : BindableBase
	{
        private string patientFilename = @"C:\Users\Maja\simsfinalni\projekat\data\patients.xml";
        private string appointmentFilename = @"C:\Users\Maja\simsfinalni\projekat\data\appointmentReport.xml";
        private string allergieFileName = @"C:\Users\Maja\simsfinalni\projekat\data\allergies.xml";

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

        private Allergie currentAllergie;
        public Allergie CurrentAllergie
        {
            get { return currentAllergie; }
            set
            {
                SetField(ref currentAllergie, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }

        ObservableCollection<Allergie> allergies = new ObservableCollection<Allergie>();
        public ObservableCollection<Allergie> Allergies
        {
            get { return allergies; }
            set
            {
                SetField(ref allergies, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }
        private AppointmentController appointmentController;


        private XmlReaderWriter xmlReaderWriter;

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

       

        public AlergijeViewModel()
        {
            xmlReaderWriter = new XmlReaderWriter();
            ZakaziCommand = new MyICommand(OnZakazi, OnZakaziCanExecute);
            NazadCommand = new MyICommand(OnNazad);
            Allergies = new ObservableCollection<Allergie>();
            appointmentController = new AppointmentController();
        }

        private void OnZakazi()
        {
            NoviPregledViewModel.AppointmentReport.allergies.Add(CurrentAllergie);
            // xmlReaderWriter.SerializeObject(CurrentAllergie, allergieFilename);
            //Patient currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilename);
            //AppointmentReport currentAppointment = xmlReaderWriter.DeSerializeObject<AppointmentReport>(appointmentFilename);
            ZakaziPregled?.Invoke(this, null);
        }

        private void OnNazad()
        {
            Nazad?.Invoke(this, null);
        }

        private bool OnZakaziCanExecute()
        {
            /* if (selected1 == true || selected2 == true || selected3 == true || selected4 == true)
             {
                 return true;
             }
             else
             {
                 return false;
             }*/
            return true;
        }

		public void Update()
		{
            List<Model.Patient.Patient> patients = xmlReaderWriter.DeSerializeObject<List<Model.Patient.Patient>>(patientFilename);
            List<Allergie> a = appointmentController.EnterAllergies();
            Allergies = new ObservableCollection<Allergie>(a);
            Allergie currentAllergie = xmlReaderWriter.DeSerializeObject<Allergie>(allergieFileName);
        }
	}
}
