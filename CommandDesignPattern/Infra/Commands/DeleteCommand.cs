using CommandDesignPattern.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern.Infra.Commands
{
    public class DeleteCommand : Command
    {
        private string key;
        public DeleteCommand(string key, DataReciever dataReciever) : base(dataReciever)
        {
            this.key = key;
        }

        public override void Execute()
        {
            dataReciever.Delete(key);
        }
    }
}
