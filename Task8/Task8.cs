using Addition;
using Addition8;
namespace Massive
{
    class Task8
    {
        static void Main(string[] args)
        {
            int arraySize = Class1.CreateSize();
            int[] array = Class1.FillArray(arraySize, -0, 10);
            Class1.PrintArray(array);
            Add8.EnterDesiredElement(array);
        }
    }
}