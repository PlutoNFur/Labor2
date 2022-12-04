using Addition;
using Addition4;

namespace Summa
{
    class Task4
    {
        static void Main(string[] args)
        {
            int arraySize = Class1.CreateSize();
            int[,] array = Add4.FillArray(arraySize, -100, 100);
            Add4.PrintArray(array, arraySize);
            Add4.Sum(array, arraySize);
            Console.ReadKey();
        } 
    }
}



         