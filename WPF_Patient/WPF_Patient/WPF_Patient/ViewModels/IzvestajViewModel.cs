
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_Patient.Commands;

namespace WPF_Patient.ViewModels
{
    class IzvestajViewModel : BindableBase
    {
        public MyICommand GenerateReportCommand { get; set; } //za generisanje izvestaja
		public delegate void GenerateReportEventHandler(object source, EventArgs args);
		public event GenerateReportEventHandler Genarating;

        public MyICommand CancelCommand { get; set; }
        public delegate void CancelEventHandler(object source, EventArgs args);
        public event CancelEventHandler Cancelling;

        public IzvestajViewModel()
        {
            GenerateReportCommand = new MyICommand(OnGenarating);
            CancelCommand = new MyICommand(OnCancelling);
            OdDate = DateTime.Now;

        }


        private void OnGenarating()
        {
            Genarating?.Invoke(this, null);

            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wr = PdfWriter.GetInstance(doc, new FileStream("Izvestaj.pdf", FileMode.Create));
            doc.Open();

            iTextSharp.text.Paragraph p = new iTextSharp.text.Paragraph("Izveštaj o trerapiji za izabrani period");
            doc.Add(p);
            doc.Close();
            MessageBox.Show("Uspešnpo izgenerisan fajl u pdf-u!");
            Process proc = new Process();
            proc.StartInfo = new ProcessStartInfo()
            {
                FileName = "Izvestaj.pdf"
            };
            proc.Start();
        }

        private void OnCancelling()
        {
            Cancelling?.Invoke(this, null);

        }

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
    }
}
