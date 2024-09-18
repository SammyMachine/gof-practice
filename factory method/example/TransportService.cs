namespace GOF.factory_method.example
{
    internal abstract class TransportService
    {
        public string Name { get; set; }

        public TransportService(string name)
        {
            Name = name;
        }

        public abstract double CostTransportation(double distance);
    }
}