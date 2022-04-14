using System;

delegate void MyDelegate(string txt);

namespace DelegateAsFieldDemo
{
    class MyClass
    {
        //полде является ссылкой на экземпляр делегата
        public MyDelegate apply;
        public MyClass(MyDelegate md)
        {
            apply=md;
        }
    }

    class Alpha
    {
        private string name;
        public void set(string t)
        {
            name=t;
        }
        public override string ToString()
        {
            return name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Alpha A = new Alpha();              //создание объекта
            
            //создание объекта (аргумент конструктора - ссылка на метод)
            MyClass obj = new MyClass(A.set);
            
            obj.apply("объект А");      // вызов экземпляра делегата
            Console.WriteLine(A);       // проверка поля объекта
            
            Alpha B = new Alpha();              //создание объекта
             
            obj.apply=B.set;    // полю значением присваивается ссылка на метод
            
            obj.apply("объект В");  // вызов экземпляра делегата
         
            Console.WriteLine(B);   // проверка поля объекта
          
            //добавление метода в список вызовов экземпляра делегата
            obj.apply+=A.set;
            
            obj.apply("объект Х"); //вызов экземпляра делегата
           
            Console.WriteLine(A + " и " + B); //проверка полей объектов
            
            obj.apply-=B.set;       // удаление метода из списка вызовов экз делегата
            
            obj.apply("объект А"); //вызов экземпляра делегата
            
            Console.WriteLine(A + " и " + B); // проверка полей объектов
        }
    }
}
