using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private int id;
    public int ID { set { id = value; } get { return id; } }//player id
    private GameObject gameobject;
    public GameObject Gameobject { set { gameobject = value; }get { return gameobject; } }//player
    private Text context;
    public Text Context { set { context = value; }get { return context; } }//聊天内容
}
