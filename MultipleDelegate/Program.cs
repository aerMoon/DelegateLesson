//многократная адресация экземпляров делегатов
using System;

//объявление делегата
delegate void MyDelegate();

namespace MultipleDelegate
{
    class MyClass
    {
        public string name;
        public MyClass( string text)
        {
            name = text;
        }
        public void Show()
        {
            Console.WriteLine(name);
        }
    }
    internal class Program
    {
        static void MakeLine()
        {
            Console.WriteLine("____________________________");
        }
        static void Main(string[] args)
        {
            //создание объектов
            MyClass obj1 = new MyClass("первый объект");
            MyClass obj2 = new MyClass("второй объект");
            MyClass obj3 = new MyClass("третий объект");

            //объявление переменной делегата
            MyDelegate meth;
            
            // присваивание переменной делегата ссылки на метод
            meth = obj1.Show;
           
            // вызов экземпляра делегата
            meth();
           
            // присваивание переменной делегата нового значения
            meth = MakeLine;

            // добавление методов в список вызова
            meth +=     obj1.Show;
            meth +=     obj2.Show;
            meth =      meth + obj3.Show;

            // вызов экземпляра делегата
            meth();

            // удаление метода из списка вызова 1 способ
            meth -= obj2.Show;

            // вызов экземпляра делегата
            meth();

            // удаление метода из списка вызова 2 способ
            meth = meth - obj1.Show;

            // вызов экземпляра делегата
            meth();
        }
    }
}
