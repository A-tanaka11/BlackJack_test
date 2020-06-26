using BlackJack;
using System;
using System.Collections.Generic;

public class Player
{
    private List<Card> cards = new List<Card>();
    Random random = new Random((int)DateTime.Now.Ticks);

    private Calculation calculation;    //計算
    
    public Player()
    {
        calculation = new Calculation();
    }

    //カードを引く
    public void DrawCard(DrawnCard drawnCard)
    {
        int type = random.Next(0);
        int number = random.Next(1, 8);

        ////すでに引いたカードかチェック
        bool drawn = drawnCard.DrawnCardCheck(type, number);

        //まだ引いてないカードが出るまで引く
        while (drawn)
        {
            type = random.Next(0);
            number = random.Next(1, 8);
            drawn = drawnCard.DrawnCardCheck(type, number);
        }
        //カードの作成
        Card card = new Card(type, number);
        //引いたカードを引いたカードリストに登録
        drawnCard.SetDrawnCard(type, number);
        //カードをリストに追加
        cards.Add(card);
       
    }


    public int Total()
    {
        int total = 0;
        
        foreach(Card card in cards)
        {
            total += calculation.ConvertTo10(card.Number);
        }
        return total;
    }

    public List<Card> GetCards()
    {
        return cards;
    }

    public Calculation GetCalculation()
    {
        return calculation;
    }

}