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
        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write($"{number} ");
            }
            
        }
        static void PrintRevers(int[] array)
        {
            for (int i = 0; i < (array.Length); i++)

            {
                Console.Write($"{array[array.Length -(1+i)]} ");
            }
            
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
        static int [] sort (int[] array)
        { 
            Array.Sort(array);
                return array;
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
        static int Lenarrya(int[] array)
        {
            int len = array.Length;

            return len;
        }
        static int Sumarrya(in int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length;i++){
                sum += array[i];
                }
            return sum;
        }
        static void menu(int[]a)
        {
            string menu = null;
            string [] arraynemus = {"a","b","c","d","e","f","g","h","i","j"};
            while (!arraynemus.Contains(menu)) { 
            Console.WriteLine("pleas enter how menu");
            menu = Console.ReadLine();
                switch (menu)
                {
                    case "a":
                        break;
                    case "b":
                        PrintArray(a);
                        break;
                    case "c":
                        PrintRevers(a);
                        break;
                    case "d":
                        sort(a);
                        break;
                    case "e":
                        FindMin(a);
                        break;
                    case "f":
                        FindMax(a);
                        break;
                    case "g":
                        Ave(a);
                        break;
                    case "h":
                        Lenarrya(a);
                        break;
                    case "i":
                        Sumarrya(a);
                        break;
                    case "j":
                        break;
                }
                  
            }
        }

        
        
        static void Main(string[] args)
        {
            int[] arrayq = {5,6,7,8,9,10,1};
            //PrintArray(AddAnumber());
            //PrintRevers(AddAnumber());
            //Console.WriteLine(FindMin(AddAnumber()));
            //Console.WriteLine(Ave(AddAnumber()));
            //Console.WriteLine(Lenarrya(AddAnumber()));
            //Console.WriteLine(Sumarrya(AddAnumber()));
            //Console.WriteLine(sort(AddAnumber()));
            menu(arrayq);
        }
    }
}
