using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Controller
{
    private  Dictionary<string, ICommand> msgToCommand;

    public Controller()
    {
        this.msgToCommand = new Dictionary<string, ICommand>();
    }

    public void ResiterCommand(string msg,ICommand  command)
    {
        if (!this.msgToCommand.ContainsKey(msg))
        {
            this.msgToCommand.Add(msg, command);
        }
    }


    public void ExcuteCommand(INotifier inotifier)
    {
        if (this.msgToCommand.ContainsKey(inotifier.msg))
        {
            msgToCommand[inotifier.msg].Excute(inotifier);
        }
    }
}

