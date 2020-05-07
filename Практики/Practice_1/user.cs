using System;

public class User
{
    private int total_value = 100;
    public int bet;
    public int Bet(int this_bet)
    {
        if (this_bet > 0 && this_bet <= total_value)
        {
            Console.WriteLine("Ставки сделаны");
            
            return this_bet;
        }else
        {
            return 0;
        }

    }
}
