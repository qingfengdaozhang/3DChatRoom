using System.Collections;
using UnityEngine;

public class ApplicationServer:MonoBehaviour
{
    private static ApplicationServer userProxy;

    public static ApplicationServer Instance
    {
        get
        {
            if (userProxy == null)
            {
                userProxy = new ApplicationServer();
            }
            return userProxy;
        }
    }


    private const string LOGINURL = "";
    private const string REGISTERURL = "";
    private const string USERNAME = "username";
    private const string PASSWORD = "password";
    public void Login(string username,string password)
    {
        StartCoroutine(login(username, password));
    }
    IEnumerator login(string username,string password)
    {
        WWWForm form = new WWWForm();
        form.AddField(USERNAME, username);
        form.AddField(PASSWORD, password);
        WWW www = new WWW(LOGINURL, form);
        yield return www;
        if(www.error!=null)
        {
            //回传值
        }
    }
    public void Register(string username,string password)
    {
        StartCoroutine(register(username, password));
    }
    IEnumerator register(string username,string password)
    {
        WWWForm form = new WWWForm();
        form.AddField(USERNAME, username);
        form.AddField(PASSWORD, password);
        WWW www = new WWW(REGISTERURL, form);
        yield return www;
        if (www.error != null)
        {
            //回传值
        }
    }
}
