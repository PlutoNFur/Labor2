namespace Addition3
{
    public class Add3
    {
        public static void Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine("Сумма неотрицательных элементов = " + sum);
        }
    }
}

