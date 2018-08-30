using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
public class AppFacade:MonoBehaviour
{
    public static AppFacade Instance;
    Controller controller;
    View view;

    public void Awake()
    {
        Instance = this;
        controller = new Controller();
        view = new View();

        PeopleCommand peopleCommand = new PeopleCommand();
        RestierCommand("Create", peopleCommand);
        RestierCommand("Move", peopleCommand);
        RestierCommand("ShowNickName", peopleCommand);
        RestierCommand("ChattingWord", peopleCommand);

        //this.ResierView(new UIMediator());
    }

    public void ResierView(Mediator mediator)
    {
        if (mediator != null)
        {
            view.ResiterView(mediator);
        }
    }

    public void ExcuteToView(INotifier notifier)
    {
        if (notifier != null)
        {
            view.Excute(notifier);
        }
    }

    public void RestierCommand(string msg, ICommand command)
    {
        this.controller.ResiterCommand(msg, command);
    }

    public void Excute(INotifier inotifier)
    {
        this.controller.ExcuteCommand(inotifier);

    }

}