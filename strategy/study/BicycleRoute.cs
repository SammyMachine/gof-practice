using System;

namespace GOF.strategy.study
{
    internal class BicycleRoute : RouteStrategy
    {
        public override void BuildRoute(string start, string end)
        {
            Console.WriteLine($"Прокладываем веломаршрут от {start} до {end}.");
        }
    }
}