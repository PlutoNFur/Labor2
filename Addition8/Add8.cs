namespace Addition8
{
    public class Add8
    {
        public static void EnterDesiredElement(int[] array)
        {
            int desiredElement;
            Console.WriteLine("Введите искомый элемент: ");
            desiredElement = Convert.ToInt32(Console.ReadLine());
            int index = -1;
            Console.WriteLine("Номера вхождений: ");
            do
            {
                index = Array.IndexOf(array, desiredElement, index + 1);
                if (index != -1)
                {
                    Console.Write(index + 1 + " ");
                }
            }
            while (index != -1);
            
        }
    }
}