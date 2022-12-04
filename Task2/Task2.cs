using Addition;
using Addition2;
namespace Zamena
{
    internal class Task2
    {
        static void Main(string[] args)
        {
            int arraySize = Class1.CreateSize();
            int[,,] array = Add2.FillArrayTripple(arraySize, -10, 10);
            Add2.PrintArrayTripple(array, arraySize);
            Add2.Replace(array, arraySize);
            Console.WriteLine("Итог:");
            Add2.PrintArrayTripple(array, arraySize);
        }
    }
}


