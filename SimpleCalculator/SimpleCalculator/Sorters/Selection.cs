namespace SimpleCalculator.Sorters
{
    public class Selection : ISorters
    {
        public int[] Sort(int[] items)
        {
            int min, temp;
            int length = items.Length;

            for (int i = 0; i < length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (items[j] < items[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = items[i];
                    items[i] = items[min];
                    items[min] = temp;
                }
            }
            return items;
        }
    }
}
