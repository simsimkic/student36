using Model.Patient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLekarMVVM.Commands;

namespace WpfLekarMVVM.ViewModels
{
	public class ProfilViewModel : BindableBase
	{
        public ObservableCollection<Appointment> Appointments { get; set; }
        public string name;
        public string surname;
        public string email;
        public string address;
        public string city;
        public string jmbg;
        public string phone;
        public string specialisation;

        public MyICommand TutorijalCommand { get; set; }
        public MyICommand RegisterCommand { get; set; }
        //private bool isRegistrationInitialized;

        public string Name
        {
            get { return name; }
            set
            {
                SetField(ref name, value);
                // RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                SetField(ref surname, value);
                // RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                SetField(ref email, value);
                // RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                SetField(ref address, value);
                //RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public string City
        {
            get { return city; }
            set
            {
                SetField(ref city, value);
                // RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public string Jmbg
        {
            get { return jmbg; }
            set
            {
                SetField(ref jmbg, value);
                //RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                SetField(ref phone, value);
                // RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public string Specialisation
        {
            get { return specialisation; }
            set
            {
                SetField(ref specialisation, value);
                //RegisterCommand.RaiseCanExecuteChanged();
            }
        }


        public ProfilViewModel()
        {

            this.name = "Dusan";
            this.surname = "Lazic";
            this.jmbg = "1234567891234";
            this.specialisation = "lekar opste prakse";
            this.email = "dusanlazic@gmail.com";
            this.city = "Novi Sad";
            this.address = "Dusana Vasiljeva 8";
            this.phone = "0631234563";
            TutorijalCommand = new MyICommand(OnTutorijal);


            Appointments = new ObservableCollection<Appointment>();
            /*Appointments.Add(new Appointment() { Date = "19.6.2020", PatientName = "Pera Peric", Time = "10:30" });
            Appointments.Add(new Appointment() { Date = "19.6.2020", PatientName = "Ana Rac", Time = "11:00" });
            Appointments.Add(new Appointment() { Date = "19.6.2020", PatientName = "Tara Peric", Time = "11:30" });
            Appointments.Add(new Appointment() { Date = "19.6.2020", PatientName = "Mika Lazic", Time = "12:00" });
            Appointments.Add(new Appointment() { Date = "19.6.2020", PatientName = "Sonja Ras", Time = "13:00" });
            Appointments.Add(new Appointment() { Date = "19.6.2020", PatientName = "Eva Tomic", Time = "13:30" });
            Appointments.Add(new Appointment() { Date = "19.6.2020", PatientName = "Marko Markovic", Time = "14:00" });
            Appointments.Add(new Appointment() { Date = "19.6.2020", PatientName = "Ivan Jesic", Time = "14:30" });*/
        }

        private void OnTutorijal()
        {
            var s = new WpfLekarMVVM.Form1();
            s.Show();
        }

    }
}


