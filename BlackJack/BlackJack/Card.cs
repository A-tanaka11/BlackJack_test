using System;
using System.Windows.Forms;

public class Card
{
    public Card(int Type,int Number)
    {
        type = Type;
        number=Number;
    }

    public int type;        //タイプ
    public int number;      //数字

    public int Type
    {
        set { type = value; }
        get { return type; }
    }

    public int Number
    {
        set { number = value; }
        get { return number; }
    }
}