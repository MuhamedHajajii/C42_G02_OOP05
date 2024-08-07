using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_OOP05.FirstProject
{
    internal class Point : IComparable,IComparer,ICloneable
    {
        #region Properties
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        #endregion

        #region Constructors

        public Point()
        {
            
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point(double x, double y, double z) : this(x, y)
        {
            Z = z;
        }

        public Point(Point p):this(p.X,p.Y,p.Z)
        {
            
        }

        #endregion

        #region Methods - Override
        public override string ToString()
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }

        public int CompareTo(object? obj)
        {
            Point PassPoint = (Point)obj!;
            if (this.X > PassPoint.X)
                return 1;
            else if (this.X < PassPoint.X)
                return -1;
            else
                return 0;
        }

        public int Compare(object? x, object? y)
        {
            Point? passingPoint01 = (Point?) x;
            Point? passingPoint02 = (Point?) y;

            return passingPoint01?.Y.CompareTo(passingPoint02?.Y) ?? (passingPoint02 is null ? 0 : -1);
            

        }

        public object Clone()
        {
            return new Point(this);
        }

        #endregion

    }
}
