using System;

namespace Itreration
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] arr = new int[5];
             Console.WriteLine("Enter Numbers");
             for (int i=0; i<=arr.Length; i++)
             {

               Console.ReadLine(arr[i]);*/

            /*string[] names = new string[] { "Adarsh", "FatAss", "Fatty", "Skinny"};
            for (int i=0; i<names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            string zig = "My name is" + "Adarsh Prasad";
            char [] charArray = zig.ToCharArray();
            Array.Reverse(charArray);
            foreach(char ZigArray in charArray)
            {
                Console.WriteLine(ZigArray);
            }
            Console.ReadLine();
        }
    }
}
