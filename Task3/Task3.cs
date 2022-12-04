using Addition;
using Addition3;

namespace Summa
{
    class Task3
    {
        static void Main(string[] args)
        {
            int arraySize = Class1.CreateSize();
            int[] array = Class1.FillArray(arraySize, -100, 100);
            Class1.PrintArray(array);
            Add3.Sum(array);
            Console.ReadKey();
        }
    }
}   


