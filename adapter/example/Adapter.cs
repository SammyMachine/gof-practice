namespace GOF.adapter.example
{
    public class Adapter : IGame
    {
        private Coin coin;

        public Adapter(Coin coin)
        {
            this.coin = coin;
        }

        public int Throw()
        {
            return coin.ThrowCoin();
        }
    }
}