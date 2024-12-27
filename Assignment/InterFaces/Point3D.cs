using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterFaces
{
    internal class Point3D:ICloneable,IComparable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Point3D() : this(0, 0, 0) 
        {
        }
        public Point3D(double x, double y) : this(x, y, 0) 
        {
        }
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"“Point Coordinates: ({X}, {Y}, {Z})”";
        }

        public object Clone()
        {
            return new Point3D(X, Y)
            { X = X, Y = Y, };
        }

        public int CompareTo(object? obj)
        {
            Point3D?other = (Point3D?)obj;
            return this.X.CompareTo(other?.X);
            return this.Y.CompareTo(other?.Y);

        }
    }
}
