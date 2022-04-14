using System;

delegate int Result(char c, string txt);

namespace pz_8_delegates
{
    internal class Program
    {
        //1 задание
        static int GetCountOfCharInString(char c, string text)
        {
            int count = 0;
            foreach (char ch in text)
            {
                if (ch == c)
                    count++;
            }
            return count;
        }

        static int GetFirstCharIndexInString(char c, string text)
        {
            return  text.IndexOf(c);
           
        }

        static void Main(string[] args)
        {
            Result result = GetFirstCharIndexInString;
            Console.WriteLine(result('r',"discuss"));           //-1
            Console.WriteLine(result('r', "world"));            //2

            result= GetCountOfCharInString;
            Console.WriteLine(result('r', "reverberation"));    //3
            Console.WriteLine(result('f', "reverberation"));    //0
        }
    }
}
