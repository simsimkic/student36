using Controller.DoctorController;
using Model.Doctor;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLekarMVVM.Commands;
using WpfLekarMVVM.CustomEventArgs;
using WpfLekarMVVM.Xml;

namespace WpfLekarMVVM.ViewModels
{
	public class NoviPregledViewModel :  BindableBase
	{
		private string patientFilename = "patient.xml";
		private string appointmentFilename = "appointmentReport.xml";
		private XmlReaderWriter xmlReaderWriter;
		private AppointmentController appointmentController;
        public MyICommand<string> NavCommand { get; set; }
        public MyICommand ZavrsiPregledCommand { get; set; }
        public delegate void ZavrsiPregledEventHandler(object source, EventArgs args);
        public event ZavrsiPregledEventHandler ZavrsiPregled;
        public delegate void IzaberiPregledEventHandler(object source, NovPregledEventArgs args);
        public event IzaberiPregledEventHandler IzaberiPregled;
        public static AppointmentReport AppointmentReport = new AppointmentReport();
        public MyICommand NazadCommand { get; set; }
        public delegate void NazadEventHandler(object source, EventArgs args);
        public event NazadEventHandler Nazad;

        public NoviPregledViewModel()
        {
			xmlReaderWriter = new XmlReaderWriter();
			appointmentController = new AppointmentController();
			NavCommand = new MyICommand<string>(OnNav);
            ZavrsiPregledCommand = new MyICommand(OnZavrsiPregled);
            NazadCommand = new MyICommand(OnNazad);
            AppointmentReport = new AppointmentReport();
        }

        private void OnZavrsiPregled()
        {
			Patient currentPatient = xmlReaderWriter.DeSerializeObject<Patient>(patientFilename);
			//AppointmentReport currentAppointment = xmlReaderWriter.DeSerializeObject<AppointmentReport>(appointmentFilename);
			MedicalRecord mr = appointmentController.CatchMedicalRecord(currentPatient.Jmbg);
           // mr.appointmentReports.Add(AppointmentReport);
			appointmentController.SaveNewAppointment(AppointmentReport, mr);
            AppointmentReport = new AppointmentReport();
            ZavrsiPregled?.Invoke(this, null);
        }

        private void OnNazad()
        {
            Nazad?.Invoke(this, null);
        }

        private void OnNav(string parameter)
        {
            switch (parameter)
            {
                case "simptomi":
                    IzaberiPregled?.Invoke(this, new NovPregledEventArgs("simptomi"));
                    break;
                case "alergije":
                    IzaberiPregled?.Invoke(this, new NovPregledEventArgs("alergije"));
                    break;
                case "prepisiRecept":
                    IzaberiPregled?.Invoke(this, new NovPregledEventArgs("prepisiRecept"));
                    break;
                case "uputSpecijalisti":
                    IzaberiPregled?.Invoke(this, new NovPregledEventArgs("uputSpecijalisti"));
                    break;
                case "uputOperacija":
                    IzaberiPregled?.Invoke(this, new NovPregledEventArgs("uputOperacija"));
                    break;
                case "dijagnoza":
                    IzaberiPregled?.Invoke(this, new NovPregledEventArgs("dijagnoza"));
                    break;
                case "kontrola":
                    IzaberiPregled?.Invoke(this, new NovPregledEventArgs("kontrola"));
                    break;
                default:
                    break;
            }
        }
    }
}
