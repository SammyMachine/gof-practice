using GOF.abstract_factory.example;
using GOF.abstract_factory.study;
using GOF.adapter.example;
using GOF.adapter.study;
using GOF.factory_method.example;
using GOF.factory_method.study;
using GOF.singleton.example;
using GOF.singleton.study;
using GOF.strategy.example;
using GOF.strategy.study;
using GOF.template_method.example;
using GOF.template_method.study;
using System;
using System.IO;

namespace GOF
{
    public class Program
    {
        private static void Main(string[] args)
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

            Console.WriteLine("\nФабричный метод, пример");
            Console.WriteLine("-------------------------------------------------------------------");
            TransportCompany transportCompany = new TaxiTransCom("Служба такси");
            TransportService compService = transportCompany.Create("Такси", 1);
            double dist = 15.5;
            PrintTransportService(compService, dist);
            TransportCompany gCom = new ShipTransCom("Служба перевозок");
            compService = gCom.Create("Грузоперевозки", 2);
            double distg = 150.5;
            PrintTransportService(compService, distg);
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("\nФабричный метод, контрольное задание");
            Console.WriteLine("-------------------------------------------------------------------");
            TransportCompany drunkCompany = new DrunkDriverTransCom("Служба Пьяный водитель");
            compService = drunkCompany.Create("Пьяный водитель", 3);
            double distD = 20.1;
            PrintTransportService(compService, distD);
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("\nОдиночка, пример");
            Console.WriteLine("-------------------------------------------------------------------");
            Log lg = Log.MyLog;
            lg.LogExecution("Метод Main()");
            double op = Operation.Run('-', 35);
            op = Operation.Run('+', 30);
            using (StreamReader reader = new StreamReader("C:\\Users\\polen\\Projects\\VisualStudioProjects\\GOF\\log.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("\nОдиночка, контрольное задание");
            Console.WriteLine("-------------------------------------------------------------------");
            CarFactory fordCarSecond = FordFactorySecond.Instance;
            Client thirdClient = new Client(fordCarSecond);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час",
                thirdClient.ToString(), thirdClient.RunMaxSpeed());
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("\nСтратегия, пример");
            Console.WriteLine("-------------------------------------------------------------------");
            int[] arr1 = { 31, 15, 10, 2, 4, 2, 14, 23, 12, 66 };
            StrategySort sort = new SelectionSort();
            Context context = new Context(sort, arr1);
            context.Sort();
            context.PrintArray();
            Console.WriteLine("");
            int[] arr2 = { 1, 5, 10, 2, 4, 12, 14, 23, 12, 66 };
            sort = new InsertionSort();
            context = new Context(sort, arr2);
            context.Sort();
            context.PrintArray();
            Console.WriteLine("");
            int[] arr3 = { 15, 78, 10, 2, 40, 12, 7, 23, 12, 100 };
            sort = new BubbleSort();
            context = new Context(sort, arr3);
            context.Sort();
            context.PrintArray();
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("\nСтратегия, контрольное задание");
            Console.WriteLine("-------------------------------------------------------------------");
            Navigator navigator = new Navigator(new CarRoute());
            navigator.BuildRoute("A", "B");

            navigator.SetStrategy(new PedestrianRoute());
            navigator.BuildRoute("A", "B");

            navigator.SetStrategy(new BicycleRoute());
            navigator.BuildRoute("A", "B");

            navigator.SetStrategy(new PublicTransportRoute());
            navigator.BuildRoute("A", "B");

            navigator.SetStrategy(new TouristRoute());
            navigator.BuildRoute("A", "B");
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("\nШаблонный метод, пример");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Введите начальное значение: ");
            int f = int.Parse(Console.ReadLine());

            Console.Write("Введите конечное значение: ");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Введите шаг прогрессии: ");
            int h = int.Parse(Console.ReadLine());
            Progression val = new ArithmeticProgression(f, l, h);
            val.TemplateMethod();
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("\nШаблонный метод, контрольное задание");
            Console.WriteLine("-------------------------------------------------------------------");

            Console.Write("Введите начальное значение: ");
            f = int.Parse(Console.ReadLine());

            Console.Write("Введите конечное значение: ");
            l = int.Parse(Console.ReadLine());

            Console.Write("Введите шаг прогрессии: ");
            h = int.Parse(Console.ReadLine());
            val = new GeometricProgression(f, l, h);
            val.TemplateMethod();

            Console.WriteLine("-------------------------------------------------------------------");
        }

        private static void PrintTransportService(TransportService compTax, double distg)
        {
            Console.WriteLine("Компания {0}, расстояние {1}, стоимость: {2}",
            compTax.ToString(), distg, compTax.CostTransportation(distg));
        }
    }
}