﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.adapter.study
{
    public class CelsiusTemperatureAdapter : ITemperatureSensor
    {
        private readonly FahrenheitTemperatureSensor fahrenheitSensor;

        public CelsiusTemperatureAdapter(FahrenheitTemperatureSensor fahrenheitSensor)
        {
            this.fahrenheitSensor = fahrenheitSensor;
        }

        public double GetTemperature()
        {
            double tempFahrenheit = fahrenheitSensor.GetTemperature();
            return (tempFahrenheit - 32) * 5 / 9;
        }
    }
}
