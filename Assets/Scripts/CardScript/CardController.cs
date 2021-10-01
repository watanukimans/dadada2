﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    public CardView view; // カードの見た目の処理
    public CardModel model; // カードのデータを処理

    private void Awake()
    {
        view = GetComponent<CardView>();
    }

    public void Init(int cardID) // カードを生成した時に呼ばれる関数
    {
        model = new CardModel(cardID); // カードデータを生成
        view.Show(model); // 表示
    }
    //お試し裏面
    public void Initura(int cardID) // カードを生成した時に呼ばれる関数
    {
        model = new CardModel(cardID); // カードデータを生成
        view.Showura(model); // 表示
    }
    public void DestroyCard(CardController card)
    {
        Destroy(card.gameObject);
    }
}
