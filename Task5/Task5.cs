using Addition;
using Addition5;
namespace Exception
{
    class Task5
    {
        static void Main(string[] args)
        {
            int arraySize = Class1.CreateSize();
            int[] array = Class1.FillArray(arraySize, -100, 100);
            Class1.PrintArray(array);
            int[] final = Add5.Delete(array);
            Class1.PrintArray(final);
        }
    }
}