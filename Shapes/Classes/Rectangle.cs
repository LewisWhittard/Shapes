using System.Drawing;

namespace Shapes.Classes
{
    internal class Rectangle : Shape
    {
        private int _width;
        private int _height;
        private int _area;
        private int _circumference;

        public int Width
        { get { return _width; }
            private set { _width = value; }
        }

        public int Height
        {
            get { return _height; }
            private set { _height = value; }
        }

        public int Area
        {
            get { return _area; }
            private set { _area = value; }
        }

        public int Circumference
        {
            get { return _circumference; }
            private set { _circumference = value; }
        }

        public Rectangle(Point position, Color colour, int width, int height) : base(position, colour)
        {
            Width = width;
            Height = height;
            this.Area = CalculateArea();
            this.Circumference = CalculateCircumference();

        }

        private int CalculateArea()
        {
            return _width * _height;
        }

        private int CalculateCircumference()
        {
            return 2 * (_width + _height);
        }
    }

}

}
}
