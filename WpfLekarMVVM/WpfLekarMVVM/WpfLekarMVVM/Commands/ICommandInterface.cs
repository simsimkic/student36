using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLekarMVVM.Commands
{
	public interface ICommandInterface
	{
		void Execute();
		void Undo();
	}
}
