﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Threading;
using UnityEditor;
using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ClickSmile : MonoBehaviour, IPointerClickHandler
{
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("スマイルください");
        GameManager.Instance.w2 += 5;
        /*
        GameManager.Instance.EmotionPlus();
        if (GameManager.Instance.w > 5)
        {
            GameManager.Instance.w -= 5;
        }
        */
    }
}
