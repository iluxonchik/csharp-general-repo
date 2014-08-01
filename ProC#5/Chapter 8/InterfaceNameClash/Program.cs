using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceNameClash
{
    public interface IDrawToForm
    {
        void Draw();
    }

    public interface IDrawToMemory
    {
        void Draw();
    }

    public interface IDrawToPrinter
    {
        void Draw();
    }

    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        
            // Explicitly bind Draw() implementations
            // to a given interface.

        void IDrawToForm.Draw()
        {
           Console.WriteLine("Drawing to form...");
        }

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing to memory...");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing to printer...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun With Interface Name Clashes *****\n");
            Octagon oct = new Octagon();

            // We now myst use casting to access the Draw() members
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            // Shorthand notation if you don't need the inerface
            // variable for later use
            ((IDrawToPrinter)oct).Draw();

            Console.ReadLine();
        }
    }

}
   
