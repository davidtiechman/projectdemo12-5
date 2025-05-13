using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static int[] AddAnumber()
        {
            Console.WriteLine("pleas enter are numbers");
            string type = Console.ReadLine();
            string [] tepes = type.Split(' ') ;
            int[] array = new int [tepes.Length];
            for (int i=0;i< tepes.Length;i++)
            {
                array[i] = int.Parse(tepes[i]);
            }            
            return array;
        }
        static string PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write($"{number} ");
            }
            return "f";
        }
        static string PrintRevers(int[] array)
        {
            for (int i = 0; i < (array.Length); i++)

            {
                Console.Write(array[array.Length -(1+i)]);
            }
            return "f";
        }
        static int FindMin(int[] array){
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[min])
                    min = i;
            }
            return array[min];
        }
        static int FindMax(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                    max = i;
            }
            return array[max];
        }
        static int Ave(int[] array)
        {
            int type = 0;
            for (int i = 0; i < array.Length;i++)
            {
                type += array[i];
            }
            return type/(array.Length);
        }

        
        static void Main(string[] args)
        {
            //PrintArray(AddAnumber());
            //PrintRevers(AddAnumber());
            //Console.WriteLine(FindMin(AddAnumber()));
            Console.WriteLine(Ave(AddAnumber()));
                                                    }
    }
}    
