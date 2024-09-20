using System;

namespace GOF.decorator.example
{
    public abstract class AutoBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double CostBase { get; set; }

        public abstract double GetCost();

        public override string ToString()
        {
            string s = String.Format("Ваш автомобиль: \n{0} \nОписание: {1} \nСтоимость {2}\n",
            Name, Description, GetCost());
            return s;
        }
    }
}