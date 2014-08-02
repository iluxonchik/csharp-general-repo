using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierachy
{

    public interface IDrawable
    {
        void Draw();
    }

    public interface IAdvancedDraw : IDrawable
    {
        void DrawInBoundingBox(int top, int left, int bottom, int right);
        void DrawUpSideDown();
    }

    public class BitmapImage : IAdvancedDraw
    {

        // Implement every member defined up the chain of inheritance
        public void Draw()
        {
            Console.WriteLine("Drawing...");
        }
        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine("Drawing in a box...");
        }

        public void DrawUpSideDown()
        {
            Console.WriteLine("Drawing upside down...");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple Interface Hierarchy *****\n");

            // Call from object level
            BitmapImage myBitmap = new BitmapImage();
            myBitmap.Draw();
            myBitmap.DrawInBoundingBox(10, 10, 10, 10);
            myBitmap.DrawUpSideDown();

            // Get IAdvancedDraw explicitly
            IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
            if (iAdvDraw != null)
                iAdvDraw.DrawUpSideDown();

            Console.ReadLine();
            
        }
    }
}
