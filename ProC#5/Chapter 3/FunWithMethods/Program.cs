using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some examples of invoking methods using named parameters
            DisplayFancyMessage(message: "Hello", textColor: ConsoleColor.Blue, backgroundColor: ConsoleColor.Cyan);
            DisplayFancyMessage(ConsoleColor.Yellow, message: "Once again, Hello!", backgroundColor: ConsoleColor.Blue);
            
            Console.ReadLine();
        }

        static int AddByVal(int x, int y)
        {
            int ans = x + y;
            // The caller will not see this changes, since
            // a copy of original data is being modified
            return ans;
        }

        static void AddOutModfier(int x, int y, out int ans)
        {
            ans = x + y;
        }

        // Returning multiple outpur parameters
        static void FillTheseValues (out int a, out string b, out bool c)
        {
            a = 26;
            b = "This is a string!";
            c = true;
        }

        // Reference parameters
        public static void SwapStrings(ref string s1, ref string s2)
        {
            // Passing references to the variables
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        // Return average of "some number" of doubles
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles", values.Length);

            double sum = 0;

            if (values.Length == 0)
                return sum;
            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return sum / values.Length;
        }

        // Example with option parameters. "text" is an optional parameter,
        // if no 2nd argument is passed, the variable text gets the value
        // specified after the = sign in function declaration.
        static void EnterLogData(string message, string text = "This is the defult text")
        {
            // NOTE: The default value for an optional arg must be known at compile time!
            Console.Beep();
            Console.WriteLine("Error: {0} ", message);
            Console.WriteLine("text value = {0} ", text);
        }

        static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
        {
            // Store old colors to restore after the message is printed
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgorundColor = Console.BackgroundColor;

            // Set new colors and print the message
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;

            Console.WriteLine(message);

            // Restore the previous colors
            Console.BackgroundColor = oldbackgorundColor;
            Console.ForegroundColor = oldTextColor;

        }
    }
}
