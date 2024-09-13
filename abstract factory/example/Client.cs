namespace GOF.abstract_factory.example
{
    class Client
    {
        private AbstractCar abstractCar;
        private AbstractEngine abstractEngine;
        public Client(CarFactory carFactory)
        {
            abstractCar = carFactory.CreateCar();
            abstractEngine = carFactory.CreateEngine();
        }
        public int RunMaxSpeed()
        {
            return abstractCar.MaxSpeed(abstractEngine);
        }
        public override string ToString()
        {
            return abstractCar.ToString();
        }
    }
}
