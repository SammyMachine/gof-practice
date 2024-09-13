using System;

namespace GOF.adapter.example
{
    public class Coin
    {
        private readonly Random r;
        public Coin() {
            r = new Random();
        }

        public int ThrowCoin()
        {
            int res = r.Next(2) + 1;
            return res;
        }
    }
}
