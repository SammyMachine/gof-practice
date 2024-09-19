using System;

namespace GOF.template_method.study
{
    internal abstract class Coffee
    {
        public void MakeCoffee()
        {
            BoilWater();
            AddCoffee();
            AddSugarAndMilk();
            PourInCup();
            AddTopping();
        }

        private void BoilWater()
        {
            Console.WriteLine("Кипячение воды...");
        }

        protected abstract void AddCoffee();

        protected virtual void AddSugarAndMilk()
        {
        }

        private void PourInCup()
        {
            Console.WriteLine("Наливание в чашку...");
        }

        protected virtual void AddTopping()
        {
        }
    }
}