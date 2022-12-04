namespace Addition2
{
    public class Add2
    {
        public static void PrintArrayTripple(int[,,] array, int arraySize)
        {
            Console.WriteLine("Трехмерный массив ");
            for (int m = 0; m < arraySize; m++)
            {
                for (int n = 0; n < arraySize; n++)
                {
                    for (int t = 0; t < arraySize; t++)
                    {

                        Console.Write(array[m, n, t] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        public static int[,,] FillArrayTripple(int arraySize, int begin, int end)
        {
            Random rand = new Random();

            int[,,] array = new int[arraySize, arraySize, arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    for (int k = 0; k < arraySize; k++)
                    {
                        array[i, j, k] = rand.Next(begin, end);
                    }
                }
            }
            return array;
        }
        public static void Replace(int[,,] array, int arraySize)
        {
            for (var n = 0; n < arraySize; n++)
            {
                for (var m = 0; m < arraySize; m++)
                {
                    for (var t = 0; t < arraySize; t++)
                    {
                        if (array[n, m, t] < 0)
                            array[n, m, t] = 0;
                    }
                }
            }
        }
    }
}