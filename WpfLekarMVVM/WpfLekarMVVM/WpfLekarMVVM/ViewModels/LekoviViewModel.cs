using Controller.DoctorController;
using Model.Manager;
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
    public class LekoviViewModel : BindableBase
    {
        private string medicineFilename = @"C:\Users\Maja\simsfinalni\projekat\data\medicines.xml";
        private XmlReaderWriter xmlReaderWriter;

        private Medicine currentMedicine;
        public Medicine CurrentMedicine
        {
            get { return currentMedicine; }
            set
            {
                SetField(ref currentMedicine, value);
                DaljeCommand.RaiseCanExecuteChanged();
            }
        }
        ObservableCollection<Medicine> medicines = new ObservableCollection<Medicine>();

        public ObservableCollection<Medicine> Medicines
        {
            get { return medicines; }
            set
            {
                SetField(ref medicines, value);
                DaljeCommand.RaiseCanExecuteChanged();
            }
        }
        private MedicineController medicineController;

        public Medicine SelectedMedicine
        {
            get { return iSelectedMedicine; }
            set
            {
                iSelectedMedicine = value;
                OnPropertyChanged("SelectedMedicine");
            }
        }
        private Medicine iSelectedMedicine = null;

        public MyICommand DaljeCommand { get; set; }
        public delegate void DaljeEventHandler(object source, EventArgs args);
        public event DaljeEventHandler Dalje;

        public LekoviViewModel()
        {
            xmlReaderWriter = new XmlReaderWriter();
            DaljeCommand = new MyICommand(OnDalje, OnDaljeCanExecute);
            Medicines = new ObservableCollection<Medicine>();
            medicineController = new MedicineController();
            /* Medicines.Add(new Medicine() { name = "Brufen", Ingredient = "paracetamol, iboprufen" });
             Medicines.Add(new Medicine() { name = "Febricet", Ingredient = "paracetamol" });
             Medicines.Add(new Medicine() { name = "Bensedin", Ingredient = "diazepan" });
             Medicines.Add(new Medicine() { name = "Ranisan", Ingredient = "ranitidin" });*/


        }
        private bool OnDaljeCanExecute()
        {
            return CurrentMedicine != null;

        }

        private void OnDalje()
        {

            xmlReaderWriter.SerializeObject(CurrentMedicine, medicineFilename);
            Dalje?.Invoke(this, null);
            RemoveMedicine();
        }

        public void Update()
        {
            // Iscitamo iz fajla podatke o trenutnom pacijentu
            // Izvucemo sve podatke o pacijentu pomocu kontrolera
            // Koristimo te podatke po potrebi


            List<Medicine> m = medicineController.CatchAllMedicines();
            Medicines = new ObservableCollection<Medicine>(m);
            Medicine currentMedicine = xmlReaderWriter.DeSerializeObject<Medicine>(medicineFilename);


        }

        void RemoveMedicine()
        {
            if (SelectedMedicine != null)
            {
                medicines.Remove(SelectedMedicine);
                SelectedMedicine = null;
            }

        }
    }
}

