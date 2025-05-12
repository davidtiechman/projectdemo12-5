using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static string PrintArray(string[] array)
        {
            //Console.WriteLine("enter sum numbers");
            //string[] numbers = Console.ReadLine().Split(' ');
            foreach (string number in array)
            {
                Console.Write($"{number} ");
            }
            return "f";
        }
        static string PrintRevers(string[] array)
        {
            for (int i = 0; i < (array.Length); i++)

            {
                Console.Write(array[array.Length -(1+i)]);
            }
            return "f";
        }



        

        static void Main(string[] args)
        {
            PrintArray(new string[] { "1", "4" });
            PrintRevers(new string[] { "1", "4" });
                                                    }
    }
}    
