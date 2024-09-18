using System;

namespace GOF.adapter.study
{
    public class FahrenheitTemperatureSensor : ITemperatureSensor
    {
        private readonly Random random = new Random();

        public double GetTemperature()
        {
            return 32 + random.NextDouble() * 68;
        }
    }
}