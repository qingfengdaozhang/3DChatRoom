using System.Collections;
using System.Net;
using System.Net.Sockets;
using System.Text;
using UnityEngine;

public class ListenerSocket:MonoBehaviour
{

    private static ListenerSocket userProxy;

    public static ListenerSocket Instance
    {
        get
        {
            if (userProxy == null)
            {
                userProxy = new ListenerSocket();
            }
            return userProxy;
        }
    }


    private const string SOCKETIP = "";
    private const int SOCKETPORT = 7788;

    private  Socket socket;

    private NetworkStream listenerStream;

    public void Connect()
    {
        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        IPAddress iPAddress = IPAddress.Parse(SOCKETIP);
        IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, SOCKETPORT);
        socket.Connect(iPEndPoint);
        Debug.Log("连接成功");
        StartCoroutine(listenerdata());
    }
    public void SendData(INotifier data)
    {
        if(socket!=null)
        {
            string message = JsonUtility.ToJson(data);
            socket.Send(Encoding.UTF8.GetBytes(message));
        }
    }
    IEnumerator listenerdata()
    {
        if (socket != null)
        {
            byte[] data = new byte[2048];
            int length = socket.Receive(data);
            string message = Encoding.UTF8.GetString(data, 0, length);
            //处理message
            INotifier notifier = JsonUtility.FromJson<INotifier>(message);

            switch(notifier.msg)
            {
                //移动
                case "01":       
                    break;
                //对话
                case "02":
                    break;
                //状态--进入
                case "03":
                    break;
                //状态--离开
                case "04":
                    break;
            }
        }
        yield return null;
        StartCoroutine(listenerdata());
    }
}
