using System;

namespace Desicions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number");
            Console.Write("1, 2 or 3");
            string chooseValue = Console.ReadLine();

            string message= "";

            if (chooseValue == "1")
            {
                message = "You won";
            }
            else if (chooseValue == "2")
            {
                message = "You lost";
            }
            else if (chooseValue == "3")
            {
                message = "Draw";
            }
            else
            {
                message = "Wrong Input";
            }
            Console.Write(message);
            Console.ReadLine();
        }
    }
}
