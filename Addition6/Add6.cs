namespace Addition6
{
    public class Add6
    {
        public static void Double (int[] array)
        {
            string res = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                res += array[i] + " ";
                if (array[i] < 0)
                    res += array[i] + " ";
            }
            Console.WriteLine("\nМассив после дублирования: ");
            Console.WriteLine(res);
        }
        
    }
}