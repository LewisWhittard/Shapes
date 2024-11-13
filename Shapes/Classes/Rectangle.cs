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
            return this._width * this._height;
        }

        private int CalculateCircumference()
        {
            return 2 * (this._width + this._height);
        }

        public string getCharecteristics()
        {
            return $"The Position of this shape is X{this._position.X} and Y{this._position.Y}.The colour of the shape is {this._colour.Name}. The area is {this._area}. The circumference is {this._circumference}";
        }
    }

}

}
}
