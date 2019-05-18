using System;
using System.Diagnostics;
using System.Text;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "             ANA Gigi Dev Are Coduri ";

            Console.WriteLine($"index of A:{myString.IndexOf('A')}");
            Console.WriteLine($"index of d:{myString.LastIndexOf('d')}");

            string mere = myString.Substring(3, 8);
            Console.WriteLine(mere);
            string mere2 = myString.Substring(myString.IndexOf('C'), 6);
            Console.WriteLine(mere2);

            string cleanString = myString.Trim();
            Console.WriteLine(myString);
            Console.WriteLine(cleanString);

            string replacedString = myString.Replace(" ", ".");
            Console.WriteLine(replacedString);
            string replaceA = myString.Replace("A", "!", true, new System.Globalization.CultureInfo("en-us"));
            Console.WriteLine(replaceA);
            //SPLIT

            var splitted = myString.Trim().Split(new char[] { ' ' });

            for (int i = 0; i < splitted.Length; i++)
            {
                Console.WriteLine(splitted[i]);
            }

            Console.WriteLine(myString.ToLower());
            Console.WriteLine(myString.ToUpper());
            Console.WriteLine(myString.Remove(9, 4));

            // concatenation
            string concatenated = "";
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < 10000; i++)
            {
                concatenated = concatenated + i.ToString();

                //var2
                //concatenated += i.ToString();


            }
            timer.Stop();

            //Console.WriteLine(concatenated);
            Console.WriteLine(timer.Elapsed);

            //string builder data type with an expendable buffer

            //StringBuilder stringBuilder = new StringBuilder();
            //Stopwatch timeForBuilder = new Stopwatch();

            //timeForBuilder.Start();

            //for (int i = 0; i < 10000000; i++)
            //{
            //    stringBuilder.Append(i.ToString());
            //}
            ////Console.WriteLine(stringBuilder);

            //timeForBuilder.Stop();

            ////Console.WriteLine(stringBuilder);
            //Console.WriteLine(timeForBuilder.Elapsed);

            double d = 0.375;
            var s = String.Format("{0,10:F5}", d);
            Console.WriteLine(s);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
}
