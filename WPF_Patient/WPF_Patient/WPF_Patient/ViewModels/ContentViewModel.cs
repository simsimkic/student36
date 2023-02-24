using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_Patient.Commands;
using WPF_Patient.CustomEventArgs;
using WPF_Patient.Views;

namespace WPF_Patient.ViewModels
{
    class ContentViewModel : BindableBase
    {
        #region Infrastructure
        private BindableBase _currentContentViewModel;
        public BindableBase CurrentContentViewModel
        {
            get { return _currentContentViewModel; }
            set { SetField(ref _currentContentViewModel, value); }
        }
        public MyICommand LogoutCommand { get; private set; }
        public MyICommand<string> NavCommand { get; private set; }
        public delegate void LogoutEventHandler(object sender, EventArgs args);
        public event LogoutEventHandler LoggedOut;

        public MyICommand HelpCommand { get; private set; }
        public delegate void HelpEventHandler(object sender, EventArgs args);
        public event HelpEventHandler Help;
        #endregion

        #region ViewModels
        private AnketaViewModel anketaViewModel;
        private FeedbackViewModel feedbackViewModel;
        private IzmenaPregledaViewModel izmenaPregledaViewModel;
        private IzvestajViewModel izvestajViewModel;
        private KartonViewModel kartonViewModel;
        private ObavestenjaViewModel obavestenjaViewModel;
        private PocetnaViewModel pocetnaViewModel;
        private PreglediViewModel preglediViewModel;
        private PrijavaViewModel prijavaViewModel;
        private RegistracijaViewModel registracijaViewModel;
        private ZakazivanjePregledaViewModel zakazivanjePregledaViewModel;
        private ZakazivanjePregledaPrioritetViewModel zakazivanjePregledaPrioritetViewModel;
		#endregion

		private Window currentWindow;
		        
        public ContentViewModel()
        {
            anketaViewModel = new AnketaViewModel();
            feedbackViewModel = new FeedbackViewModel();
            izmenaPregledaViewModel = new IzmenaPregledaViewModel();
            izvestajViewModel = new IzvestajViewModel();
            kartonViewModel = new KartonViewModel();
            obavestenjaViewModel = new ObavestenjaViewModel();
            pocetnaViewModel = new PocetnaViewModel();
            preglediViewModel = new PreglediViewModel();
            prijavaViewModel = new PrijavaViewModel();
            registracijaViewModel = new RegistracijaViewModel();
            zakazivanjePregledaViewModel = new ZakazivanjePregledaViewModel();
            izvestajViewModel = new IzvestajViewModel();
            zakazivanjePregledaPrioritetViewModel = new ZakazivanjePregledaPrioritetViewModel();
           

            NavCommand = new MyICommand<string>(OnNav);
            LogoutCommand = new MyICommand(OnLoggingOut);
            HelpCommand = new MyICommand(OnHelping);

			preglediViewModel.ZakazivanjePregleda += OnZakazivanjePregleda;
			//preglediViewModel.IzmenaPregleda += OnIzmenaPregleda;
			pocetnaViewModel.ZakazivanjePregleda += OnZakazivanjePregleda;
			pocetnaViewModel.Feedbacking += OnFeedback;
			pocetnaViewModel.Anketing += OnAnketa;
            izvestajViewModel.Cancelling += OnCancelling;
            feedbackViewModel.Cancelling += OnCancelling;
            preglediViewModel.ZakazivanjePregledaPrioritet += OnZakazivanjePregledaPrioritet;
            zakazivanjePregledaPrioritetViewModel.Cancelling += OnCancelScheduling;
			zakazivanjePregledaPrioritetViewModel.ChoosingPriority += OnChosenPriority;
            zakazivanjePregledaViewModel.Cancelling += OnCancelScheduling;

           OnNav("pocetna");
		}

		private void OnChosenPriority(object source, ChosenPriorityEventArgs args)
		{
			switch (args.PriorityType)
			{
				case "Doktor":
					ZakazivanjePregledaPrioritetDoktorViewModel zdk = new ZakazivanjePregledaPrioritetDoktorViewModel(args);
					zdk.Zakazivanje += OnZakazivanjeDoktor;
					currentWindow = new ZakazivanjePregledaPrioritetDoktorView();
					currentWindow.DataContext = zdk;
					currentWindow.Show();
					break;
				case "Datum":
					ZakazivanjePregledaPrioritetDatumViewModel zdt = new ZakazivanjePregledaPrioritetDatumViewModel(args);
					zdt.Zakazivanje += OnZakazivanjeDatum;
					currentWindow = new ZakazivanjePregledaPrioritetDatumView();
					currentWindow.DataContext = zdt;
					currentWindow.Show();
					break;
			}
		}

