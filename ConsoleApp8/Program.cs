using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static string  addNumper()
        {
            Console.WriteLine("enter sum numbers");
            string[] numbers = Console.ReadLine().Split(' ');
            foreach (string number in numbers)
            {
                Console.Write(number);
            }
            return "f";


                //List<int> reverse = new List<int>();
                //   reverse.Add(Convert.ToInt32(array[array.Length - 1]));
                //int lastnum = reverse.Count - 1;
                //return lastnum;
            }

        static void Main(string[] args)
            {
            addNumper();
            }
        }
    }
