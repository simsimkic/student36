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
	public class OperacijaViewModel : BindableBase
	{
		private string patientFilename = "patients.xml";
		private string appointmentFilename = "appointmentReport.xml";
		private XmlReaderWriter xmlReaderWriter;
		private Patient currentPatient;

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

        public OperacijaViewModel()
        {
            ZakaziCommand = new MyICommand(OnZakazi, OnZakaziCanExecute);
            NazadCommand = new MyICommand(OnNazad);
        }

        private void OnNazad()
        {
            Nazad?.Invoke(this, null);
        }

        private void OnZakazi()
        {
			Patient currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilename);
			AppointmentReport currentAppointment = xmlReaderWriter.DeSerializeObject<AppointmentReport>(appointmentFilename);
			ZakaziPregled?.Invoke(this, null);
        }

        private bool OnZakaziCanExecute()
        {
            if ((selected1 == true || selected2 == true || selected3 == true || selected4 == true) && selected5 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
