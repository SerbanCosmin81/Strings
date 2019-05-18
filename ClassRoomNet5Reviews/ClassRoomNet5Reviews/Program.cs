using System;
using ClassRoomNet5Reviews.myFolder;

namespace ClassRoomNet5Reviews
{
    class Program
    {
        static void Main(string[] args)
        {
            // METHODS = functions or procedures
            // ACCESS MODIFIERS --- public / private - doar in interiorul clasei / 
            //protected - disponibil doar in lantul de inheritance / internal - disponbil doar intr-un namespace
            //access modifiers data type method name(return type)
            // PARAMETERS declararea unei variabile care va fi disponibila doar in interiorul metodei
            //--------------------------------------------------------------------------------------------
            //cw+tab+tab = Console.WriteLine();
            //prop+tab+tab = public int MyProperty { get; set; }
            //usefull shortcuts: CTRL+SHIFT+B = Built Solution - and verifies the code syntactically
            //CTRL+K+C = comment selected code or --/*comment*/--
            //CTRL+K+U = uncomment selected code
            //CTRL+K+D = auto forat code
            //Debugging step by step: we set a break point ----
            //F5 = Start with debugging
            //F10 = new line
            //SHIFT+F5 = stop debugging ----
            //CTRL+. = shows how can we correct an error
            //---------------------------------------------------------------------------------------------
            //week1
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hello .NET Gigi Dev e Cu voi!");
            //Console.WriteLine("Cool Gigi dev");
            //Console.Write("Scrie fara enter!!!");

            //var MyClass1 = new MyClass1();

            //var Empty = new Empty();

            double piDouble = 3.141592653589793238;
            float piFloat = 3.141592653589793238F;
            decimal piDecimal = 3.141592653589793238M;

            Console.WriteLine("{0} is the PI Double Value before Explicit cast to Float:", piDouble);
            Console.WriteLine("{0} is the PI Float Value before Explicit cast to Double:", piFloat);
            Console.WriteLine("{0} is the PI decimal Value before Explicit cast to Float:", piDecimal);

            //explicit cast 

            float DoublePiToFloat = (float)piDouble;
            double FloatPiToDouble = (double)piFloat;
            float DecimalPiToFloat = (float)piDecimal;

            // Convert class.
            string Pi = "3.141592653589793238";

            decimal StringToDecimal = Convert.ToDecimal(Pi);
            double StringToDouble = Convert.ToDouble(Pi);

            Console.WriteLine(StringToDecimal);
            Console.WriteLine(StringToDouble);


            //Console.WriteLine("{0} is the PI Double Value After Explicit cast to Float:", DoublePiToFloat);
            //Console.WriteLine("{0} is the PI Float Value After Explicit cast to Double:", FloatPiToDouble);
            //Console.WriteLine("{0} is the PI Decimal Value After Explicit cast to Float:", DecimalPiToFloat);









        }
    }
}
