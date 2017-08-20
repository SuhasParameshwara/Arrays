using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number of elements: \n");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                int[] copyArray = new int[size];
                Console.WriteLine("\nEnter the elements: \n");
                for (int i = 0; i < size; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                    copyArray[i] = arr[i];
                }
                Console.WriteLine("\nThe original array contains\n");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\n");
                Console.WriteLine("The copied array contains\n");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(copyArray[i] + " ");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
