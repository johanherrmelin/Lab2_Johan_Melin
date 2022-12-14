namespace System.Numerics
{
    public class Circle : Shape2D
    {
        public Vector3 _center;
        private float _area;
        private float _circumference;

        private float _radius;
        private float _diameter;



        public override Vector3 Center { get{ return _center; } }
        public override float Area { get { return _area; } }
        public override float Circumference { get { return _circumference; } }



        public Circle(Vector2 center, float radius)
        {
            _center = new Vector3(center, 0f);
            _radius = Math.Abs(radius);
            _area = MathF.PI * MathF.Pow(_radius, 2);
            _diameter = _radius * 2;
            _circumference = _diameter * MathF.PI;

        }

        public override string ToString()
        {
            return $"Circle    @({_center.X:f2}, {_center.Y:f2}): r = {_radius:f2}. The area of the circle is {_area:f2} and the diameter is {_diameter:f2}";
        }
    }
}
