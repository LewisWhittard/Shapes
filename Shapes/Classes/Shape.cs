using System.Drawing;

namespace Shapes.Classes
{
    internal class Shape
    {
        protected Color _colour;
        protected Point _position;

        public Color Colour 
        { 
            get { return this._colour; }
            private set { this._colour = value; }
        }

        public Point Position
        {
            get { return this._position; }
            private set { this._position = value; }
        }

        public Shape(Point position, Color colour)
        {
            this.Position = position;
            this.Colour = colour;
        }

        public string getCharecteristics() 
        {
            return $"The Position of this shape is X{this._position.X} and Y{this._position.Y}.The colour of the shape is {this._colour.Name}";   
        }

    }
}
