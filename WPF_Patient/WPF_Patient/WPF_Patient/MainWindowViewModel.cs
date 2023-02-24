using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using WPF_Patient;
using WPF_Patient.Commands;
using WPF_Patient.ViewModels;
using static System.Net.Mime.MediaTypeNames;

namespace WPF_Patient
{
    class MainWindowViewModel : BindableBase
    {
        private PrijavaViewModel _loginViewModel;
		private ContentViewModel _contentViewModel;
		private ZaboravljenaLozinkaViewModel _zaboravljenaLozinkaViewModel;

		private BindableBase _currentViewModel;
		public MyICommand<string> NavCommand { get; set; }
        public MainWindowViewModel()
        {
            _loginViewModel = new PrijavaViewModel();
            _loginViewModel.LoggingIn += OnLoggingIn;
			_loginViewModel.MenjanjeLozinke += OnMenjanjeLozinke;
            _loginViewModel.DemoPlaying += OnDemoPlaying;

            _contentViewModel = new ContentViewModel();
			_contentViewModel.LoggedOut += OnLoggedOut;
            
            _zaboravljenaLozinkaViewModel = new ZaboravljenaLozinkaViewModel();
			_zaboravljenaLozinkaViewModel.LozinkaIzmenjena += OnLozinkaIzmenjena;
            


			CurrentViewModel = _loginViewModel;

			NavCommand = new MyICommand<string>(OnNav);
        }

		private void OnNav(string parameter)
		{
			_contentViewModel.OnNav(parameter);
		}

		private void OnLozinkaIzmenjena(object source, EventArgs args)
		{
			CurrentViewModel = _loginViewModel;
		}

		public BindableBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { SetField(ref _currentViewModel, value); }
        }

        // Subscription to Logging in event from LoginViewModel
        private void OnLoggingIn(object source, EventArgs e)
        {
            CurrentViewModel = _contentViewModel;
			_contentViewModel.OnNav("pocetna");
        }

        // Subscription to LoggingOut event from ContentViewModel
        private void OnLoggedOut(object source, EventArgs e)
        {
            CurrentViewModel = _loginViewModel;
        }

		private void OnMenjanjeLozinke(object source, EventArgs e)
		{
			CurrentViewModel = _zaboravljenaLozinkaViewModel;
		}
        

        private void OnDemoPlaying(object source, EventArgs e)
        {
            
        }


    }
}
