using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player:MonoBehaviour
{
    private int id;
    public int ID { set { id = value; } get { return id; } }//player id

    [SerializeField]
    private TextMesh context;
    public TextMesh Context { set { context = value; }get { return context; } }//聊天内容

    [SerializeField]
    private TextMesh nickname;
    public TextMesh NickName { set { nickname = value; } get { return nickname; } } //昵称

}
