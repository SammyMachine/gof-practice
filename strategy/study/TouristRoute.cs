using System;

namespace GOF.strategy.study
{
    internal class TouristRoute : RouteStrategy
    {
        public override void BuildRoute(string start, string end)
        {
            Console.WriteLine($"Прокладываем туристический маршрут от {start} до {end}, включая достопримечательности.");
        }
    }
}