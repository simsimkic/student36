using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLekarMVVM.Commands;

namespace WpfLekarMVVM.ViewModels
{
	public class LoginViewModel : BindableBase
	{
		private string jmbg;
		private string sifra;

		public string Jmbg
		{
			get { return jmbg; }
			set
			{
				SetField<string>(ref jmbg, value);
				LoginCommand.RaiseCanExecuteChanged();
			}
		}

		public string Sifra
		{
			get { return sifra; }
			set
			{
				SetField<string>(ref sifra, value);
				LoginCommand.RaiseCanExecuteChanged();
			}
		}

		public MyICommand LoginCommand { get; private set; }

		public delegate void LoginEventHandler(object source, EventArgs args);
		public event LoginEventHandler LoggingIn;

		public LoginViewModel()
		{
			LoginCommand = new MyICommand(OnLoggingIn, LoginCanExecute);
		}

		private bool LoginCanExecute()
		{
			if (string.IsNullOrWhiteSpace(Jmbg) || string.IsNullOrWhiteSpace(Sifra))
			{
				return false;
			}

			if(Jmbg.Length != 13)
			{
				return false;
			}

			return true;
		}

		private void OnLoggingIn()
		{
			LoggingIn?.Invoke(this, null);
		}
	}
}
