using System;

namespace GOF.factory_method.example
{
    internal class Shipping : TransportService
    {
        public double Tariff { get; set; }

        public Shipping(string name, int taff) :
        base(name)
        {
            Tariff = taff;
        }

        public override double CostTransportation(double distance)
        {
            return distance * Tariff;
        }

        public override string ToString()
        {
            string s = String.Format("Фирма {0}, доставка по тарифу {1}",
            Name, Tariff);
            return s;
        }
    }
}