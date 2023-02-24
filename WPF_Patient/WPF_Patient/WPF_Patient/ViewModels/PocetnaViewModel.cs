using Controller.PatientController;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Patient.Commands;
using WPF_Patient.Models;
using WPF_Patient.Xml;

namespace WPF_Patient.ViewModels
{
    class PocetnaViewModel : BindableBase
    {
		private string loginDataFilename = "loginData.xml";
		private XmlReaderWriter xmlReaderWriter;
		private PatientController patientController;
		// TODO: dodati sva potrebna polja kao u registraciji
		public static Patient Patient ;
		private Patient currentPatient;
		public Patient CurrentPatient
		{
			get { return currentPatient; }
			set
			{
				SetField(ref currentPatient, value);
			}
		}
        public ObservableCollection<Feedback> Feedbacks { get; set; }
        public ObservableCollection<Appointment> Appointments { get; set; }

        public MyICommand ZakazivanjePregledaCommand { get; set; }
		public delegate void ZakazivanjePregledaEventHandler(object source, EventArgs args);
		public event ZakazivanjePregledaEventHandler ZakazivanjePregleda;

		public MyICommand FeedbackCommand { get; set; }
		public delegate void FeedbackEventHandler(object source, EventArgs args);
		public event FeedbackEventHandler Feedbacking;

		public MyICommand AnketaCommand { get; set; }
		public delegate void AnketaEventHandler(object source, EventArgs args);
		public event AnketaEventHandler Anketing;

		public MyICommand SacuvajCommand { get; set; }

		public PocetnaViewModel()
		{
			patientController = new PatientController();
			xmlReaderWriter = new XmlReaderWriter();
			ZakazivanjePregledaCommand = new MyICommand(OnZakazivanjePregleda);
			FeedbackCommand = new MyICommand(OnFeedback);
			AnketaCommand = new MyICommand(OnAnketa);
			SacuvajCommand = new MyICommand(OnSacuvaj);
            

        }

		private void OnSacuvaj()
		{
			// TODO: napraviti pacijenta i popuniti sve propertije   
			patientController.ChangeProfileData(CurrentPatient);
		}

		private void OnAnketa()
		{
			Anketing?.Invoke(this, null);
		}

		private void OnFeedback()
		{
			Feedbacking?.Invoke(this, null);
		}

		private void OnZakazivanjePregleda()
		{
			ZakazivanjePregleda?.Invoke(this, null);
		}

		public void Update()
		{
			LoginData loginData = xmlReaderWriter.DeSerializeObject<LoginData>(loginDataFilename);
			CurrentPatient = Patient;
			Patient = currentPatient;
		}


        


    }
}
