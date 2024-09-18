using GOF.factory_method.example;

namespace GOF.factory_method.study
{
    internal class DrunkDriverTransCom : TransportCompany
    {
        public DrunkDriverTransCom(string n) : base(n)
        {
        }

        public override TransportService Create(string name, int rate)
        {
            return new DrunkDriverService(name, rate);
        }
    }
}