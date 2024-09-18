using System;

namespace GOF.strategy.study
{
    internal class PublicTransportRoute : RouteStrategy
    {
        public override void BuildRoute(string start, string end)
        {
            Console.WriteLine($"Прокладываем маршрут на общественном транспорте от {start} до {end}.");
        }
    }
}