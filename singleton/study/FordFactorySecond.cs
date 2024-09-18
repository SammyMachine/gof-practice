using GOF.abstract_factory.example;
using System;

namespace GOF.singleton.study
{
    internal class FordFactorySecond : CarFactory
    {
        private FordFactorySecond()
        { }

        private static Lazy<FordFactorySecond> instance = new Lazy<FordFactorySecond>(() => new FordFactorySecond());

        public static FordFactorySecond Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд", "Пикап");
        }

        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }
    }
}