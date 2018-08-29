using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
public class PlayerProxy:MonoBehaviour
{
    private static PlayerProxy playerProxy;
    public PlayerProxy Instance
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
    private List<Player> players;
    private PlayerProxy()
    {
        players = new List<Player>();
    }
    //CRUD操作
    public void AddPlayer(Player player)
    {
        if(!players.Contains(player))
        {
            players.Add(player);
        }
    }
    public void UpdatePlayerById(Player player)
    {
        Player pl = players.Find(x=>x.ID==player.ID);
        pl = player;
    }
    public Player SelectPlayerById(int id)
    {
        Player player = players.Find(x => x.ID == id);
        return player;
    }
    public void DelectPlayerById(int id)
    {
        Player player = players.Find(x => x.ID == id);
        players.Remove(player);
    }
}
