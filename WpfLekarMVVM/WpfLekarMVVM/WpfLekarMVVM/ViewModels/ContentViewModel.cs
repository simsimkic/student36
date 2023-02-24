using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using WpfLekarMVVM.Commands;

namespace WpfLekarMVVM.ViewModels
{
	public class ContentViewModel : BindableBase
	{
		#region ButtonBrushes
		Brush profilButtonBackground;
		public Brush ProfilButtonBackground
		{
			get { return profilButtonBackground; }
			set
			{
				SetField(ref profilButtonBackground, value);
			}
		}

		Brush pacijentiButtonBackground;
		public Brush PacijentiButtonBackground
		{
			get { return pacijentiButtonBackground; }
			set
			{
				SetField(ref pacijentiButtonBackground, value);
			}
		}

		Brush rasporedButtonBackground;
		public Brush RasporedButtonBackground
		{
			get { return rasporedButtonBackground; }
			set
			{
				SetField(ref rasporedButtonBackground, value);
			}
		}

		Brush lekoviButtonBackground;
		public Brush LekoviButtonBackground
		{
			get { return lekoviButtonBackground; }
			set
			{
				SetField(ref lekoviButtonBackground, value);
			}
		}

		Brush izvestajButtonBackground;
		public Brush IzvestajButtonBackground
		{
			get { return izvestajButtonBackground; }
			set
			{
				SetField(ref izvestajButtonBackground, value);
			}
		}

		private List<Brush> brushes;
		#endregion

		#region Infrastructure
		private BindableBase _currentContentViewModel;
		public BindableBase CurrentContentViewModel
		{
			get { return _currentContentViewModel; }
			set { SetField(ref _currentContentViewModel, value); }
		}
		public MyICommand LogoutCommand { get; private set; }
		public MyICommand<string> NavCommand { get; private set; }
		public NavigationCommand NavigationCommand { get; set; }
		public MyICommand UndoCommand { get; set; }
		public delegate void LogoutEventHandler(object sender, EventArgs args);
		public event LogoutEventHandler LoggedOut;
		#endregion

		#region ViewModels
		private IzvestajViewModel izvestajViewModel;
		private LekoviViewModel lekoviViewModel;
        private ProfilViewModel profilViewModel;
		private RasporedViewModel rasporedViewModel;
        private PacijentiContentViewModel pacijentiContentViewModel;
        #endregion

        public ContentViewModel()
        {
            izvestajViewModel = new IzvestajViewModel();
            lekoviViewModel = new LekoviViewModel();
            profilViewModel = new ProfilViewModel();
            rasporedViewModel = new RasporedViewModel();
            pacijentiContentViewModel = new PacijentiContentViewModel();

            NavCommand = new MyICommand<string>(ExecuteNavCommand);
            LogoutCommand = new MyICommand(OnLoggingOut);
            UndoCommand = new MyICommand(OnUndo);

            ProfilButtonBackground = Brushes.LightBlue;
            PacijentiButtonBackground = Brushes.LightBlue;
            RasporedButtonBackground = Brushes.LightBlue;
            LekoviButtonBackground = Brushes.LightBlue;
            IzvestajButtonBackground = Brushes.LightBlue;

            OnNav("Profil");
        }

        public void ExecuteNavCommand(string parameter)
        {
            string previousTab = CurrentContentViewModel.GetType().Name.Replace("ViewModel", "");
            if (previousTab == parameter)
            {
                return;
            }
            NavigationCommand = new NavigationCommand(this, previousTab, parameter);
            CommandExecutor.AddAndExecute(NavigationCommand);
        }

        public void OnNav(string destination)
        {
            ResetButtonBackgrounds();

            // Reset all colors
            switch (destination)
            {
                case "Izvestaj":
                    CurrentContentViewModel = izvestajViewModel;
                    IzvestajButtonBackground = Brushes.CadetBlue;
                    break;
                case "Lekovi":
                    CurrentContentViewModel = lekoviViewModel;
                    LekoviButtonBackground = Brushes.CadetBlue;
                    lekoviViewModel.Update();
                    break;
                case "Profil":
                    CurrentContentViewModel = profilViewModel;
                    ProfilButtonBackground = Brushes.CadetBlue;
                    break;
                case "Raspored":
                    CurrentContentViewModel = rasporedViewModel;
                    RasporedButtonBackground = Brushes.CadetBlue;
                    break;
                case "PacijentiContent":
                    pacijentiContentViewModel.ResetPacijentiContentCurrentViewModel();  // Vracamo se na izbor pacijenta
                    CurrentContentViewModel = pacijentiContentViewModel;
                    PacijentiButtonBackground = Brushes.CadetBlue;

                    break;
                default:
                    CurrentContentViewModel = profilViewModel;
                    PacijentiButtonBackground = Brushes.CadetBlue;
                    break;
            }
        }

        private void OnUndo()
        {
            CommandExecutor.Undo();
        }

        private void ResetButtonBackgrounds()
        {
            ProfilButtonBackground = Brushes.LightBlue;
            PacijentiButtonBackground = Brushes.LightBlue;
            RasporedButtonBackground = Brushes.LightBlue;
            LekoviButtonBackground = Brushes.LightBlue;
            IzvestajButtonBackground = Brushes.LightBlue;
        }

        private void OnLoggingOut()
        {
            LoggedOut?.Invoke(this, EventArgs.Empty);
        }
    }
}
