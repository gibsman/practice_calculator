namespace SimpleCalculator.Sorters
{
    /// <summary>
    /// Insertion sorting
    /// </summary>
    public class Insertion : ISorters
    {
        /// <summary>
        /// Method that describes insertion sorting
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
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
