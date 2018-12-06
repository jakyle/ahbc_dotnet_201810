using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahbc.Class.TwentySix
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator +(Point b, Point c)
        {
            return new Point { X = b.X + c.X, Y = b.Y + c.Y};
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Braces.IsBalanced("(())"));
            Console.WriteLine(Braces.IsBalanced("}}{"));
            Console.WriteLine(Braces.IsBalanced("([])"));

            int numberOne = 2;
            int? numberTwo = numberOne;
            int numberThree = (int)numberTwo;
            
            string name = null;

            Console.WriteLine(numberTwo);
            Console.WriteLine(name);
            
            var one = new Point { X = 5, Y = 4 };
            var two = new Point { X = 4, Y = 5 };
            var three = one + two;

            var numbers = new[] { 8, 600, 7, 5000, 30000, 0, 9};
            Console.WriteLine(string.Join(" ", numbers));
            // Console.WriteLine(string.Join(" ", BubbleSort(numbers)));
            Console.WriteLine(string.Join(" ", MergeSort(numbers.ToList())));

            Console.ReadKey();
        }

        public static int[] BubbleSort(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        var temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }

            return input;
        }

        private static List<int> MergeSort(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)  //Dividing the unsorted list
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}