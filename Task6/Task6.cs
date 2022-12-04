using Addition;
using Addition6;
namespace Doubling
{
    class Task6
    {
        static void Main(string[] args)
        {
            int arraySize = Class1.CreateSize();
            int[] array = Class1.FillArray(arraySize, -100, 100);
            Class1.PrintArray(array);
            Add6.Double(array);
            Console.ReadKey();
        }
    }
}