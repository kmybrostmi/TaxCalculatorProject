﻿using MediatorDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Infra.Concrete;
public class DesktopComputer : Participant
{
    public DesktopComputer(string key, IMediator mediator) : base(key, mediator)
    {

    }

    public override void SendCommand(string receiver, string command)
    {
        Console.WriteLine($"Sending {command} Command to {receiver}");
        base.SendCommand(receiver, command);
    }

    public override void ReceiveCommand(string sender, string command)
    {
        Console.WriteLine($"Desktop computer received a commmand");
        base.ReceiveCommand(sender, command);
    }
}
