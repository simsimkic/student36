using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLekarMVVM.Commands;
using WpfLekarMVVM.CustomEventArgs;

namespace WpfLekarMVVM.ViewModels
{
    public class PacijentiContentViewModel : BindableBase
    {
        #region Infrastructure
        private BindableBase _currentContentViewModel;
        public BindableBase CurrentContentViewModel
        {
            get { return _currentContentViewModel; }
            set { SetField(ref _currentContentViewModel, value); }
        }
        public MyICommand<string> NavCommand { get; private set; }
        #endregion

        #region ViewModels
        private AlergijeViewModel alergijeViewModel;
        private DijagnozaViewModel dijagnozaViewModel;
        private IzborPacijentaViewModel izborPacijentaViewModel;
        private KontrolaViewModel kontrolaViewModel;
        private NoviPregledViewModel noviPregledViewModel;
        private OperacijaViewModel operacijaViewModel;
        private PacijentiViewModel pacijentiViewModel;
        private PrepisiReceptViewModel prepisiReceptViewModel;
        private SimptomiViewModel simptomiViewModel;
        private UputOpViewModel uputOpViewModel;
        private UputSpecViewModel uputSpecViewModel;
        private IzvestajViewModel izvestajViewModel;
        #endregion

        public PacijentiContentViewModel()
        {
            alergijeViewModel = new AlergijeViewModel();
            dijagnozaViewModel = new DijagnozaViewModel();
            izborPacijentaViewModel = new IzborPacijentaViewModel();
            kontrolaViewModel = new KontrolaViewModel();
            noviPregledViewModel = new NoviPregledViewModel();
            operacijaViewModel = new OperacijaViewModel();
            pacijentiViewModel = new PacijentiViewModel();
            prepisiReceptViewModel = new PrepisiReceptViewModel();
            simptomiViewModel = new SimptomiViewModel();
            uputOpViewModel = new UputOpViewModel();
            uputSpecViewModel = new UputSpecViewModel();
            izvestajViewModel = new IzvestajViewModel();

            // Subscriptions
            izborPacijentaViewModel.Dalje += OnIzborPacijentaDalje;
            pacijentiViewModel.Dalje += OnPacijentiDalje;
            pacijentiViewModel.Nazad += OnPacijentiNazad;
            noviPregledViewModel.IzaberiPregled += OnIzabranPregled;
            noviPregledViewModel.ZavrsiPregled += OnZavrsenPregled;
            // Subscriptions for all subwindows
            simptomiViewModel.ZakaziPregled += OnSimptomiZakazi;
            alergijeViewModel.ZakaziPregled += OnAlergijaZakazi;
            prepisiReceptViewModel.ZakaziPregled += OnPrepisiReceptZakazi;
            uputSpecViewModel.ZakaziPregled += OnUputSpecZakazi;
            uputOpViewModel.PredjiNaDetalje += OnPredjiNaDetaljeOperacije;
            operacijaViewModel.ZakaziPregled += OnOperacijaZakazi;
            dijagnozaViewModel.ZakaziPregled += OnDijagnozaZakazi;
            kontrolaViewModel.ZakaziPregled += OnKontrolaZakazi;
            izvestajViewModel.Generating += OnGenerating;

            alergijeViewModel.Nazad += OnPregledNazad;
            dijagnozaViewModel.Nazad += OnPregledNazad;
            simptomiViewModel.Nazad += OnPregledNazad;
            prepisiReceptViewModel.Nazad += OnPregledNazad;
            kontrolaViewModel.Nazad += OnPregledNazad;
            uputSpecViewModel.Nazad += OnPregledNazad;
            uputOpViewModel.Nazad += OnPregledNazad;
            operacijaViewModel.Nazad += OnUputOpNazad;
            noviPregledViewModel.Nazad += OnKartonNazad;


            CurrentContentViewModel = izborPacijentaViewModel;
            izborPacijentaViewModel.Update();
        }

        private void OnPregledNazad(object source, EventArgs args)
        {
            // CurrentContentViewModel = uputOpViewModel;
            VratiSeNaOdabirPregleda();
        }

        private void OnUputOpNazad(object source, EventArgs args)
        {
            CurrentContentViewModel = uputOpViewModel;
        }

        private void OnGenerating(object source, EventArgs args)
        {
            CurrentContentViewModel = izvestajViewModel;
        }

        private void OnKartonNazad(object source, EventArgs args)
        {
            CurrentContentViewModel = pacijentiViewModel;
        }

        private void OnPredjiNaDetaljeOperacije(object source, EventArgs args)
        {
            CurrentContentViewModel = operacijaViewModel;
        }

        private void OnOperacijaZakazi(object source, EventArgs args)
        {
            VratiSeNaOdabirPregleda();
        }

        private void OnKontrolaZakazi(object source, EventArgs args)
        {
            VratiSeNaOdabirPregleda();
        }

        private void OnDijagnozaZakazi(object source, EventArgs args)
        {
            VratiSeNaOdabirPregleda();
        }

        private void OnUputSpecZakazi(object source, EventArgs args)
        {
            VratiSeNaOdabirPregleda();
        }

        private void OnPrepisiReceptZakazi(object source, EventArgs args)
        {
            VratiSeNaOdabirPregleda();
        }

        private void OnAlergijaZakazi(object source, EventArgs args)
        {
            VratiSeNaOdabirPregleda();
        }

        private void OnSimptomiZakazi(object source, EventArgs args)
        {
            VratiSeNaOdabirPregleda();
        }

        private void OnPacijentiNazad(object source, EventArgs args)
        {
            CurrentContentViewModel = izborPacijentaViewModel;
        }

        private void OnZavrsenPregled(object source, EventArgs args)
        {
            CurrentContentViewModel = pacijentiViewModel;
        }

        private void OnIzabranPregled(object source, NovPregledEventArgs args)
        {
            switch (args.TipNovogPregleda)
            {
                case "simptomi":
                    CurrentContentViewModel = simptomiViewModel;
					simptomiViewModel.Update();
                    break;
                case "alergije":
                    CurrentContentViewModel = alergijeViewModel;
					alergijeViewModel.Update();
                    break;
                case "prepisiRecept":
                    CurrentContentViewModel = prepisiReceptViewModel;
					prepisiReceptViewModel.Update();
                    break;
                case "uputSpecijalisti":
                    CurrentContentViewModel = uputSpecViewModel;
					uputSpecViewModel.Update();
                    break;
                case "uputOperacija":
                    CurrentContentViewModel = uputOpViewModel;
					uputOpViewModel.Update();
                    break;
                case "dijagnoza":
                    CurrentContentViewModel = dijagnozaViewModel;
					dijagnozaViewModel.Update();
                    break;
                case "kontrola":
                    CurrentContentViewModel = kontrolaViewModel;
					kontrolaViewModel.Update();
                    break;
                default:
                    break;
            }
        }

        private void OnIzborPacijentaDalje(object source, EventArgs args)
        {
            CurrentContentViewModel = pacijentiViewModel;
			pacijentiViewModel.Update();
		}

        public void OnPacijentiDalje(object source, EventArgs e)
        {
            CurrentContentViewModel = noviPregledViewModel;
        }

        public void ResetPacijentiContentCurrentViewModel()
        {
            CurrentContentViewModel = izborPacijentaViewModel;
        }

        private void VratiSeNaOdabirPregleda()
        {
            CurrentContentViewModel = noviPregledViewModel;
        }
    }
}
