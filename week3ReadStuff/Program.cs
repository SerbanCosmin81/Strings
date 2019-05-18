using System;

namespace week3ReadStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string!");
            string readLine = Console.ReadLine();
            Console.WriteLine("Please enter a second string!");
            string readLine2 = Console.ReadLine();

            if (readLine==readLine2)
            {
                Console.WriteLine("OKEY");
            }
            else
            {
                Console.WriteLine("Not okey!!!!!!");
            }
            Console.WriteLine(string.Compare(readLine,readLine2,true));

            Console.WriteLine(readLine.Equals(readLine2));

        }
    }
}
