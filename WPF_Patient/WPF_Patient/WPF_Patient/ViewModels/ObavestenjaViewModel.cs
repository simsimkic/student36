using Model.User;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Patient.ViewModels
{
    class ObavestenjaViewModel : BindableBase
    {

        public ObservableCollection<Notification> Notifications { get; set; }

        public ObavestenjaViewModel()

        {
        }
    }
}
