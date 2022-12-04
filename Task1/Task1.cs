using Addition;
using Addition1;
namespace Massiv
{
    class Task1
    {
        static void Main(string[] args)
        {
            int arraySize = Class1.CreateSize();
            int[] array = Class1.FillArray(arraySize, 0, 100);
            Console.WriteLine("Массив исходный: ");
            Class1.PrintArray(array);
            Add1.MaxValue(array);
            Add1.MinValue(array);
            Add1.Sorting(array);
            Console.WriteLine("Массив после сортировки: ");
            Class1.PrintArray(array);
        }
    }
}