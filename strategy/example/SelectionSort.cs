namespace GOF.strategy.example
{
    internal class SelectionSort : StrategySort

    {
        public SelectionSort()
        {
            Title = "Сортировка выбором";
        }

        public override string ToString()
        {
            return Title;
        }

        public override void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int k = i;
                for (int j = i + 1; j < array.Length; j++)
                    if (array[k] > array[j])
                        k = j;
                if (k != i)
                {
                    int temp = array[k];
                    array[k] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}