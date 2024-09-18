using System;

namespace GOF.factory_method.example
{
    internal class TaxiServices : TransportService
    {
        public int Category { get; set; }

        public TaxiServices(string name, int cat) :
        base(name)
        {
            Category = cat;
        }

        public override double CostTransportation(double distance)
        {
            return distance * Category;
        }

        public override string ToString()
        {
            string s = String.Format("Фирма {0}, поездка категории {1}",
            Name, Category);
            return s;
        }
    }
}