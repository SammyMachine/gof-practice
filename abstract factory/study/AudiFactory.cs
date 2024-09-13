using GOF.abstract_factory.example;

namespace GOF.abstract_factory.study
{
    class AudiFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new AudiCar("Audi", "Купе");
        }

        public override AbstractEngine CreateEngine()
        {
            return new AudiEngine();
        }
    }
}
