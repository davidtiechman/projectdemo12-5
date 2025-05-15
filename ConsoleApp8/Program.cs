using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static bool Chackingaffirmativ(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    count++;
            }
            if (count >= 3)
            {
                return true;
            }
            else { return false; }
        }
        static bool chackingnumber(int[] array)
        {
            int caount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].GetType() == typeof(int))
                {
                    caount ++;
                }
              }
                if (caount == array.Length)
                {
                    return true; 
                }
                else return false;

            
        }

        static int[] Addthenumbers()
        {
            Console.WriteLine("pleas enter are numbers");
            string type = Console.ReadLine();
            string[] tepes = type.Split(' ');
            int[] a = Array.ConvertAll(tepes,int.Parse);

            return a;
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
            string [] arraymnemus = {"a","b","c","d","e","f","g","h","i","j"};
            while (!arraymnemus.Contains(choice)) { 
            Console.WriteLine("pleas enter whish menu");
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
