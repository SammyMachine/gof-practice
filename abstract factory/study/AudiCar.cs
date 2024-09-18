using GOF.abstract_factory.example;

namespace GOF.abstract_factory.study
{
    internal class AudiCar : AbstractCar
    {
        public AudiCar(string name, string bodyType)
        {
            Name = name;
            BodyType = bodyType;
        }

        public override int MaxSpeed(AbstractEngine engine)
        {
            return engine.maxSpeed;
        }

        public override string ToString()
        {
            return $"Автомобиль {Name}, Кузов: {BodyType}";
        }
    }
}