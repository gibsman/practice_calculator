namespace SimpleCalculator.Sorters
{
    /// <summary>
    /// Selection sorting
    /// </summary>
    public class Selection : ISorters
    {
        /// <summary>
        /// Method that describes selection sorting
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public int[] Sort(int[] items)
        {
            int length = items.Length;

            for (int i = 0; i < length - 1; i++)
            {
                var min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (items[j] < items[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var temp = items[i];
                    items[i] = items[min];
                    items[min] = temp;
                }
            }
            return items;
        }
    }
}
