using Model.Patient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_Patient.Xml;

namespace WPF_Patient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

			XmlReaderWriter xmlReaderWriter = new XmlReaderWriter();
			string patientFilename = "C:\\Users\\Lenovo\\Desktop\\SIMS\\projekat\\Data\\patients.xml";

			List<Patient> patients = xmlReaderWriter.DeSerializeObject<List<Patient>>(patientFilename);
			if(patients == null)
			{
				patients = new List<Patient>();
				xmlReaderWriter.SerializeObject(patients, patientFilename);
			}
            

            string appointmentFilename = "appointments.xml";

            List<Appointment> appointments = xmlReaderWriter.DeSerializeObject<List<Appointment>>(appointmentFilename);
            if (appointments == null)
            {
                appointments = new List<Appointment>();
                xmlReaderWriter.SerializeObject(appointments, appointmentFilename);
            }

            string feedbackFilename = "feedbacks.xml";

            List<Feedback> feedbacks = xmlReaderWriter.DeSerializeObject<List<Feedback>>(feedbackFilename);
            if (feedbacks == null)
            {
                feedbacks = new List<Feedback>();
                xmlReaderWriter.SerializeObject(feedbacks, feedbackFilename);
            }

            var mainWindow = new MainWindow();
            mainWindow.DataContext = new MainWindowViewModel();
            Application.Current.MainWindow = mainWindow;
            Application.Current.MainWindow.Show();
        }
    }
}
