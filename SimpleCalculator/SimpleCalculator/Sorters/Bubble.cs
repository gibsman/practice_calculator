namespace SimpleCalculator
{
    public class Bubble : ISorters
    {
        public int[] Sort(int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[j] < items[i])
                    {
                        var temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }
            return items;
        }
    }
}
