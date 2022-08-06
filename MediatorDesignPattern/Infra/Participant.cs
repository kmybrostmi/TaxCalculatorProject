using MediatorDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Infra;
public abstract class Participant : IParticipant
{
    private readonly string _key;
    private readonly IMediator _mediator;

    public Participant(string key, IMediator mediator)
    {
        _key = key;
        _mediator = mediator;
    }
    public virtual void ReceiveCommand(string sender, string command)
    {
        Console.WriteLine($"Executing Command {command} issued by {sender}");
    }

    public virtual void SendCommand(string receiver, string command)
    {
        _mediator.SendCommand(receiver, _key, command);
    }
}
