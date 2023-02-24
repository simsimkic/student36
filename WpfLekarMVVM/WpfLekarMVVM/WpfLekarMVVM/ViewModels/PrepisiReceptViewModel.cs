using Controller.DoctorController;
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
	public class PrepisiReceptViewModel : BindableBase
	{
        //private string patientFilename = "patient.xml";
        //private string appointmentFilename = "appointmentReport.xml";
        private string patientFilename = @"C:\Users\Maja\simsfinalni\projekat\data\patients.xml";
        private string appointmentFilename = @"C:\Users\Maja\simsfinalni\projekat\data\appointmentReport.xml";
        private string medicinesFileName = @"C:\Users\Maja\simsfinalni\projekat\data\medicines.xml";
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

        private Medicine currentMedicine;
        public Medicine CurrentMedicine
        {
            get { return currentMedicine; }
            set
            {
                SetField(ref currentMedicine, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }

        ObservableCollection<Medicine> medicines = new ObservableCollection<Medicine>();
        public ObservableCollection<Medicine> Medicines
        {
            get { return medicines; }
            set
            {
                SetField(ref medicines, value);
                ZakaziCommand.RaiseCanExecuteChanged();
            }
        }
        private MedicineController medicineController;

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
        public bool selected5;


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


        public PrepisiReceptViewModel()
        {
			xmlReaderWriter = new XmlReaderWriter();
			ZakaziCommand = new MyICommand(OnZakazi, OnZakaziCanExecute);
            NazadCommand = new MyICommand(OnNazad);
            Medicines = new ObservableCollection<Medicine>();
            medicineController = new MedicineController();
            

        }
        private void OnNazad()
        {
            Nazad?.Invoke(this, null);
        }

        private void OnZakazi()
        {
            //NoviPregledViewModel.AppointmentReport.medicalRecord.prescriptions.medicines.Add(CurrentMedicine);
            AppointmentReport currentAppointment = xmlReaderWriter.DeSerializeObject<AppointmentReport>(appointmentFilename);
            ZakaziPregled?.Invoke(this, null);
        }

        private bool OnZakaziCanExecute()
        {
            /*if ((selected1 == true || selected2 == true || selected3 == true || selected4 == true) && selected5 == true)
            {
                return true;
            }
            else
            {
                return false;
            }*/
            return true;
        }

		internal void Update()
		{
            Patient currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilename);
            Medicines.Clear();
            Medicines = new ObservableCollection<Medicine>(xmlReaderWriter.DeSerializeObject<List<Medicine>>(medicinesFileName));
        }
	}
}