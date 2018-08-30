
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UIMediator : Mediator
{
    public override string Name
    {
        get
        {
            return "UIMediator";
        }
    }

    public override List<string> MsgList
    {
        get
        {
            List<string> msgList = new List<string>();
            msgList.Add("UpdateMainUIView");
            return msgList;
        }
    }

    public override void Execute(INotifier inofifier)
    {
        switch(inofifier.msg)
        {
            case "UpdateMainUIView":
                break;
        }
    }
}
