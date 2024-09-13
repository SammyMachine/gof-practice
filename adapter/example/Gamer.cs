namespace GOF.adapter.example
{
    public class Gamer
    {
        public string Name { get; set; }

        public Gamer(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public int ThrowDice(IGame interfaceGame)
        {
            return interfaceGame.Throw();
        }
    }
}
