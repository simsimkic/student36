using Controller.PatientController;
using Controller.UserController;
using Model.Patient;
using Model.User;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using WPF_Patient.Commands;
using WPF_Patient.Models;
using WPF_Patient.Xml;

namespace WPF_Patient.ViewModels
{
    class PrijavaViewModel : BindableBase
    {
        private string loginDataFilename = "loginData.xml";
        private XmlReaderWriter xmlReaderWriter;

        #region Login
        private string loginJmbg;
        private string loginSifra;
        private string errorMessage;
        private bool isLoginInitialized;

        public string LoginJmbg
        {
            get { return loginJmbg; }
            set
            {
                SetField<string>(ref loginJmbg, value);
                LoginCommand.RaiseCanExecuteChanged();
            }
        }
        public string LoginSifra
        {
            get { return loginSifra; }
            set
            {
                SetField<string>(ref loginSifra, value);
                LoginCommand.RaiseCanExecuteChanged();
            }
        }

        public string ErrorMessage
        {
            get { return errorMessage; }
            set
            {
                SetField(ref errorMessage, value);
            }
        }

        public MyICommand LoginCommand { get; private set; }
        public delegate void LoginEventHandler(object source, EventArgs args);
        public event LoginEventHandler LoggingIn;
        #endregion

        #region Registration
        public ObservableCollection<Pol> Polovi { get; set; }

        private string ime;
        private bool showImeError;
        private string prezime;
        private bool showPrezimeError;
        private string jmbgRegistracija;
        private bool jmbgRegistracijaError;
        private DateTime datum;
        private DateTime datumVal;
        private Pol pol;
        private Contact kontakt;
        private bool showKontaktError;
        private string email;
        private bool showEmailError;
        private Address adresa;
        private bool showAdresaError;
        private string lozinka;
        private bool lozinkaError;
        private string ponovljenaLozinka;
        private bool ponovljenaLozinkaError;
        private bool isRegistrationInitialized;

