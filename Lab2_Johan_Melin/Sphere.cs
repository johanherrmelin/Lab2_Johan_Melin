

namespace System.Numerics
{
    public class Sphere: Shape3D
    {

        private Vector3 _center;
        private float _volume;
        private float _radius;
        private float _area;

        public override Vector3 Center { get { return _center; } }
        public override float Volume { get { return _volume; } }
        public override float Area { get { return _area; } }





        public Sphere(Vector3 center, float radius)
        {
            _center = center;
            _radius = Math.Abs(radius);
            _volume =   (4.0f/3.0f) * MathF.PI * MathF.Pow(_radius, 3);
            _area = 4 * MathF.PI * MathF.Pow(_radius, 2);

        }

        public override string ToString()
        {
            return $"Sphere    @ {_center}: r = {_radius}. The volume of the sphere is {_volume} and the area is {_area}";
        }

    }
}
