using System;

namespace Dev4
{
    /// <summary>
    /// Structure Point with points which can be used in appropriate classes.
    /// </summary>
    public struct Point
    {
        private double _x;
        private double _y;
        private double _z;

        public Point(double x, double y, double z)
        {
            if (x < 0 || y < 0 || z < 0)
            {
                throw new ArgumentException("Incorrect point value.");
            }
            _x = x;
            _y = y;
            _z = z;
        }
        public double FindDistance(Point point_one, Point point_two)
        {
            return Math.Sqrt((point_one._x - point_two._x) * (point_one._x - point_two._x) +
            (point_one._y - point_two._y) * (point_one._y - point_two._y) +
            (point_one._z - point_two._z) * (point_one._z - point_two._z));
        }
    }
}