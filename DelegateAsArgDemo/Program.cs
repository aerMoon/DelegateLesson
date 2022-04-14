using System;

delegate int MyDelegate(int n);

namespace DelegateAsArgDemo
{
    internal class Program
    {
        //статический метод для вычисления нечетных чисел
        static int OddNumber(int n)
        {
            return 2*n+1;
        }
        // статический метод для вычисления четных чисел
        static int EvenNumber(int n)
        {
            return 2*n;
        }
        //статический метод для вычисления квадратов чисел
        static int SquareNumber(int n)
        {
            return n*n;
        }
        // статический метод, которому аргументом передается ссылка на метод
        static void Display(MyDelegate F, int a, int b)
        {
            Console.WriteLine("{0,-4}|{1,4}", "x", "F(x)");
            Console.WriteLine("-----------");

            for (int k = a; k <= b; k++)
            {
                //команда с вызовом экземпляра делегата
                Console.WriteLine("{0,-4}|{1,4}", k, F(k));
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int a = 0, b = 5;
            Console.WriteLine("нечетные числа");
            Display(OddNumber, a, b);
            Console.WriteLine("четные числа");
            Display(EvenNumber, a, b);
            Console.WriteLine("число в квадрате");
            Display(SquareNumber, a, b);
        }
    }
}
