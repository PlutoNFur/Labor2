using Addition;

namespace Sort
{
    class Task7
    {
        static void Main(string[] args)
        {
            int arraySize = Class1.CreateSize();
            int[] array = Class1.FillArray(arraySize, -100, 100);
            Class1.PrintArray(array);
            Console.WriteLine("Отсортированный массив: ");
            Array.Sort(array, (x, y) => y.CompareTo(x));
            Class1.PrintArray(array);
        }
    }
}
