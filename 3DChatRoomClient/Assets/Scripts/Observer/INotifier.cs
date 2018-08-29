using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class INotifier
{
    public string msg;
    public object body;
    public string sender;

    public INotifier()
    {

    }

    public INotifier(string msg,object body,string sender)
    {
        this.msg = msg;
        this.body = body;
        this.sender = sender;
    }

    public INotifier(string msg,object body):this(msg,body,string.Empty)
    {

    }

    public INotifier(string msg)
        : this(msg, null, string.Empty)
    {

    }
}

