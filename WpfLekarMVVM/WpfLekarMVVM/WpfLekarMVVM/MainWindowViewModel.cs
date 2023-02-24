using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLekarMVVM.ViewModels;

namespace WpfLekarMVVM
{
	public class MainWindowViewModel : BindableBase
	{
		private LoginViewModel _loginViewModel;
		private ContentViewModel _contentViewModel;
		private BindableBase _currentViewModel;

		public MainWindowViewModel()
		{
			_loginViewModel = new LoginViewModel();
			_loginViewModel.LoggingIn += OnLoggingIn;

			_contentViewModel = new ContentViewModel();
			_contentViewModel.LoggedOut += OnLoggedOut;

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
		}

		// Subscription to LoggingOut event from ContentViewModel
		private void OnLoggedOut(object source, EventArgs e)
		{
			CurrentViewModel = _loginViewModel;
		}
	}
}
