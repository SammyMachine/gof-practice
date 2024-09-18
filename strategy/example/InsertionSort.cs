namespace GOF.strategy.example
{
    internal class InsertionSort : StrategySort
    {
        public InsertionSort()
        {
            Title = "Сортировка вставками";
        }

        public override string ToString()
        {
            return Title;
        }

        public override void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = 0;
                int buffer = array[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buffer)
                        break;
                    array[j + 1] = array[j];
                }
                array[j + 1] = buffer;
            }
        }
    }
}