namespace Addition4
{
    public class Add4
    {
        public static void PrintArray(int[,] array, int arraySize)
        {
            Console.WriteLine("Массив: ");
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arraySize; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }    
        public static int[,] FillArray(int arraySize, int begin, int end)
        {
            Random rand = new Random();
            int[,] array = new int[arraySize, arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    array[i, j] = rand.Next(begin, end);
                }
            }
            return array;
        }
        public static int Sum(int[,] array, int arraySize)
        {
            int sum = 0;
            for (var i = 0; i < arraySize; i++)
            {
                for (var j = 0; j < arraySize; j++)
                {
                    if ((i + j) % 2 == 0)
                        sum += array[i, j];
                }
            }
            Console.WriteLine();
            Console.Write("Сумма элементов на четных позициях = " + sum);
            return sum;
        }

    }
}