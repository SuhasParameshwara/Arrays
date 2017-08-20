using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the size of the array: \n");
                int size = int.Parse(Console.ReadLine());
                int[] arr = new int[size];
                Console.WriteLine("\nEnter the elements of the array: \n");
                for(int i = 0; i < size; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nArray Before reversing: \n");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Array after reversing: \n");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr[arr.Length -(i+1)] + " ");
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
