using System;
using System.Collections.Generic;

//すでに引いたカードを記憶しておくリストクラス
public class DrawnCard
{
    private bool[,] drawnCard = new bool[4, 14];

    public DrawnCard()
    {
        for(int i = 0; i < 4; i++)
        {
            for(int j = 0; j < 14; j++)
            {
                drawnCard[i, j] = false;
            }
        }
    }

    //すでに引いたカードか確認する
    public bool DrawnCardCheck(int type, int number)
    {
        return drawnCard[type,number];
    }


    public bool[,] GetDrawnCardList()
    {
        return drawnCard;
    }

    public void SetDrawnCard(int type,int number)
    {
        drawnCard[type,number] = true;
    }

}