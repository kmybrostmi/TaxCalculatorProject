using CommandDesignPattern.Data;
using CommandDesignPattern.Interface;

namespace CommandDesignPattern.Infra
{
    public abstract class Command : ICommandd
    {
        protected DataReciever dataReciever;

        protected Command(DataReciever dataReciever)
        {
            this.dataReciever = dataReciever;
        }

        public abstract void Execute();
    }
}

