using iTextSharp.text;
using iTextSharp.text.pdf;
using Model.Doctor;
using Model.Manager;
using Model.Patient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_Patient.Commands;

namespace WPF_Patient.ViewModels
{
    class KartonViewModel : BindableBase
    {

        public ObservableCollection<Allergie> Allergies { get; set; }
        public ObservableCollection<HospitalTreatment> HospitalTreatments { get; set; }
        public ObservableCollection<MedicalHistory> MedicalHistories { get; set; }
        public ObservableCollection<AppointmentReport> AppointmentReports { get; set; }
        public ObservableCollection<Medicine> Medicines { get; set; }

        public KartonViewModel()
        {
            Allergies = new ObservableCollection<Allergie>();
           // Allergies.Add(new Allergie() { allergens = "polen", Reaction = "kijavica" });
            //Allergies.Add(new Allergie() { allergens = "kikiriki", Reaction = "gušenje" });
            //Allergies.Add(new Allergie() { allergens = "malina", Reaction = "osip" });
            //Allergies.Add(new Allergie() { allergens = "jagoda", Reaction = "osip" });
            HospitalTreatments = new ObservableCollection<HospitalTreatment>();
            //HospitalTreatments.Add(new HospitalTreatment() { CauseOfHospitalization = "Alergijska reakcija", DateOfReceipt = "15/05/2020", ReleaseDate = "18/05/2020" });
            //HospitalTreatments.Add(new HospitalTreatment() { CauseOfHospitalization = "Povišena temperatura", DateOfReceipt = "08/02/2020", ReleaseDate = "17/02/2020" });
            MedicalHistories = new ObservableCollection<MedicalHistory>();
            //MedicalHistories.Add(new MedicalHistory() { height="182cm", weight = "72kg", alcoholic="Ne", smoker = "Da", diseases="Hronična urtikarija" });
            AppointmentReports = new ObservableCollection<AppointmentReport>();
            //AppointmentReports.Add(new AppointmentReport() {date="11/03/2020", typeOfAppointment = "kontrolni pregled", doctor="Dr Marko Markovic", diagnosis="Nastaviti sa terapijom.", specialization="Alergolog" });
            //AppointmentReports.Add(new AppointmentReport() { date = "21/12/2019", typeOfAppointment = "kontrolni pregled", doctor = "Dr Marko Markovic", diagnosis = "Nastaviti sa terapijom.", specialization = "Alergolog" });
            Medicines = new ObservableCollection<Medicine>();
            //Medicines.Add(new Medicine() { name = "Xzyal", Ingredient = "2", Date = "19.6.2020", DateEnd = "19.7.2020" });
            //Medicines.Add(new Medicine() { name = "Ranisan", Ingredient = "1", Date = "19.6.2020", DateEnd = "19.7.2020" });
            
        }

        
    }
}
