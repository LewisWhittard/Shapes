using System.Drawing;

namespace Shapes.Classes
{
    internal class Shape
    {
        private Color _colour;
        private Point _position;

        public Color Colour 
        { 
            get { return _colour; }
            private set { _colour = value; }
        }

        public Point Position
        {
            get { return _position; }
            private set { _position = value; }
        }

        public Shape(Point position, Color colour)
        {
            this.Position = position;
            this.Colour = colour;
        }

        public string getCharecteristics() 
        {
            return $"The Position of this shape is X{this._position.X} and Y{this._position.Y}.The colour of the shape is {_colour.Name}";   
        }

    }
}
