using EShop_DataAccess.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop_DataAccess.Infra;
public class CommandManager
{
    private Stack<ICommandd> commands = new Stack<ICommandd>();

    public void Invoke(ICommandd command)
    {
        if (command.CanExecute())
        {
            commands.Push(command);
            command.Execute();
        }
    }

    public void Undo()
    {
        while (commands.Count >0)
        {
            var command = commands.Pop();
            command.Undo(); 
        }
    }
}

