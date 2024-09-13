namespace GOF.abstract_factory.example
{
    class FordCar : AbstractCar
    {
        public FordCar(string name, string bodyType)
        {
            Name = name;
            BodyType = bodyType;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            int maxSpeed = engine.maxSpeed;
            return maxSpeed;
        }
        public override string ToString()
        {
            return $"Автомобиль {Name}, Кузов: {BodyType}";

        }
    }
}
