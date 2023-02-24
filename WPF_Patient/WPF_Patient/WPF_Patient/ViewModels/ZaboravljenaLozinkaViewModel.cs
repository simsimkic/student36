using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_Patient.Commands;

namespace WPF_Patient.ViewModels
{
    public class ZaboravljenaLozinkaViewModel : BindableBase
    {

        private string jmbg;
        private string lozinka;
        private string ponovljenaLozinka;
        private bool isChangeInitialized;

        public string Jmbg
        {
            get { return jmbg; }
            set
            {
                SetField(ref jmbg, value);
                IzmeniLozinkuCommand.RaiseCanExecuteChanged();
            }
        }
        
        public string Lozinka
        {
            get { return lozinka; }
            set
            {
                SetField(ref lozinka, value);
                IzmeniLozinkuCommand.RaiseCanExecuteChanged();
            }
        }
        


        public string PonovljenaLozinka
        {
            get { return ponovljenaLozinka; }
            set
            {
                SetField(ref ponovljenaLozinka, value);
                IzmeniLozinkuCommand.RaiseCanExecuteChanged();
            }
        }
        

        public delegate void ZaboravljenaLozinkaIzmenjenaEventHandler(object source, EventArgs args);
		public event ZaboravljenaLozinkaIzmenjenaEventHandler LozinkaIzmenjena;

		public MyICommand IzmeniLozinkuCommand { get; set; }

		public ZaboravljenaLozinkaViewModel()
		{
			IzmeniLozinkuCommand = new MyICommand(OnLozinkaIzmenjena, CanExecuteLozinkaIzmenjena);
            isChangeInitialized = false;
        }

		private bool CanExecuteLozinkaIzmenjena()
		{
            if (isChangeInitialized)
            {
                    bool isValid = true;
               
                    if (String.IsNullOrWhiteSpace(Lozinka) || String.IsNullOrWhiteSpace(Jmbg) || String.IsNullOrWhiteSpace(PonovljenaLozinka))
                    {
                        isValid = false;
                    }

                    if (String.IsNullOrWhiteSpace(PonovljenaLozinka))
                    {
                        isValid = false;
                    }

                    if (Lozinka != PonovljenaLozinka)
                    {
                        isValid = false;

                    }

                    if(Jmbg.Length != 13)
                    {
                        isValid = false;
                    }

                    return isValid;

                }
                else
                {
                    isChangeInitialized = true;
                    return false;
                }

            }

		private void OnLozinkaIzmenjena()
		{
			LozinkaIzmenjena?.Invoke(this, null);
		}



	}
}
