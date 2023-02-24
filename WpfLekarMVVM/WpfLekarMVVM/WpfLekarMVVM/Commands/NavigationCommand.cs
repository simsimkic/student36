using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLekarMVVM.ViewModels;

namespace WpfLekarMVVM.Commands
{
	public class NavigationCommand : ICommandInterface
	{
		private ContentViewModel contentViewModel;
		private string previousTab;
		private string nextTab;

		public NavigationCommand(ContentViewModel contentViewModel, string previousTab, string nextTab)
		{
			this.contentViewModel = contentViewModel;
			this.previousTab = previousTab;
			this.nextTab = nextTab;
		}

		public void Execute()
		{
			contentViewModel.OnNav(nextTab);
		}

		public void Undo()
		{
			contentViewModel.OnNav(previousTab);
		}
	}
}
