using System;

namespace GOF.adapter.example
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            Gamer firstGamer = new Gamer("Ivan");
            Console.WriteLine("Points of {0} are {1}", firstGamer.Name, firstGamer.ThrowDice(dice));
            Coin coin = new Coin();
            IGame adapterForCoin = new Adapter(coin);
            Console.WriteLine("Coin is {0} for player {1}", firstGamer.ThrowDice(adapterForCoin), firstGamer.Name);
        
        }
    }
}
