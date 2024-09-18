namespace GOF.factory_method.example
{
    internal abstract class TransportCompany
    {
        public string Name { get; set; }

        public TransportCompany(string n)
        {
            Name = n;
        }

        public override string ToString()
        {
            return Name;
        }

        public abstract TransportService Create(string n, int k);
    }
}