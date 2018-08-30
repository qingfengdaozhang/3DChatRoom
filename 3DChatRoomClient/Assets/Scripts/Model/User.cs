using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    private int id;
    public int ID
    {
        set { id = value; }
        get { return id; }
    }//用户ID

    private string username;
    public string UserName
    {
        set { username = value; }
        get { return username; }
    }//用户名
    private string password;
    public string Password
    {
        set { password = value; }
        get { return password; }
    }//密码


    private string nickname;
    public string NickName
    {
        set { nickname = value; }
        get { return nickname; }
    }//用户昵称
}
