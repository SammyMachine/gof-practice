﻿namespace GOF.abstract_factory.example
{
    internal abstract class AbstractCar
    {
        public string Name { get; set; }
        public string BodyType { get; set; }

        public abstract int MaxSpeed(AbstractEngine engine);
    }
}