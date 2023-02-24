using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLekarMVVM.Commands;
using System.Collections.ObjectModel;

using WpfLekarMVVM.Xml;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows;
using System.Diagnostics;
using System.IO;
using Model.Patient;

namespace WpfLekarMVVM.ViewModels
{
    public class IzvestajViewModel : BindableBase
    {


        private DateTime odDate;
        public DateTime OdDate
        {
            get { return odDate; }
            set
            {
                SetField(ref odDate, value);
                DoDate = OdDate;
            }
        }

        private DateTime doDate;
        public DateTime DoDate
        {
            get { return doDate; }
            set
            {
                SetField(ref doDate, value);
            }
        }

        private string patientFilename = "patient.xml";
        private XmlReaderWriter xmlReaderWriter;

        private Patient currentPatient;
        public Patient CurrentPatient
        {
            get { return currentPatient; }
            set
            {
                SetField(ref currentPatient, value);
                DaljeCommand.RaiseCanExecuteChanged();
            }
        }
        public ObservableCollection<Patient> Patients { get; set; }

        public MyICommand DaljeCommand { get; set; }
        public delegate void DaljeEventHandler(object source, EventArgs args);
        public event DaljeEventHandler Dalje;

        public MyICommand GenerateReportCommand { get; set; }
        public delegate void GenerateEventHandler(object source, EventArgs args);
        public event GenerateEventHandler Generating;

        public IzvestajViewModel()
        {
            xmlReaderWriter = new XmlReaderWriter();
            DaljeCommand = new MyICommand(OnDalje, OnDaljeCanExecute);
            Patients = new ObservableCollection<Patient>();
            Patients.Add(new Patient() { Name = "Pera", Surname = "Peric" });
            GenerateReportCommand = new MyICommand(OnGenerating);
        }
        private void OnGenerating()
        {
            Generating?.Invoke(this, null);

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream("Izvestaj.pdf", FileMode.Create));
            doc.Open();

            iTextSharp.text.Paragraph p = new iTextSharp.text.Paragraph("Izvestaj anamneza i recepti");
            doc.Add(p);
            doc.Close();
            MessageBox.Show("Uspesno je izgenerisan fajl u pdf-u!");
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo()
            {
                FileName = "Izvestaj.pdf"
            };
            proc.Start();


        }

        private bool OnDaljeCanExecute()
        {
            return CurrentPatient != null;
            
        }

        private void OnDalje()
        {
            xmlReaderWriter.SerializeObject(CurrentPatient, patientFilename);
            Dalje?.Invoke(this, null);
        }
    }



}

