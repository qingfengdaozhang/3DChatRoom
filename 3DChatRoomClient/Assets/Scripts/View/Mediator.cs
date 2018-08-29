using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Mediator
{
    public abstract string Name { get; }

    public abstract List<string> MsgList { get; }

    public abstract void Execute(INotifier inofifier);
}

