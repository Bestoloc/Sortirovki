using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        public static int[] GetMass(int a)
        {
            Random rnd = new Random();
            int[] mas = new int[a];
            for (int i = 0; i < mas.Length; i++)
                mas[i] = rnd.Next(-10, 10);
             return mas;
        }
       


        public static void SortBubble(int[] a)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Пузырьковый метод ");
            Console.WriteLine("Неотсортированный массив: ");
            Console.WriteLine(String.Join(",", a));
            int i, j, z;
            for ( i = 0; i < a.Length - 1; i++)
                for (j = 0; j < a.Length - 1; j++)
                    if (a[j] > a[j + 1])
                    {
                        z = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = z;
                    }
            Console.WriteLine("Отсортированный массив: ");
            Console.WriteLine(String.Join(",", a));
        }

        public static void SortChoose(int[] a)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Метод выбора ");
            Console.WriteLine("Неотсортированный массив: ");
            Console.WriteLine(String.Join(",", a));
            int i, j, z, ind;
            for (i = 0; i < a.Length; i++)
            {
                z = a[i];
                ind = i;
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < z)
                    {
                        z = a[j];
                        ind = j;
                    }
                }
                a[ind] = a[i];
                a[i] = z;
            }
            Console.WriteLine("Отсортированный массив: ");
            Console.WriteLine(String.Join(",", a));
        }

        public static void SortInsert(int[] a)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Метод вставки ");
            Console.WriteLine("Неотсортированный массив: ");
            Console.WriteLine(String.Join(",", a));
            int i, j, z;
            for (i = 1; i < a.Length; i++)
            {
                z = a[i];
                for (j = i - 1; j >= 0 && a[j] > z; j--)
                {
                    a[j + 1] = a[j];
                }
                a[j + 1] = z;
            }
            Console.WriteLine("Отсортированный массив: ");
            Console.WriteLine(String.Join(",", a));
        }

        public static void SortShell(int[] a)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Метод шелла ");
            Console.WriteLine("Неотсортированный массив: ");
            Console.WriteLine(String.Join(",", a));
            int i, j, z, d;
            d = a.Length / 2;
            while (d > 0)
            {
                for (i = 0; i < a.Length - d; i++)
                {
                    j = i;
                    while (j >= 0 && a[j] > a[j + d])
                    {
                        z = a[j];
                        a[j] = a[j + d];
                        a[j + d] = z;
                        j = j - d;
                    }
                }
                d = d / 2;
            }
            Console.WriteLine("Отсортированный массив: ");
            Console.WriteLine(String.Join(",", a));


        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int Rm = int.Parse(Console.ReadLine());
            SortBubble(GetMass(Rm));
            SortChoose(GetMass(Rm));
            SortInsert(GetMass(Rm));
            SortShell(GetMass(Rm));
        }
    }
}
