using System;
using System.Collections.Generic;
using System.Text;

namespace Dev4
{
    public struct Point
    {
        double _x;
        double _y;
        double _z;

        public Point (double x, double y, double z)
        {
            if (x < 0 || y < 0 || z < 0)
            {
                throw new ArgumentException("ArgumentExeption");
            }
            this._x = x;
            this._y = y;
            this._z = z;
        }
        public double FindDistance(Point point_one, Point point_two)
        {
            double distance = (Math.Sqrt((point_one._x - point_two._x) * (point_one._x - point_two._x) +
            (point_one._y - point_two._y) * (point_one._y - point_two._y) +
            (point_one._z - point_two._z) * (point_one._z - point_two._z)));
            return distance;
        }
    }
}
