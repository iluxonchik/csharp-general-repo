using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomConvertions
{
    class Program
    {
        public struct Rectangle
        {
            public int Width { get; set; }
            public int Height { get; set; }
            // Since we are using the automatic property in the struct
            // the default constructor must be explicitly called (from all custom
            // constructors) to initilialize the private backing fields.
            public Rectangle(int w, int h) : this() { Width = w; Height = h; }
            public void Draw()
            {
                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    { Console.Write("*"); }
                    Console.WriteLine();
                }
            }
            public override string ToString() { return string.Format("[Width = {0}; Height = {1}]", Width, Height); }

            public static implicit operator Rectangle(Square s)
            {
                return new Rectangle(s.Length, s.Length * 2);
            }
        }

        public struct Square
        {
            public int Length { get; set; }

            public Square(int l) : this() { Length = l; }
            public void Draw()
            {
                for (int i = 0; i < Length; i++)
                {
                    for (int j = 0; j < Length; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            public override string ToString() { return string.Format("[Length = {0}]", Length); }

            public static explicit operator Square(Rectangle r)
            {
                Square s = new Square();
                s.Length = r.Height;
                return s;
            }

            public static explicit operator Square(int i)
            {
                return new Square(i);
            }

            public static explicit operator int(Square s)
            {
                return s.Length;
            }
        }

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(15, 4);
            Console.WriteLine(r.ToString());
            r.Draw();

            Square s = (Square)r;
            Console.WriteLine(s.ToString());
            s.Draw();

            Square s2 = (Square)5;
            Console.WriteLine(s2);
            s2.Draw();

            int j = (int)s2;
            Console.WriteLine(j);

            Square s3 = new Square(3);
            Rectangle r2 = s3; // implicit cast
            Square s4 = new Square(5);
            Rectangle r3 = (Rectangle)s4; // explicit cast, still OK!

        }
    }
}