        public string Ime
        {
            get { return ime; }
            set
            {
                SetField(ref ime, value);
                RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public bool ShowImeError
        {
            get { return showImeError; }
            set
            {
                SetField(ref showImeError, value);
            }
        }

        public string Prezime
        {
            get { return prezime; }
            set
            {
                SetField(ref prezime, value);
                RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public bool ShowPrezimeError
        {
            get { return showPrezimeError; }
            set
            {
                SetField(ref showPrezimeError, value);
            }
        }


        public string JmbgRegistracija
        {
            get { return jmbgRegistracija; }
            set
            {
                SetField(ref jmbgRegistracija, value);
                RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public bool ShowJmbgRegistracijaError
        {
            get { return jmbgRegistracijaError; }
            set
            {
                SetField(ref jmbgRegistracijaError, value);
            }
        }

        public DateTime Datum
        {
            get { return datum; }
            set
            {
                SetField(ref datum, value);
                RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public DateTime DatumVal
        {
            get { return datumVal; }
            set
            {
                SetField(ref datumVal, value);
                RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public Pol Pol
        {
            get { return pol; }
            set
            {
                SetField(ref pol, value);
                RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public Contact Kontakt
        {
            get { return kontakt; }
            set
            {
                SetField(ref kontakt, value);
                RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public bool ShowKontaktError
        {
            get { return showKontaktError; }
            set
            {
                SetField(ref showKontaktError, value);
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                SetField(ref email, value);
                RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public bool ShowEmailError
        {
            get { return showEmailError; }
            set
            {
                SetField(ref showEmailError, value);
            }
        }

        public Address Adresa
        {
            get { return adresa; }
            set
            {
                SetField(ref adresa, value);
                RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public bool ShowAdresaError
        {
            get { return showAdresaError; }
            set
            {
                SetField(ref showAdresaError, value);
            }
        }

        public string Lozinka
        {
            get { return lozinka; }
            set
            {
                SetField(ref lozinka, value);
                RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public bool ShowLozinkaError
        {
            get { return lozinkaError; }
            set
            {
                SetField(ref lozinkaError, value);
            }
        }


        public string PonovljenaLozinka
        {
            get { return ponovljenaLozinka; }
            set
            {
                SetField(ref ponovljenaLozinka, value);
                RegisterCommand.RaiseCanExecuteChanged();
            }
        }

        public bool ShowPonovljenaLozinkaError
        {
            get { return ponovljenaLozinkaError; }
            set
            {
                SetField(ref ponovljenaLozinkaError, value);
            }
        }

        public MyICommand RegisterCommand { get; set; }
        #endregion

        public MyICommand ZaboravljenaLozinkaCommand { get; set; }
        public delegate void ZaboravljenaLozinkaEventHandler(object source, EventArgs args);
        public event ZaboravljenaLozinkaEventHandler MenjanjeLozinke;

        private PatientController patientController;

        public PrijavaViewModel()
        {
          
            isLoginInitialized = false;
            isRegistrationInitialized = false;
            LoginCommand = new MyICommand(OnLoggingIn, LoginCanExecute);
            RegisterCommand = new MyICommand(OnRegistering, RegisterCanExecute);
            ZaboravljenaLozinkaCommand = new MyICommand(OnZaboravljenaLozinka);
            ShowImeError = false;
            ShowPrezimeError = false;
            ShowJmbgRegistracijaError = false;
            ShowLozinkaError = false;
            ShowEmailError = false;
            ShowPonovljenaLozinkaError = false;
            patientController = new PatientController();
            Polovi = new ObservableCollection<Pol>();
            Polovi.Add(Pol.Zenski);
            Polovi.Add(Pol.Muski);
            xmlReaderWriter = new XmlReaderWriter();

            DatumVal = DateTime.Now;
        }

        #region Login Methods
        private bool LoginCanExecute()
        {
            ResetErrorMessage();

            if (string.IsNullOrWhiteSpace(LoginJmbg) || string.IsNullOrWhiteSpace(LoginSifra))
            {
                if (isLoginInitialized)
                {
                    SetErrorMessage("Morate uneti JMBG i Lozinku.");
                    return false;
                }
                else
                {
                    isLoginInitialized = true;
                    return false;
                }
            }

            if(LoginJmbg.Length != 13)
            {
				SetErrorMessage("JMBG mora sadrzati 13 cifara");
				return false;
            }

            return true;
        }
       
        UserController userController = new UserController();
        private void OnLoggingIn()
        {
            // neka provera na access controlleru da li je korisnik logovan
            //LoginData loginData = new LoginData();
            //loginData.Jmbg = LoginJmbg;
            //loginData.Sifra = LoginSifra;
            //xmlReaderWriter.SerializeObject(loginData, loginDataFilename);
            //LoggingIn?.Invoke(this, null);
            Patient p;
            if (patientController.SignIn(loginJmbg, loginSifra,out  p))
            {
                MessageBox.Show("Postoji");
                //OVDE STAVITI TAJ CONTENTVIEWMODEL
                PocetnaViewModel.Patient = p;
                LoggingIn?.Invoke(this, null);
            }
            else
            {
                MessageBox.Show("Jmbg i sifra se ne poklapaju.");
            }
        }

        private void ResetErrorMessage()
        {
            ErrorMessage = "";
        }

        private void SetErrorMessage(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
        #endregion

        #region Register Methods
        private bool RegisterCanExecute()
        {
            if (isRegistrationInitialized)
            {
                bool isValid = true;

                if (String.IsNullOrWhiteSpace(Ime))
                {
                    ShowImeError = true;
                    isValid = false;
                }
                else
                {
                    bool isIme = Regex.IsMatch(Ime, @"^([A-Z]{1}[a-z]{1,30})$", RegexOptions.IgnoreCase);
                    if (!isIme)
                    {
                        isValid = false;

                    }
                }

                if (String.IsNullOrWhiteSpace(Prezime))
                {
                    ShowPrezimeError = true;
                    isValid = false;
                }
                else
                {
                    bool isPrezime = Regex.IsMatch(Prezime, @"^([A-Z]{1}[a-z]{1,30})$", RegexOptions.IgnoreCase);
                    if (!isPrezime)
                    {
                        isValid = false;
                        showPrezimeError = true;

                    }
                }

                if (Datum > DatumVal)
                {
                    isValid = false;
                    MessageBox.Show("Datum rođenja nije validan!");
                }

                if (String.IsNullOrWhiteSpace(JmbgRegistracija) || JmbgRegistracija.Length != 13)
                {
                    ShowJmbgRegistracijaError = true;
                    isValid = false;
                }
                else
                {
                    ShowJmbgRegistracijaError = false;
                }

                if (String.IsNullOrWhiteSpace(Lozinka))
                {
                    ShowLozinkaError = true;
                    isValid = false;
                }
                else
                {
                    ShowLozinkaError = false;
                }

                if (String.IsNullOrWhiteSpace(PonovljenaLozinka))
                {
                    ShowPonovljenaLozinkaError = true;
                    isValid = false;
                }
                else
                {
                    ShowPonovljenaLozinkaError = false;
                }

                if (Lozinka != PonovljenaLozinka)
                {
                    isValid = false;
                    SetErrorMessage("Lozinka i Ponovljena Lozinka moraju biti iste");

                }

                if (string.IsNullOrWhiteSpace(Email))
                {
                    isValid = false;
                    showEmailError = true;
                }
                else
                {
                    bool isEmail = Regex.IsMatch(Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                    if (!isEmail)
                    {
                        isValid = false;
                        showEmailError = true;
                        SetErrorMessage("Lozinka i Ponovljena Lozinka moraju biti iste");
                    }
                }




                return isValid;

            }
            else
            {
                isRegistrationInitialized = true;
                return false;
            }
        }

        private void OnRegistering()
        {
            
            Patient newPatient = new Patient();
            newPatient.Jmbg = JmbgRegistracija;
            newPatient.Name = Ime;
            newPatient.Surname = Prezime;
            newPatient.DateOfBirth = Datum;
            //newPatient.Contact = Kontakt;
            //newPatient.Address = Adresa;
            //newPatient. = Pol;
            newPatient.Email = Email;
            newPatient.Password = Lozinka;

            if (patientController.RegisterPatient(newPatient))
            {
                MessageBox.Show("Registracija je uspešno izvršena!\n" +
               "Sad možete da se prijavite.");
            }
            else
            {
                MessageBox.Show("Pacijent sa tim jmbg je registrovan.");
            }

           
        }
        #endregion

        private void OnZaboravljenaLozinka()
        {
            MenjanjeLozinke?.Invoke(this, null);
        }



        //DEMO

        public MyICommand DemoCommand { get; set; }
        public delegate void DemoEventHandler(object source, EventArgs args);
        public event ZaboravljenaLozinkaEventHandler DemoPlaying;


    }
}

