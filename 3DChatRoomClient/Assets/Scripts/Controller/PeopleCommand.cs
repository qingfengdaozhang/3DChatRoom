using System.Collections;
using UnityEngine;

public class PeopleCommand : MonoBehaviour ,ICommand{
    PlayerProxy playerProxy = PlayerProxy.Instance;
    /// <summary>
    /// 创建Player
    /// </summary>
    public void Create(GameObject player)
    {
        playerProxy.AddPlayer(player);
    }
    /// <summary>
    /// 创建主角
    /// </summary>
    /// <param name="player"></param>
    /// <param name="main"></param>
    public void Create(GameObject player,bool main)
    {
        //playerProxy.AddPlayer(player);
        GameObject mainCamera = GameObject.Find("MainCamera");
        mainCamera.transform.parent = player.transform;
        playerProxy.AddPlayer(player);
    }
    /// <summary>
    /// 移动
    /// </summary>
    /// <param name="player"></param>
    public void Move(int id,Vector3[] transform)
    {
        playerProxy.UpdateTransform(id, transform[0], transform[1]);
    }
    /// <summary>
    /// 显示昵称
    /// </summary>
    /// <param name="id"></param>
    /// <param name="nickname"></param>
    public void ShowNickName(int id,string nickname)
    {
        playerProxy.UpdateNickName(id, nickname);
    }
    /// <summary>
    /// 聊天
    /// </summary>
    /// <param name="id"></param>
    /// <param name="word"></param>
    public void ChattingWord(int id,string word)
    {
        GameObject player = playerProxy.SelectPlayerById(id);
        player.GetComponent<Player>().Context.text = word;
        //5秒自动清空
        StartCoroutine(quit(player));
    }
    IEnumerator quit(GameObject player)
    {
        yield return new WaitForSeconds(5f);
        player.GetComponent<Player>().Context.text = "";
    }

    public void Excute(INotifier inotifier)
    {
        switch (inotifier.msg)
        {
            case "Create":
                if(inotifier.sender.Equals("mainPlayer"))
                {
                    Create((GameObject)inotifier.body, false);
                }
                else
                {
                    Create((GameObject)inotifier.body);
                }
                break;
            case "Move":
                Move(int.Parse(inotifier.sender), (Vector3[])inotifier.body);
                break;
            case "ShowNickName":
                ShowNickName(int.Parse(inotifier.sender), (string)inotifier.body);
                break;
            case "ChattingWord":
                ChattingWord(int.Parse(inotifier.sender), (string)inotifier.body);
                break;
        }
    }
}
