using GOF.decorator.example;

namespace GOF.decorator.study
{
    internal class LeatherInterior : DecoratorOptions
    {
        public LeatherInterior(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". С кожаным салоном";
            Description = p.Description + ". " + this.Title + ". Кожаный салон";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 30.99;
        }
    }
}