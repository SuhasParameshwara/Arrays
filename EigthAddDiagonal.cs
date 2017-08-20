using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EigthAddDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter the number of rows: \n");
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter the number of colums: \n");
                int col = int.Parse(Console.ReadLine());
                int[,] arr = new int[row, col];
                int sum = 0;
                if (row != col)
                {
                    Console.WriteLine("\nThe sum of diagonal elements cannot be calculated!");
                }
                else
                {
                    Console.WriteLine("\nEnter the elements: \n");
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            arr[i, j] = int.Parse(Console.ReadLine());
                            if (i == j)
                            {
                                sum += arr[i, j];
                            }
                        }
                    }
                    Console.WriteLine("\nThe sum of diagonal elements in the array is " + sum);
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
