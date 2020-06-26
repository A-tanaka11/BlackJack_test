using System;
using System.Windows.Forms;


public class Calculation
{

    public int total;
   
   
    public Calculation()
    {

        total = 0;
       
    }

    public int ConvertTo10(int a)
    {

        if(a > 10)
        {
            a = 10;
        }

        return a;
    }

    public bool Burst(int total)
    {
        if(total >= 22)
        {
            return true;
        }

        return false;
    }


    public string Km(int totalP,int totalD)
    {
        string sh="";
        if ((totalP > totalD) &&(totalP <= 21))
        {
            sh = "勝ち";
        }
        else if ((totalP < totalD) && (totalD <= 21))
        {
            sh = "負け";
        }
        else if (totalP >= 22)
        {
            sh = "負け";
        }
        else if (totalD >= 22)
        {
            sh = "勝ち";
        }
        else if (totalP == totalD)
        {
            sh = "引き分け";
        }
        return sh;
    }
   
}
