using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoCopyElements
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of rows: \n");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the number of columns: \n");
                int col = int.Parse(Console.ReadLine());
                int[,] arr = new int[row, col];
                int[,] copyArray = new int[row, col];
                Console.WriteLine("\nEnter the elements: \n");
                for(int i = 0; i < row; i++)
                {
                    for(int j = 0; j < col; j++)
                    {
                        arr[i, j] = int.Parse(Console.ReadLine());
                        copyArray[i, j] = arr[i, j];
                    }
                }
                Console.WriteLine("\nThe elements in the original array are \n");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\nThe elements in the copied array are \n");
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(copyArray[i, j] + " ");
                    }
                    Console.WriteLine("\n");
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
