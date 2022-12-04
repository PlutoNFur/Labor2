namespace Addition1
{
    public class Add1
    {
        public static void MaxValue(int[] array)
        {
            int max = int.MinValue;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine("Максимальный элемент: " + max);
        }
        public static void MinValue(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Минимальный элемент: " + min);
        }
        public static void Sorting(int[] array)
        {
            int temp = 0;

            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

        }

    }
}
