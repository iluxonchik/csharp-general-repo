using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the Action<> delegate to point to DisplayMessage
            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message!", ConsoleColor.Blue, 5);

            Func<int, int, int> funcTarget1 = new Func<int, int, int>((int x, int y) => x + y);
            Func<int, int, string> funcTarget2 = new Func<int, int, string>(SumToString);

            Console.WriteLine(funcTarget1(2,2));
            Console.WriteLine(funcTarget2(2,3));
        }

        // This is a target for the Action<> delegate
        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            // Set color of console text
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            // Restore color
            Console.ForegroundColor = previous;
        }

        // Taget for Func<> delegate
        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }
    }
}
