using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLekarMVVM.Commands
{
	public static class CommandExecutor
	{
		private static readonly Stack<ICommandInterface> commands = new Stack<ICommandInterface>();  //stack komandi

		public static void AddAndExecute(ICommandInterface command)
		{
			try
			{
				command.Execute();   //pokusace da izvrsi komandu i ako moze dodace je na stek komandi
			}
			catch (Exception e)
			{
				throw;
			}
			commands.Push(command);
		}

		public static void Undo()
		{
			if (commands.Count > 0)     //u slucaju da ima komandi popovace je sa steka i izvrsiti njenu undo akciju
			{
				ICommandInterface undoCommand = commands.Pop();
				undoCommand.Undo();
			}
		}
	}
}
