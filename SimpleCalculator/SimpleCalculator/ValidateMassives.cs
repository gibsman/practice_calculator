using System;

namespace SimpleCalculator
{
    public class ValidateMassives
    {
        public int[] ValidateAndConvert(string input)
        {
            int element;
            string[] splittedString = input.Split(' ');
            int[] mas = new int[splittedString.Length];
            for (int i = 0; i < splittedString.Length; i++)
            {
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
