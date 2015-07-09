using System.Collections.Generic;

namespace SimpleCalculator.Sorters
{
    /// <summary>
    /// Bucket sorting
    /// </summary>
    public class Bucket : ISorters
    {
        /// <summary>
        /// Method that describes bucket sorting
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public int[] Sort(int[] items)
        {
            int maxValue = items[0];
            int minValue = items[0];

            for (int i = 1; i < items.Length; i++)
            {
                if (items[i] > maxValue)
                    maxValue = items[i];

                if (items[i] < minValue)
                    minValue = items[i];
            }
            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < items.Length; i++)
            {
                bucket[items[i] - minValue].Add(items[i]);
            }

            int position = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        items[position] = bucket[i][j];
                        position++;
                    }
                }
            }
            return items;
        }
    }
}
