using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

/// <summary>
/// 本类从Unity面板获取实体类
/// </summary>
public class UIProxy:MonoBehaviour
{
    private static UIProxy uiProxy;

    public static UIProxy Instance
    {
        get
        {
            if (uiProxy == null)
            {
                uiProxy = new UIProxy();
            }
            return uiProxy;
        }
    }
    private List<GameObject> UIList;



}
