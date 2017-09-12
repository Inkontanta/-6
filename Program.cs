using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {


            //5.Ввести а1, а2, а3, N. Построить последовательность чисел ак = (ак–1 + 1) / (ак - 2 + 2) * ак–3.
            //Построить и напечатать N элементов последовательности и проверить, 
            //является ли она монотонно неубывающей или строго возрастающей.

            double a=0, a1=0, a2=0, a3=0, n=0, j=3;
           

            bool ok = false;
            while (!ok)                 //проверка ввода 1-ой переменной 
            {
                try
                {
                    Console.WriteLine("Введите переменную a1:");
                    a1 = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("Число введено неверно, повторите ввод");
                    ok = false;
                }
            }
            ok = false;


           
            while (!ok)                 //проверка ввода 2-ой переменной 
            {
                try
                {
                    Console.WriteLine("Введите переменную a2:");
                    a2 = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("Число введено неверно, повторите ввод");
                    ok = false;
                }
            }
            ok = false;

            while (!ok)                 //проверка ввода 3-ой переменной 
            {
                try
                {
                    Console.WriteLine("Введите переменную a3:");
                    a3 = Convert.ToDouble(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("Число введено неверно, повторите ввод");
                    ok = false;
                }
            }
            ok = false;

            while (!ok)                 //проверка ввода 4-ой переменной 
            {
                try
                {
                    Console.WriteLine("Введите переменную n:");
                    n = Convert.ToInt32(Console.ReadLine());
                    ok = true;
                }
                catch
                {
                    Console.WriteLine("Число введено неверно, повторите ввод");
                    ok = false;
                }
            }
            ok = false;
            if (n > 2)
            {
                Console.Write(a1 + " " + a2 + " " + a3 + " ");

                
            }
            else
            {
                if (n==2)
                {
                    Console.Write(a1 + " " + a2 + " " );
                }
                else
                {
                    Console.Write(a1 );
                }
            }
            if (n > 3)
            {
                Func(ref a1, ref a2, ref a3, ref n, ref a, ref j);
            }
            Console.ReadKey();




        }
        static void Func (ref double a1, ref double a2, ref double a3, ref double n, ref double a, ref double j)
        {
            
            a = (a1 + 1) / (a2 + 2) * a3;
            a1 = a2;
            a2 = a3;
            a3 = a;
            j++;
            while (j-1 < n)
            {
                Console.Write(a + " ");
                Func(ref a1, ref a2, ref a3, ref n, ref a, ref j);
            }

        }
    }
}
