using GOF.decorator.example;

namespace GOF.decorator.study
{
    internal class Mercedes : AutoBase
    {
        public Mercedes(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }

        public override double GetCost()
        {
            return CostBase * 1.25;
        }
    }
}