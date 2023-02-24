using Model.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Patient.CustomEventArgs
{
	public class AppointmentDoktorEventArgs : EventArgs
	{
		public Doctor Doctor { get; set; }

		public AppointmentDoktorEventArgs(Doctor doctor)
		{
			Doctor = doctor;
		}
	}
}
