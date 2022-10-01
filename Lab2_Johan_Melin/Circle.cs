namespace System.Numerics
{
    public class Circle : Shape2D
    {
        public Vector2 _center;
        public float _area;
        public float _radius;
        public float _diameter;
        public override Vector3 Center { get; }
        public override float Area { get { return _area; } }
        public override float Circumference { get { return _diameter * Convert.ToSingle(Math.PI); } }

        public Circle(Vector2 center, float radius)
        {
            _center = center;
            _radius = radius;
            _area = MathF.PI * (radius * radius);
            _diameter = radius * 2;

        }

        public override string ToString()
        {
            return $"circle @ {_center}: r = {_radius}. The area of the circle is {_area} and the diameter is {_diameter}";
        }
    }
}
