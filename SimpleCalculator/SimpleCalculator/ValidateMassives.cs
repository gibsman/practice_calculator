using System;

namespace SimpleCalculator
{
    public static class ValidateMassives
    {
        public static int[] ValidateAndConvert(string input)
        {
            string[] splittedString = input.Split(' ');
            int[] mas = new int[splittedString.Length];
            for (int i = 0; i < splittedString.Length; i++)
            {
                int element;
                if (int.TryParse(splittedString[i], out element) == false)
                {
                    throw new Exception("Unexpected symbol in input area");
                }
                mas[i] = Convert.ToInt32(splittedString[i]);
            }
            return mas;
        }
    }
}
