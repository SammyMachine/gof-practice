using System;

namespace GOF.strategy.study
{
    internal class PedestrianRoute : RouteStrategy
    {
        public override void BuildRoute(string start, string end)
        {
            Console.WriteLine($"Прокладываем пеший маршрут от {start} до {end}.");
        }
    }
}