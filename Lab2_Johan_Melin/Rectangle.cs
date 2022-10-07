
using System.Drawing;

namespace System.Numerics
{
    public class Rectangle : Shape2D
    {

        private Vector3 _center;
        private float _area;
        private float _circumference;
        private bool _isSquare;

        private float _width;
        private float _height;

       

        public override Vector3 Center { get { return _center; } }
        public override float Area { get { return _area; } }
        public override float Circumference { get { return _circumference; } }
        public bool Square { get { return _isSquare; } }




        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = new Vector3(center, 0f);
            _width = Math.Abs(size.X);
            _height = Math.Abs(size.Y);
            _area = _height * _width;
            _circumference = 2 * _height + _width;
            _isSquare = false;

            if (_width == _height)
            {
                _isSquare = true;

            }
        }


        public Rectangle(Vector2 center, float width)
        {
            _center = new Vector3(center, 0f);
            _width = Math.Abs(width);
            _height = _width;
            _circumference = 2 * _height + _width;
            _area = _height * _width;
            _isSquare = true;

        }



        public override string ToString()
        {
            if (_isSquare == false)
            {
                return $"Rectangle @ {_center}: width = {_width} and height =  {_height}. The area of the Rectangle is {_area}. Is it a square: {_isSquare}";
            }
            else
            {
                return $"Square    @ {_center}: width = {_width} and height =  {_height}. The area of the Square is {_area}. Is it a square: {_isSquare}";
            }
        }
    }
}
