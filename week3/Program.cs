using System;



namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello World!";
            for (int i = 0; i < myString.Length; i++)
            {
                Console.WriteLine(myString[i]);
            }
            for (int i = 0; i < myString.Length; i++)
            {
                Console.Write(myString[i]);
            }

            string myCoolString = "My awesome string of GigiDev";

            Console.WriteLine(myCoolString.Length);

            string s = string.Empty;
            string b = s;
            Console.WriteLine(s);
            Console.WriteLine($"b: {b}"); //string interpolation !!!!

            int myInt = 30;//F5 for debug
            string myIntAsString = myInt.ToString();
            Console.WriteLine($"myIntAsString: {myIntAsString}");


        }
    }
}
