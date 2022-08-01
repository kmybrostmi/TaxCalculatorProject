using CommandDesignPattern.Data;
using CommandDesignPattern.Interface;

namespace CommandDesignPattern.Infra.Commands
{
    public class UpsertCommand : Command
    {
        private string key;
        private string value;
        public UpsertCommand(string key,string value, DataReciever dataReciever) : base(dataReciever)
        {
            this.key = key;
            this.value = value; 
        }

        public override void Execute()
        {
            dataReciever.Upsert(key, value);
        }
    }
}
