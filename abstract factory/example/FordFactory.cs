namespace GOF.abstract_factory.example
{
    internal class FordFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд", "Седан");
        }

        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }
    }
}