using Model.Manager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLekarMVVM.Commands;

namespace WpfLekarMVVM.ViewModels
{
	public class RasporedViewModel : BindableBase
	{
        public ObservableCollection<WorkPeriod> Raspored { get; set; }

        private DateTime odDate;
        public DateTime OdDate
        {
            get { return odDate; }
            set
            {
                SetField(ref odDate, value);
                DoDate = OdDate;
            }
        }

        private DateTime doDate;
        public DateTime DoDate
        {
            get { return doDate; }
            set
            {
                SetField(ref doDate, value);
            }
        }

        public MyICommand FilterCommand { get; set; }

        public RasporedViewModel()
        {
            OdDate = DateTime.Now;
            FilterCommand = new MyICommand(OnFilter);
            Raspored = new ObservableCollection<WorkPeriod>();
        }

        private void OnFilter()
        {
            WorkPeriod wp = new WorkPeriod();
           /* wp.BeginDate = OdDate;
            wp.EndDate = DoDate;
            wp.Shift = Shift.Firstt;
            DateTime begint = new DateTime(OdDate.Year, OdDate.Month, OdDate.Day, 8, 30, 0);
            DateTime endt = new DateTime(DoDate.Year, DoDate.Month, DoDate.Day, 16, 30, 0);
            wp.WorkTime = new WorkTime();
            wp.WorkTime.BeginTime = begint;
            wp.WorkTime.EndTime = endt;
            Raspored.Add(wp);*/
        }
    }
}


