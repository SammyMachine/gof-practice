﻿namespace GOF.strategy.example
{
    internal class BubbleSort : StrategySort
    {
        public BubbleSort()
        {
            Title = "Пузырьковая сортировка";
        }

        public override string ToString()
        {
            return Title;
        }

        public override void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}