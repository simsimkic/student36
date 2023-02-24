using Model.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Patient.CustomEventArgs
{
	public class IzmenaPregledaEventArgs : EventArgs
	{
        //pokusaj
		public Appointment PregledZaIzmenu { get; set; }

        public IzmenaPregledaEventArgs(Appointment pregledZaIzmenu)
        {
        	PregledZaIzmenu = pregledZaIzmenu;
        }
    }
}
