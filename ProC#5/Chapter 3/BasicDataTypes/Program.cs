using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics; // to use BigInteger

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclaration();
            NewingDataTypes();
            UseDatesAndTimes();
            UseBigInteger();
            BasicStringFunctionality();
            StringConcatenation();
            EscapeChars();
            Console.ReadLine();
        }

        static void LocalVarDeclaration()
        {
            Console.WriteLine("=> Data Declarations:");
            int myInt = 0;
            string myString;
            myString = "This is a string!";

            // Declare 3 bools on a single line.
            bool b1 = true, b2 = false, b3 = b1;

            // Use System.Boolean data type to declare a bool.
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);

            Console.WriteLine();
        }

        static void NewingDataTypes()
        {
            Console.WriteLine(" => Using new to create variables:");
            bool b = new bool(); // set to false
            int i = new int(); // set to 0
            double a = new double(); // set to 0
            DateTime dt = new DateTime(); // set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, a, dt);
            Console.WriteLine();
        }

        static void UseDatesAndTimes()
        {
            Console.WriteLine("=> Dates and Times:");
            // This constructor takes (year, month, day)
            DateTime dt = new DateTime(2010, 10, 17);

            // What day of the month is ths?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

            // The month is now December
            dt = dt.AddMonths(2);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

            // This constructor takes (hours, minutes, seconds)
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);

            // Subtracy 15 mins from the current TimeSpan and print the result
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));

            Console.WriteLine();
        }

        static void UseBigInteger()
        {
            Console.WriteLine("=> Use BigInteger:");
            BigInteger bigInty = BigInteger.Parse("9999999999999999999999999999999999999999999999999999");

            Console.WriteLine("Value of bigInty is {0}", bigInty);
            Console.WriteLine("Is binInty an even value? {0}", bigInty.IsEven);
            Console.WriteLine("Is bigInty a power of two? {0}", bigInty.IsPowerOfTwo);
            BigInteger anEvenBiggerInty = BigInteger.Multiply(bigInty, BigInteger.Parse("888888888888888888888888888888888888888888888"));

            Console.WriteLine("The value of anEvenBiggerInty is {0}", anEvenBiggerInty);

            Console.WriteLine();
        }

        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String Functionality");
            string firstName = "John";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName conains letter y? {0}", firstName.Contains("y"));
            Console.WriteLine("firstName after replace: {0}", firstName.Replace("h", ""));
            Console.WriteLine();
        }

        static void StringConcatenation()
        {
            Console.WriteLine("=> String Concatenation");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2; // or string s3 = String.Concat(s1, s2);
            Console.WriteLine(s3);
            Console.WriteLine();
        }

        static void EscapeChars()
        {
            Console.WriteLine("=> Escape Characters:\a");
            string strWithTabs = "Model\tColor\tSpped\tPet Name\a";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone likes \"Hello, Wolrd!\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a");

            // Add 4 blank lines and produce another beep
            Console.WriteLine("All finished. \n\n\n\a");
            Console.WriteLine();
        }
    }
}
