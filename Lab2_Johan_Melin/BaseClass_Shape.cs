﻿namespace System.Numerics
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
    }


    public abstract class Shape2D : Shape
    {
        public override Vector3 Center { get; }
        public abstract float Circumference 
        { 
            get; 
        }
    }

    public abstract class Shape3D : Shape
    {
        public abstract float Volume 
        { 
            get; 
        }

    }

}