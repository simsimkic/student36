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
	public class UputOpViewModel : BindableBase
	{
		private string patientFilename = "patient.xml";
		private string appointmentFilename = "appointmentReport.xml";
		private XmlReaderWriter xmlReaderWriter;
		private Patient currentPatient;

		public MyICommand PredjiNaDetaljeCommand { get; set; }
        public delegate void PredjiNaDetaljeEventHandler(object source, EventArgs args);
        public event PredjiNaDetaljeEventHandler PredjiNaDetalje;

        public MyICommand NazadCommand { get; set; }
        public delegate void NazadEventHandler(object source, EventArgs args);
        public event NazadEventHandler Nazad;

        public bool selected1;
        public bool selected2;
        public bool selected3;
        public bool selected4;
        public bool selected5;
        public bool selected6;
        public bool selected7;
        public bool selected8;
        public bool selected9;
        public bool selected10;


        public bool Selected1
        {
            get { return selected1; }
            set
            {
                SetField(ref selected1, value);
                PredjiNaDetaljeCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Selected2
        {
            get { return selected2; }
            set
            {
                SetField(ref selected2, value);
                PredjiNaDetaljeCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Selected3
        {
            get { return selected3; }
            set
            {
                SetField(ref selected3, value);
                PredjiNaDetaljeCommand.RaiseCanExecuteChanged();
            }
        }
        public bool Selected4
        {
            get { return selected4; }
            set
            {
                SetField(ref selected4, value);
                PredjiNaDetaljeCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Selected5
        {
            get { return selected5; }
            set
            {
                SetField(ref selected5, value);
                PredjiNaDetaljeCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Selected6
        {
            get { return selected6; }
            set
            {
                SetField(ref selected6, value);
                PredjiNaDetaljeCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Selected7
        {
            get { return selected7; }
            set
            {
                SetField(ref selected7, value);
                PredjiNaDetaljeCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Selected8
        {
            get { return selected8; }
            set
            {
                SetField(ref selected8, value);
                PredjiNaDetaljeCommand.RaiseCanExecuteChanged();
            }
        }

        public bool Selected9
        {
            get { return selected9; }
            set
            {
                SetField(ref selected9, value);
                PredjiNaDetaljeCommand.RaiseCanExecuteChanged();
            }
        }
        public bool Selected10
        {
            get { return selected10; }
            set
            {
                SetField(ref selected10, value);
                PredjiNaDetaljeCommand.RaiseCanExecuteChanged();
            }
        }






        public UputOpViewModel()
        {
			xmlReaderWriter = new XmlReaderWriter();
			PredjiNaDetaljeCommand = new MyICommand(OnPredjiNaDetalje, OnPredjiNaDetaljeCanExecute);
            NazadCommand = new MyICommand(OnNazad);
        }

        private void OnPredjiNaDetalje()
        {
			Patient currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilename);
			AppointmentReport currentAppointment = xmlReaderWriter.DeSerializeObject<AppointmentReport>(appointmentFilename);
			PredjiNaDetalje?.Invoke(this, null);
        }

        private void OnNazad()
        {
            Nazad?.Invoke(this, null);
        }

        private bool OnPredjiNaDetaljeCanExecute()
        {
            if ((selected1 == true || selected2 == true || selected3 == true || selected4 == true) && (selected5 == true || selected6 == true || selected7 == true || selected8 == true) || selected9 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

		internal void Update()
		{
			Patient currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilename);
		}
	}
}
