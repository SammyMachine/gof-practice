using GOF.factory_method.example;

namespace GOF.factory_method.study
{
    internal class DrunkDriverService : TransportService
    {
        public int rate { get; set; }

        public DrunkDriverService(string name, int rate) : base(name)
        {
            this.rate = rate;
        }

        public override double CostTransportation(double distance)
        {
            return distance * rate * 1.5;
        }

        public override string ToString()
        {
            return $"Фирма {Name}, услуга пьяного водителя, тариф {rate}";
        }
    }
}