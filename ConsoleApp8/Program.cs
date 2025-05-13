using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static int[] Addthenumbers()
        {
            Console.WriteLine("pleas enter are numbers");
            string [] tepes = Console.ReadLine().Split(' ');
            int []array = Array.ConvertAll(tepes, int.Parse);
            return array;
        }
        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write($"{number} ");
                
            }
            Console.WriteLine("\n");
            
        }
        static void PrintRevers(int[] array)
        {
            for (int i = 0; i < (array.Length); i++)

            {
                Console.Write($"{array[array.Length -(1+i)]} ");
            }
            Console.WriteLine("\n");
            
        }
        static void FindMin(int[] array){ 
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[min])
                    min = i;
            }
            Console.WriteLine(array[min]);
        }
        static void sort (int[] array)
        { 
            Array.Sort(array);
            foreach (int number in array)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine("\n");
        }
        static void FindMax(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                    max = i;
            }
            Console.WriteLine(array[max]);
        }
        static void Ave(int[] array)
        {
            int type = 0;
            for (int i = 0; i < array.Length;i++)
            {
                type += array[i];
            }
            Console.WriteLine(type/(array.Length));
        }
        static void Lenarrya(int[] array)
        {
            int len = array.Length;

            Console.WriteLine(len);
        }
        static void Sumarrya(in int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length;i++){
                sum += array[i];
                }
            Console.WriteLine(sum);
        }
        static void menu(int[]a)
        {
            string choice = null;
            string [] arraynemus = {"a","b","c","d","e","f","g","h","i","j"};
            while (!arraynemus.Contains(choice)) { 
            Console.WriteLine("pleas enter how menu");
            choice = Console.ReadLine();
                switch (choice)
                {
                    case "a":
                       a = Addthenumbers();
                       menu(a);
                        break;
                    case "b":
                        PrintArray(a);
                        menu(a);
                        break;
                    case "c":
                        PrintRevers(a);
                        menu(a);
                        break;
                    case "d":
                        sort(a);
                        menu(a);
                        break;
                    case "e":
                        FindMin(a);
                        menu(a);
                        break;
                    case "f":
                        FindMax(a);
                        menu(a);
                        break;
                    case "g":
                        Ave(a);
                        menu(a);
                        break;
                    case "h":
                        Lenarrya(a);
                        menu(a);
                        break;
                    case "i":
                        Sumarrya(a);
                        menu(a);
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
