using Model.Patient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Patient.CustomEventArgs
{
	public class AppointmentEventArgs :  EventArgs
	{
		public Appointment Appointment { get; set; }

		public AppointmentEventArgs(Appointment appointment)
		{
			Appointment = appointment;
		}
	}
}
