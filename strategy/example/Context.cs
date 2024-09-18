using System;

namespace GOF.strategy.example
{
    internal class Context
    {
        private StrategySort strategy;
        private int[] array;

        public Context(StrategySort strategy, int[] array)
        {
            this.strategy = strategy;
            this.array = array;
        }

        public void Sort()
        {
            strategy.Sort(array);
        }

        public void PrintArray()
        {
            Console.WriteLine(strategy.ToString());
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}