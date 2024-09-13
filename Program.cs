using GOF.adapter.study;
using GOF.adapter.example;
using System;
using GOF.abstract_factory.example;
using GOF.abstract_factory.study;

namespace GOF
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Адаптер, пример");
            Console.WriteLine("-------------------------------------------------------------------");
            Dice dice = new Dice();
            Gamer firstGamer = new Gamer("Иван");
            Console.WriteLine("Кость показала игроку {0} значение {1}", firstGamer.Name, firstGamer.ThrowDice(dice));
            Coin coin = new Coin();
            IGame adapterForCoin = new Adapter(coin);
            Console.WriteLine("Монета показала {0} игроку {1}", firstGamer.ThrowDice(adapterForCoin), firstGamer.Name);
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("\nАдаптер, контрольное задание");
            Console.WriteLine("-------------------------------------------------------------------");
            FahrenheitTemperatureSensor fahrenheitSensor = new FahrenheitTemperatureSensor();
            Console.WriteLine("Температура в Фаренгейтах: " + fahrenheitSensor.GetTemperature());
            ITemperatureSensor celsiusAdapter = new CelsiusTemperatureAdapter(fahrenheitSensor);
            Console.WriteLine("Температура в Цельсиях: " + celsiusAdapter.GetTemperature());
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("\nАбстрактная фабрика, пример");
            Console.WriteLine("-------------------------------------------------------------------");
            CarFactory fordCar = new FordFactory();
            Client firstClient = new Client(fordCar);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час",
                firstClient.ToString(), firstClient.RunMaxSpeed());

            Console.WriteLine("\nАбстрактная фабрика, контрольное задание");
            Console.WriteLine("-------------------------------------------------------------------");
            CarFactory audiCar = new AudiFactory();
            Client secondClient = new Client(audiCar);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час", 
                secondClient.ToString(), secondClient.RunMaxSpeed());
            Console.WriteLine("-------------------------------------------------------------------");

        }
    }
}
