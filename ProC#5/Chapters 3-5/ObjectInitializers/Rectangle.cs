using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Rectangle
    {
        private Point topLeft = new Point();
        private Point bottomRight = new Point();

        public Point TopLeft
        {
            get { return this.topLeft; }
            set { this.topLeft = value; }
        }

        public Point BottomRight
        {
            get { return this.bottomRight; }
            set { this.bottomRight = value; }
        }

        public void DisplayStats()
        {
            Console.WriteLine("[TopLeft: {0}, {1}, {2} BottomRight: {3}, {4}, {5}]", this.topLeft.X, this.topLeft.Y, this.topLeft.Color, this.bottomRight.X, 
                this.bottomRight.Y, this.bottomRight.Color);
        }
    }
}
