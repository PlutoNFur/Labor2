namespace Addition9
{
    public class Add9
    {
        public static void Comparison(int[] array1, int[] array2)
        {
            bool equal = Enumerable.SequenceEqual(array1, array2);
            Console.WriteLine("\nМассивы {0}", equal ? "равны" : "не равны");
        }
        public static int[] FillArray1(int arraySize)
        {
            int[] array1 = new int[arraySize];
            Console.WriteLine("Заполнение первого массива ");
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Введите элемент {i + 1} ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            return array1;
        }
        public static int[] FillArray2(int arraySize)
        {
            int[] array2 = new int[arraySize];
            Console.WriteLine("Заполнение второго массива ");
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Введите элемент {i + 1} ");
                array2[i] = int.Parse(Console.ReadLine());
            }
            return array2;
        }
    }
}
