

namespace System.Numerics
{
    public class Cuboid : Shape3D
    {
        private Vector3 _center;
        private float _volume;
        private float _area;
        private bool _isCube;

        private float _width;
        private float _height;
        private float _depth;

        public override Vector3 Center { get { return _center; } }
        public override float Volume { get { return _volume; } }
        public override float Area { get { return _area; } }
        public bool Cube { get { return _isCube; } }


        public Cuboid(Vector3 center, Vector3 size)
        {
            _center = center;
            _width = Math.Abs(size.X);
            _height = Math.Abs(size.Y);
            _depth = Math.Abs(size.Z);
            _volume = (_width * _depth * _height);
            _area = 2 * ((_width * _height) + (_height * _depth) + (_depth * _width));
            _isCube = false;

            if (size.X == size.Y && size.X == size.Z)
            {
                _isCube = true;
            }

        }
        public Cuboid(Vector3 center, float side)
        {
            _center = center;
            _width = Math.Abs(side);
            _height = Math.Abs(side);
            _depth = Math.Abs(side);
            _volume = _width * 3;
            _isCube = true;

        }

        public override string ToString()
        {

            if (_isCube == false)
            {
                return $"Cuboid    @ {_center}: W = {_width:f2}, H = {_height:f2}, D = {_depth:f2}. Volume is: {Volume:f2}. Is it a cube: {_isCube}";
            }
            else
            {
                return $"Cube      @ {_center}: W = {_width}, H = {_height}, D = {_depth}. Volume is: {Volume}. Is it a cube: {_isCube}";
            }

        }




    }
}
