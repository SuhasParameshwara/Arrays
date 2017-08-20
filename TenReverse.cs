using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the string: \n");
                string str = Console.ReadLine();
                char[] strArray = str.ToCharArray();
                Console.WriteLine("\nBefore reversing the string: \n\n{0}",str);
                Console.WriteLine("\nAfter reversing the string: \n");
                for(int i = 0; i < str.Length; i++)
                {
                    Console.Write(strArray[str.Length - (i + 1)]);
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
