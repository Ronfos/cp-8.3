using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        //Задание 1.Вывести на экран горизонтальную строку из 20 символов, отступив от верхнего края на 4 строки.
        //static void String()
        //{
        //    for (int i = 0; i < 4 ; i++)  Console.WriteLine();
        //    for (int x = 0; x < 20 ; x++) Console.Write("#");
        //    Console.ReadKey();
        //}
        //static void Main(string[] args)
        //{ String(); }


        //Задание 2. Написать метод, «рисующий» прямоугольный треугольник указанного вида
        //static void Draw()
        //{
        //    int h = 8;
        //    int hh = 8;
        //    for (int a = 0; a < 8; a++)
        //    {
        //        for (int b = 0; b < 8; b++)
        //        {
        //            if (b == h) Console.Write("#");
        //            if (b < hh) Console.Write("#");
        //        }
        //        Console.Write("\n");
        //        hh--;
        //    }
        //    Console.ReadKey();
        //}
        //static void Main(string[] args)
        //{ Draw(); }


        //Задание 3. Вычислить значение выражения, определив и использовав дополнительный метод:
        //static void Uravn()
        //{

        //    double x = ((Math.Sqrt(5) + 5) / (Math.Sqrt(7)+7))+ ((Math.Sqrt(12) + 12) / (Math.Sqrt(8) + 8)) + ((Math.Sqrt(19) + 19) / (Math.Sqrt(2) + 2)) ;
        //    Console.WriteLine($"{x:f2}");
        //}
        //static void Main(string[] args)
        //{
        //    Uravn();
        //    Console.ReadKey();
        //}

        //Задание 4.Найти наибольшее значение из четырех чисел a, b, c, d.
        static void Max()
        {
            int[] numbers = new int[4];
            Console.Write("Введите число a: ");
            numbers[0] = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            numbers[1] = int.Parse(Console.ReadLine());
            Console.Write("Введите число с: ");
            numbers[2] = int.Parse(Console.ReadLine());
            Console.Write("Введите число d: ");
            numbers[3] = int.Parse(Console.ReadLine());
            int max = numbers.Max();
            Console.WriteLine($"Наибольшим значением является {max}.");
            Console.ReadKey();
        }
        static void Main(string[] args)
        { Max(); }
    }
}
