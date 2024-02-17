using System.Collections.Immutable;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Xml;

namespace task7
{
    internal class Program
    {
        private static object l1;

        static void Main(string[] args)
        {
            

        }



        static void Task1()
        {
            Console.Write("Massivde nece reqem saxlamaq isteyirsiniz:");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[len];
            Console.Write("c ededini daxil edin:");
            int c = Convert.ToInt32(Console.ReadLine());


            foreach (int b in a)
            {
            l1:
                Console.Write("a ededinin elemenlerini daxil edin:");
                int i = Convert.ToInt32(Console.ReadLine());

                if (Math.Abs(i) < c)
                {
                    Console.WriteLine($"serte daxildir {i}");
                }
                else
                {
                    Console.WriteLine("serte daxil deyil.");
                    goto l1;

                }

            }
        }
        static void Task2()
        {
            Console.Write("Massivde nece reqem saxlamaq isteyirsiniz:");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[len];
            Console.Write("c ededini daxil edin:");
            int c = Convert.ToInt32(Console.ReadLine());
            double count = 0;

            foreach (int b in a)
            {
            l1:
                Console.Write("a ededinin elemenlerini daxil edin:");
                int i = Convert.ToInt32(Console.ReadLine());

                if (Math.Abs(i) < c)
                {
                    Console.WriteLine($"serte daxildir {i}");

                    count += i;

                }

                else
                {
                    Console.WriteLine("serte daxil deyil.");
                    goto l1;
                }
            }
            count /= len;
            Console.WriteLine(count);
        }
        static void Task3()
        {
            Console.Write("Massivde nece reqem saxlamaq isteyirsiniz:");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[len];
            Console.Write("c ededini daxil edin:");
            int c = Convert.ToInt32(Console.ReadLine());
            double count = 1;

            foreach (int b in a)
            {
            l1:
                Console.Write("a ededinin elemenlerini daxil edin:");
                int i = Convert.ToInt32(Console.ReadLine());

                if (Math.Abs(i) > c)
                {


                    count *= i;

                }

                else
                {
                    Console.WriteLine("serte daxil deyil.");
                    goto l1;
                }
            }
            double len1 = 1.0 / len;


            double result = Math.Pow(count, len1);
            Console.WriteLine($"Netice :{result}");
        }
        static void Task4()
        {
            int i;
            Console.Write("len :");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            Console.Write("c :");
            int c = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < len; i++)
            {
                Console.Write("Enter your number:");

                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (i = 0; i < len; i++)
            {

                if (arr[i] > c)
                {
                    Array.Sort(arr);
                    Array.Reverse(arr);
                    Console.WriteLine(arr[i]);
                }



            }
        }
        static void Task5()
        {
            Console.Write("Len :");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            Console.Write("C :");
            int c = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < len; i++)
            {
                Console.Write("Enter number :");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < len; i++)
            {
                if (arr[i] < c)
                {
                    int max = arr.Max();
                    Console.WriteLine($"Max element :{max}");
                    return;
                }

            }
        }
        static void Task6()
        {

        }

        static void Task7()
        {
            Console.Write("len :");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write("a :");
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            int max = arr.Max();
            int min = arr.Min();
            double result = (max + min) / 2;

            double len1 = 1.0 / 2;
            double netice = Math.Pow(min * max, len1);
            Console.WriteLine($"Ededi orta :{result}");
            Console.WriteLine($"Hendesi orta :{netice}");
        }

        static void Task8()
        {
            int[] a = new int[14];
            int[] b = new int[14];
            int[] c1 = new int[14];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a :");
                a[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("b :");
                b[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < 3; i++)
            {
                int c = a[i] * b[i];
                c1[i] = c;
                Console.WriteLine($"{i + 1} :{c1[i]}");
            }
        }
        static void Task9()
        {
            int[] a = new int[25];

            double[] c = new double[25];
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a :");
                a[i] = Convert.ToInt32(Console.ReadLine());


            }
            for (int i = 0; i < 8; i++)
            {
                c[i] = a[i] * a[i];
                Console.WriteLine($"1ci massiv :{i + 1}ci elementi:{c[i]}");

            }
            for (int i = 8; i < 25; i++)
            {
                c[i] = a[i] / 4;
                Console.WriteLine($"ikici massiv :{i + 1}ci element:{c[i]}");
            }
        }
        static void Task10()
        {
            Console.Write("len :");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[len];
            int[] c = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write("x :");
                x[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < len; i++)
            {
                if (x[i] < 0)
                {
                    int max = x.Min();
                    Console.WriteLine(max);
                    return;
                }
            }
        }
        static void Task11()
        {
            Random rnd = new Random();
            Console.Write("len :");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] x = new int[len];
            for (int i = 0; i < 10; i++)
            {
                x[i] = Convert.ToInt32(rnd.Next(0, 100));

                Array.Sort(x);
                Array.Reverse(x);
                Console.WriteLine(x[i]);
            }
        }
        static void Task12() {
            int[] X = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            int yarisi = X.Length / 2;
            double count = 0;
            double count2 = 1;
            for (int i = 0; i < yarisi; i++)
            {
                count += X[i];
            }
            count /= yarisi;
            Console.WriteLine(count);
            for (int i = 11; i < 20; i++)
            {
                count2 *= X[i];
            }
            Console.WriteLine(count2);


            double hendesiOrta = Math.Pow(count2, 0.1);


            Console.WriteLine(hendesiOrta);
        }
    }
}