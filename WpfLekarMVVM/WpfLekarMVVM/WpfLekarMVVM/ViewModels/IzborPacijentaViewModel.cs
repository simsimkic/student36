using Controller.DoctorController;
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
	public class IzborPacijentaViewModel : BindableBase
	{
        
         private string xmlFilePath = @"C:\Users\Maja\simsfinalni\projekat\data\patients.xml";
        private string patientFilePath = @"C:\Users\Maja\simsfinalni\projekat\data\patient.xml";

        private XmlReaderWriter xmlReaderWriter;

        private AppointmentController appointmentController;

        private Patient currentPatient;
        ObservableCollection<Patient> patients = new ObservableCollection<Patient>();
        public Patient CurrentPatient
        {
            get { return currentPatient; }
            set
            {
                SetField(ref currentPatient, value);
                DaljeCommand.RaiseCanExecuteChanged();
            }
        }
        public ObservableCollection<Patient> Patients
        {
            get
            {
                return patients;
            }
            set
            {
                SetField(ref patients, value);
                DaljeCommand.RaiseCanExecuteChanged();
            }
        }

        public MyICommand DaljeCommand { get; set; }
        public delegate void DaljeEventHandler(object source, EventArgs args);
        public event DaljeEventHandler Dalje;

        public IzborPacijentaViewModel()
        {
            xmlReaderWriter = new XmlReaderWriter();
            DaljeCommand = new MyICommand(OnDalje, OnDaljeCanExecute);
            Patients = new ObservableCollection<Patient>();
            appointmentController = new AppointmentController();
            
            

        }

        private bool OnDaljeCanExecute()
        {
             return CurrentPatient != null;
           // return true;
        }

        private void OnDalje()
        {
            xmlReaderWriter.SerializeObject(CurrentPatient, patientFilePath);
            // Patient currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilePath);
           // Patients.Clear();
           currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilePath);
            Dalje?.Invoke(this, null);
        }

        public void Update()
        {
            List<Model.Patient.Patient> patients = xmlReaderWriter.DeSerializeObject<List<Model.Patient.Patient>>(xmlFilePath);
            List <Patient> p= appointmentController.CatchAllPatients();
            Patients = new ObservableCollection<Patient>(p);
            //currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilePath);
           
        }
    }
}

