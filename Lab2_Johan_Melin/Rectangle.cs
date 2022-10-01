
namespace System.Numerics
{
    public class Rectangle : Shape2D
    {

        public Vector2 _center;
        public Vector2 _size;
        public float _area;
        public bool isSquare;

        public override Vector3 Center { get; }
        public override float Area { get { return _area; } }
        public override float Circumference { get; }

        public Rectangle(Vector2 center, Vector2 size)
        {
            _center = center;
            _size = size;
            _area = size.X * size.Y;
            if (size.X == size.Y)
            {
                isSquare = true;
                Console.WriteLine($"Is the shape a square: {isSquare}");
            }
            else if (size.X != size.Y)
            {
                Console.WriteLine($"Is this shape a square: {isSquare}");
            }

        }
        public Rectangle(Vector2 center, float width)
        {
            _center = center;
            _size = new Vector2(width, width);
            isSquare = true;
            Console.WriteLine($"The shape is a square: {isSquare}");

        }

        public override string ToString()
        {
            return $"Rectangle @ {_center}: width = {_size.X} and height =  {_size.Y}. The area of the Rectangle is {_area}";
        }




    }
}
