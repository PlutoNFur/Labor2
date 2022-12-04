using System;
namespace Addition
{
    public static class Class1
    {
        public static void PrintArray(int[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public static int CreateSize()
        {
            Console.WriteLine("Введите размер ");
            var strSize = Console.ReadLine();
            int size = 0;
            if (int.TryParse(strSize, out size) && size > 0)
            {
                int[] array = new int[size];
            }
            return size;
        }
        public static int[] FillArray(int arraySize, int begin, int end)
        {
            Random rand = new Random();
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = rand.Next(begin, end);
            }
            return array;
        }
    }
}