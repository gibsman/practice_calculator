namespace SimpleCalculator
{
    public class Insertion : ISorters
    {
        public int[] Sort(int[] items)
        {
            int[] result = new int[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                int j = i;
                while (j > 0 && result[j - 1] > items[i])
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = items[i];
            }
            return result;

        }
    }
}
