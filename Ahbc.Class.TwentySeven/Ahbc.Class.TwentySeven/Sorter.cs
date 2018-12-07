using System;

namespace Ahbc.Class.TwentySeven
{
    public class Sorter
    {
        public int[] BubbleSort(int[] numbers)
        {
            if (numbers == null)
            {
                return null;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        var temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }

            return numbers;
        }
    }
}
