using System;

namespace GOF.template_method.study
{
    internal class Latte : Coffee
    {
        protected override void AddCoffee()
        {
            Console.WriteLine("Добавление эспрессо для латте...");
        }

        protected override void AddSugarAndMilk()
        {
            Console.WriteLine("Добавление молока...");
        }

        protected override void AddTopping()
        {
            Console.WriteLine("Добавление пены...");
        }
    }
}