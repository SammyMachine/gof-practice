using System;

namespace GOF.adapter.example
{
    public class Dice : IGame
    {
        private readonly Random r;

        public Dice()
        {
            r = new Random();
        }

        public int Throw()
        {
            int res = r.Next(6) + 1;
            return res;
        }
    }
}