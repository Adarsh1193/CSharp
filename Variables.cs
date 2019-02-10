using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {/*
            int x;
            int y;

            x = 7;
            y = x + 3;
            Console.WriteLine(y);
            Console.ReadLine(); */

            Console.WriteLine("What is your first name?");
            Console.Write("Write your first name");
            string myfirstName;
            myfirstName = Console.ReadLine();

            string mysecondName;
            Console.Write("Write your last name");
            mysecondName = Console.ReadLine();

            Console.WriteLine("Hello, " + myfirstName + " " + mysecondName);
            Console.ReadLine();
        }
    }
}
