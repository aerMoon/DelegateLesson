using System;

delegate void Result(char c);
    

namespace pz_8_delegates_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[10];
            char symbol = 'u';

            Result result = null;

            for (int i=0; i < users.Length; i++)
            {
                users[i] = new User();
                result += users[i].SetS;
            }

            result('d'); ;        }
    }


    class User
    {
        public char S { get; set; }
        public void SetS(char c)
            {
                S = c;
                Console.WriteLine(S);
            }
    }
}
