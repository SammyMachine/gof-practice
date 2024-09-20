using GOF.decorator.example;

namespace GOF.decorator.study
{
    internal class PanoramicRoof : DecoratorOptions
    {
        public PanoramicRoof(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". С панорамной крышей";
            Description = p.Description + ". " + this.Title + ". Панорамная крыша";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 50.99;
        }
    }
}