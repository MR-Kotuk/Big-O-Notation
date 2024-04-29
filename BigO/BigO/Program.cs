using System;

namespace BigO
{
    public class Program
    {
        public static void Main()
        {
            BigOExamples bigOExamples = new BigOExamples();

            int[] array = { 57, 64, 52, 43, 20, 272, 27, 1, 82, 4 };

            Array.Sort(array);
            Console.WriteLine(bigOExamples.BinarySearch(array, 64));
        }
    }

    public class BigOExamples
    {
        //  O(1)
        public void Example1(int[] array)
        {
            Console.WriteLine(array[0]);
        }

        //  O(n)
        public void Example2(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }

        //  O(n^2)
        public void Example3(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int y = 0; y < array.Length; y++)
                    Console.WriteLine(array[y]);
        }

        //  O(2^n)
        public void Example4(int[] array)
        {
            for (int i = 0; i < Math.Pow(2, array.Length); i++)
                Console.WriteLine(array[i]);
        }

        //  O(log n)
        public void Example5(int[] array)
        {
            for (int i = 0; i < array.Length; i *= 2)
                Console.WriteLine(array[i]);
        }

        //  O(n log n)
        public void Example6(int[] array)
        {
            Array.Sort(array);

            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }

        //  O(n!)
        public int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int middle = 0;
            int right = array.Length;

            while (left <= right)
            {
                middle = (left + right) / 2;

                if (array[middle] == target)
                    return middle;

                if (array[middle] < target)
                    left = middle;
                else if (array[middle] > target)
                    right = middle;
            }

            return -1;
        }
    }
}
