namespace System.Numerics
{

    public abstract class Shape
    {


        public abstract Vector3 Center { get; }
        public abstract float Area { get; }


        public static float NextDouble(Random rand, double minValue, double maxValue, int decimalPlaces)
        {
            return (float)(rand.NextDouble() * (maxValue - minValue) + minValue);
            
        }

        public static float RandomFloat()
        {
            var rand = new Random();
            float twoDecimalFloat =0;
            float randDecimal = NextDouble(rand, 0.00, 1.00, 2);
             twoDecimalFloat = (float)rand.Next(-15, 15) + randDecimal;
            return (float)Math.Round(twoDecimalFloat * 100f) / 100f;
        }

        public static Shape GenerateShape(Vector3 position)
        {
            var rand = new Random();
            int randShape = rand.Next(0, 7);
            Vector2 vec2 = new Vector2(position.X, position.Y);

           
            float P1XCoordinate = RandomFloat();
            float P1YCoordinate = RandomFloat();
            float P2XCoordinate = RandomFloat();
            float P2YCoordinate = RandomFloat();
            float P3XCoordinate = position.X * 3 - P1XCoordinate - P2XCoordinate;
            float P3YCoordinate = position.Y * 3 - P1YCoordinate - P2YCoordinate;

            if (randShape == 0)
            {

                return new Circle(new Vector2(vec2.X, vec2.Y), RandomFloat());
            }
            else if (randShape == 1)
            {
                return new Rectangle(new Vector2(vec2.X, vec2.Y), new Vector2(vec2.X, vec2.Y));
            }
            else if (randShape == 2)
            {
                return new Rectangle(new Vector2(position.X, position.Y), RandomFloat());
            }
            else if (randShape == 3)
            {
                return new Triangle(new Vector2(P1XCoordinate, P1YCoordinate), new Vector2(P2XCoordinate, P2YCoordinate), new Vector2(P3XCoordinate, P3YCoordinate));
            }
            else if (randShape == 4)
            {
                return new Cuboid(new Vector3(position.X, position.Y, position.Z), new Vector3(RandomFloat(), RandomFloat(), RandomFloat()));
            }
            else if (randShape == 5)
            {
                return new Cuboid(new Vector3(position.X, position.Y, position.Z), RandomFloat());
            }
            else
            {
                return new Sphere(new Vector3(position.X, position.Y, position.Z), RandomFloat());
            }
        }


        public static Shape GenerateShape()
        {
            var rand = new Random();
            int randShape = rand.Next(0, 7);

            if (randShape == 0)
            {

                return new Circle(new Vector2(RandomFloat(), RandomFloat()), RandomFloat());
            }
            else if (randShape == 1)
            {
                return new Rectangle(new Vector2(RandomFloat(), RandomFloat()), new Vector2(RandomFloat(), RandomFloat()));
            }
            else if (randShape == 2)
            {
                return new Rectangle(new Vector2(RandomFloat(), RandomFloat()), RandomFloat());
            }
            else if (randShape == 3)
            {
                return new Triangle(new Vector2(RandomFloat(), RandomFloat()), new Vector2(RandomFloat(), RandomFloat()), new Vector2(RandomFloat(), RandomFloat()));
            }
            else if (randShape == 4)
            {
                return new Cuboid(new Vector3(RandomFloat(), RandomFloat(), RandomFloat()), new Vector3(RandomFloat(), RandomFloat(), RandomFloat()));
            }
            else if (randShape == 5)
            {
                return new Cuboid(new Vector3(RandomFloat(), RandomFloat(), RandomFloat()), RandomFloat());
            }
            else
            {
                return new Sphere(new Vector3(RandomFloat(), RandomFloat(), RandomFloat()), RandomFloat());
            }


        }


    }


  



}