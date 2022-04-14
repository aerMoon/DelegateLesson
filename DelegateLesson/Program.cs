using System;

//объявление делегата
delegate char Mydelegate(int k, string txt);

namespace DelegateLesson
{
    class SomeClass
    {
        public int code;
        public SomeClass (int n)
        {
            code = n;
        }
        // нестатический метод с двумя переменными
        public char GetChar(int k, string txt)
        {
            return (char)(txt[k]+code);
        }
        //статический метод с двумя аргументами
        public static char GetFirst(int k, string txt)
        {
            return txt[k];
        }
    }
    

    //класс с главным методом     
    internal class Program
    {
        //статический метод с двумя аргументами
        static char GetLast(int k, string txt)
        {
            return txt[txt.Length-1];
        }

        static void Main(string[] args)
        {
            //создание объекта
            SomeClass obj = new SomeClass(5);

            //создание экземпляра делегата
            Mydelegate meth = new Mydelegate(obj.GetChar);

            //вызов экземпляра делегата
            Console.WriteLine($"символ {meth(4,"world")}");

            //присваивание значения полю объекта
            obj.code = 1;

            //вызов экземпляра делегата
            Console.WriteLine($"символ {meth(4, "world")}");

            //присваивание нового значения переменной делегата
            meth = SomeClass.GetFirst;

            //вызов экземпляра делегата
            Console.WriteLine($"символ {meth(2, "world")}");

            //присваивание нового знанчения переменной делегата
            meth = GetLast;

            //вызов экземпляра делегата
            Console.WriteLine($"символ {meth(1, "world")}");

        }
    }
}
