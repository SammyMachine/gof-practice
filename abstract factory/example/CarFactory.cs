namespace GOF.abstract_factory.example
{
    internal abstract class CarFactory
    {
        public abstract AbstractCar CreateCar();

        public abstract AbstractEngine CreateEngine();
    }
}