

namespace System.Numerics
{
    public class Cuboid : Shape3D
    {
        private Vector3 _center;
        private float _volume;
        private bool _isCube;
      
        public override Vector3 Center { get { return _center; } }
        public override float Volume { get { return _volume; } }
        public override float Area { get; }


        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _volume = size.X * size.Y * size.Z;
          

        }
        public Cuboid(Vector3 center, float width)
        {
            _center = center;
            _volume = width * width * width;


        }

        public override string ToString()
        {
            return $"circle @ {_center}: . The area of the circle is {_volume}";
        }




    }
}
