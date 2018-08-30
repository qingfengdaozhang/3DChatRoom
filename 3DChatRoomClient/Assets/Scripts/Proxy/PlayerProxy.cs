using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
public class PlayerProxy:MonoBehaviour
{
    private static PlayerProxy playerProxy;
    public static PlayerProxy Instance
    {
        get
        {
            if(playerProxy==null)
            {
                playerProxy = new PlayerProxy();
            }
            return playerProxy;
        }
    }
    private List<GameObject> players;
    private PlayerProxy()
    {
        players = new List<GameObject>();
    }
    //CRUD操作
    public void AddPlayer(GameObject player)
    {
        if(!players.Contains(player))
        {
            players.Add(player);
        }
    }
    public GameObject SelectPlayerById(int id)
    {
        GameObject player = players.Find(x => x.GetComponent<Player>().ID == id);
        return player;
    }
    public void DelectPlayerById(int id)
    {
        GameObject player = players.Find(x => x.GetComponent<Player>().ID == id);
        players.Remove(player);
    }
    public void UpdateTransform(int id,Vector3 position,Vector3 eulerAngles)
    {
        SelectPlayerById(id).transform.position = position;
        SelectPlayerById(id).transform.eulerAngles = eulerAngles;
    }
    public void UpdateNickName(int id,string nickname)
    {
        SelectPlayerById(id).GetComponent<Player>().NickName.text = nickname;
    }
    public void UpdateWord(int id, string word)
    {
        SelectPlayerById(id).GetComponent<Player>().Context.text = word;
    }
}
