using System;
delegate string TestDelegate();
class Student
{
    public string _group = "none";
    public Student(string group)
    {
        _group = group;
    }

    public string GetGroup()
    {
        return _group;
    }
}

class Pupil
{
    public string _klass = "none";

    public Pupil(string klass)
    {
        this._klass = klass;
    }

    public string getKlass()
    { return _klass; }


}

namespace Zadanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("22АСОИ");
            Pupil pupil = new Pupil("9A");

            TestDelegate deleg = new TestDelegate(student.GetGroup);
            Console.WriteLine($"студент учится в группе {deleg()}");

            deleg = pupil.getKlass;
            Console.WriteLine($"ученик учится в {deleg()} классе");

            deleg += student.GetGroup;
        }
    }
}
