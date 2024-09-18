using System;

namespace GOF.strategy.study
{
    internal class CarRoute : RouteStrategy
    {
        public override void BuildRoute(string start, string end)
        {
            Console.WriteLine($"Прокладываем маршрут для автомобиля от {start} до {end}.");
        }
    }
}