using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class UserProxy:MonoBehaviour
{
    private static UserProxy userProxy;

    public static UserProxy Instance
    {
        get
        {
            if (userProxy == null)
            {
                userProxy = new UserProxy();
            }
            return userProxy;
        }
    }

    private User user;

    private UserProxy()
    {
        user = new User();
    }
    public void Update(User user)
    {
        this.user = user;
    }
    public void Update(string nickname)
    {
        user.NickName = nickname;
    }
}
