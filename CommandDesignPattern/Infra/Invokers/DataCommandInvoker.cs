using CommandDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Infra.Invokers
{
    public class DataCommandInvoker
    {
        private ICommandd? _commandd;

        public void SetCommand(ICommandd command)
        {
            _commandd = command;
            Console.WriteLine($"Command {command.GetType()}");
        }

        public void ExecuteCommand()
        {
            _commandd?.Execute();
        }
    }
}