		private void OnZakazivanjeDoktor(object source, AppointmentEventArgs args)
		{
			preglediViewModel.AddAppointment(args.Appointment);
			currentWindow.Close();
			CurrentContentViewModel = preglediViewModel;
		}

		private void OnZakazivanjeDatum(object source, AppointmentEventArgs args)
		{
			preglediViewModel.AddAppointment(args.Appointment);
			currentWindow.Close();
			CurrentContentViewModel = preglediViewModel;
		}

		private void OnAnketa(object source, EventArgs args)
		{
			CurrentContentViewModel = anketaViewModel;
		}

		private void OnFeedback(object source, EventArgs args)
		{
			CurrentContentViewModel = feedbackViewModel;
		}

        private void OnCancelling(object source, EventArgs args)
        {
            CurrentContentViewModel = pocetnaViewModel;
        }

        private void OnCancelScheduling(object source, EventArgs args)
        {
            CurrentContentViewModel = preglediViewModel;
        }

        //private void OnIzmenaPregleda(object source, IzmenaPregledaEventArgs args)
        //{
        //	var pregledZaIzmenu = args.PregledZaIzmenu;
        //	// proslediti nekako u zakazivanjePregledaViewModel
        //	CurrentContentViewModel = zakazivanjePregledaViewModel;
        //}

        private void OnZakazivanjePregleda(object source, EventArgs args)
		{
			CurrentContentViewModel = zakazivanjePregledaViewModel;
		}

        private void OnZakazivanjePregledaPrioritet(object source, EventArgs args)
        {
            CurrentContentViewModel = zakazivanjePregledaPrioritetViewModel;
        }

        public void OnNav(string destination)
        {
            // Reset all colors
            switch (destination)
            {
                case "anketa":
                    CurrentContentViewModel = anketaViewModel;
                    break;
                case "feedback":
                    CurrentContentViewModel = feedbackViewModel;
                    break;
                case "izmenaPregleda":
                    CurrentContentViewModel = izmenaPregledaViewModel;
                    break;
                case "izvestaj":
                    CurrentContentViewModel = izvestajViewModel;
                    break;
                case "karton":
                    CurrentContentViewModel = kartonViewModel;
                    break;
                case "obavestenja":
                    CurrentContentViewModel = obavestenjaViewModel;
                    break;
                case "pocetna":
                    CurrentContentViewModel = pocetnaViewModel;
					pocetnaViewModel.Update();
                    break;
                case "pregledi":
                    CurrentContentViewModel = preglediViewModel;
                    break;
                case "prijava":
                    CurrentContentViewModel = prijavaViewModel;
                    break;
                case "pomoc":
                    OnHelping();
                    break;
                case "registracija":
                    CurrentContentViewModel = registracijaViewModel;
                    break;
                case "zakazivanjePregleda":
                    CurrentContentViewModel = zakazivanjePregledaViewModel;
                    break;
                case "zakazivanjePregledaPrioritet":
                    CurrentContentViewModel = zakazivanjePregledaPrioritetViewModel;
                    break;
                case "izlaz":
					OnLoggingOut();
					break;
                default:
                    CurrentContentViewModel = pocetnaViewModel;
                    break;
            }
        }

        

        private void OnLoggingOut()
         {
            LoggedOut?.Invoke(this, EventArgs.Empty);
         }

        private void OnHelping()
        {
            Help?.Invoke(this, EventArgs.Empty);
            

            MessageBox.Show("HELP dokumentacija\n\n" +
                "Ovde možete pronaći detaljno uputstvo za upotrebu aplikacije.\n" +
                "Aplikacija služi da olakša zakazivanje pregleda, kao i praćenje Vašeg zdravstvenog stanja, jer su Vam " +
                "informacije o Vašim pregledim uvek dostupne.\n" +
                "Prečice:\n" +
                "ctrl + q -> početna strana\n" +
                "ctrl + w -> pregledi\n" +
                "ctrl + e -> karton\n" +
                "ctrl + r -> izveštaj\n" +
                "ctrl + d -> demo\n" +
                "ctrl + o -> obaveštenja\n\n" +

                "");

        }
    }
}

