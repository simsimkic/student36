using Model.Doctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Patient.CustomEventArgs
{
	public class ChosenPriorityEventArgs : EventArgs
	{
		public string PriorityType { get; set; }
		public DateTime OdDate { get; set; }
		public DateTime DoDate { get; set; }
		public Doctor Doctor { get; set; }

		public ChosenPriorityEventArgs(string priorityType)
		{
			PriorityType = priorityType;
		}
	}
}
