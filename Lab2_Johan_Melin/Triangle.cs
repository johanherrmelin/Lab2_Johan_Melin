
namespace System.Numerics
{
    public class Triangle: Shape2D
    {

        private Vector3 _center;
        private float _area;
        private float _circumference;

        private float _sideXY;
        private float _sideYZ;
        private float _sideZX;

        private Vector2 _P1;
        private Vector2 _P2;
        private Vector2 _P3;


        public override Vector3 Center { get { return _center; } }
        public override float Area { get { return _area; } }
        public override float Circumference { get { return _circumference; } }



        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {

            _P1 = p1;
            _P2 = p2;
            _P3 = p3;

            float centerX = (p1.X + p2.X + p3.X) / 3;
            float centerY = (p1.Y + p2.Y + p3.Y) / 3;

            float triWidth = Math.Abs(p2.X - p3.X);
            float triHeight = Math.Abs(p2.Y - p1.Y);

            _sideXY = MathF.Sqrt(MathF.Pow((p1.X - p2.X), 2) + MathF.Pow((p1.Y - p2.Y), 2));
            _sideYZ = MathF.Sqrt(MathF.Pow((p2.X - p3.X), 2) + MathF.Pow((p2.Y - p3.Y), 2));
            _sideZX = MathF.Sqrt(MathF.Pow((p3.X - p1.X), 2) + MathF.Pow((p3.Y - p1.Y), 2));

            _center = new Vector3(centerX, centerY, 0f);
            _area = triHeight * triWidth / 2;
            _circumference = _sideXY + _sideYZ + _sideZX; 

        }
        public override string ToString()
        {
            return $"Triangle  @ {_center}: with P1 = {_P1:f2}, P2 = {_P2:f2} and P3 = {_P3:f2}. Area is {Area:f2} and the perimeter is {Circumference:f2}";
        }


    }
    }
