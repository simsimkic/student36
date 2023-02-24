using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLekarMVVM.CustomEventArgs
{
	public class NovPregledEventArgs : EventArgs
	{
		public string TipNovogPregleda { get; set; }

		public NovPregledEventArgs(string tipNovogPregleda)
		{
			TipNovogPregleda = tipNovogPregleda;
		}
	}
}
