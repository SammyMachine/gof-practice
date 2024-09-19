using System;

namespace GOF.template_method.study
{
    internal class Espresso : Coffee
    {
        protected override void AddCoffee()
        {
            Console.WriteLine("Добавление эспрессо...");
        }
    }
}