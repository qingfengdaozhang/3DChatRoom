using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
public class AccountCommand : MonoBehaviour, ICommand
{
    /// <summary>
    /// 登陆
    /// </summary>
    /// <param name="user"></param>
    public void Login(User user)
    {
        ApplicationServer.Instance.Login(user.UserName, user.Password);
    }
    /// <summary>
    /// 注册
    /// </summary>
    /// <param name="user"></param>
    public void Register(User user)
    {
        ApplicationServer.Instance.Register(user.UserName, user.Password);
    }

    public void Excute(INotifier inotifier)
    {
        switch(inotifier.msg)
        {
            case "Login":
                Login((User)inotifier.body);
                break;
            case "Register":
                Register((User)inotifier.body);
                break;
        }
    }
}
