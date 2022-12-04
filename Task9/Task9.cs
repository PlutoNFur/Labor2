using Addition;
using Addition9;
namespace Comparison
{

    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = Class1.CreateSize();
            
            int [] array1 = Add9.FillArray1(arraySize);
            int[] array2 = Add9.FillArray2(arraySize);

            Console.WriteLine();
            Class1.PrintArray(array1);
            Class1.PrintArray(array2);
            Array.Sort(array1);
            Array.Sort(array2);
            Console.WriteLine("\n1 после сортировки: "); 
            Class1.PrintArray(array1);
            Console.WriteLine("\n2 после сортировки: ");
            Class1.PrintArray(array2);
            Add9.Comparison(array1, array2);

        }
    }
}



