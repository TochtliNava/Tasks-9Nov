using System;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_9Nov
{
    public class Point
    {
        private int[] _coordinates { get; }
        private float _mass { get; }

        public Point(int x, int y, int z, float mass)
        {
            _coordinates[0] = x;
            _coordinates[1] = y;
            _coordinates[2] = z;
            if (mass < 0)
            {
                _mass = 0;
            }
            else
            {
                _mass = mass;
            }
        }

        public float GetMass()
        {
            return _mass;
        }

        public int GetCoordinateX()
        {
            return _coordinates[0];
        }
        public int GetCoordinateY()
        {
            return _coordinates[1];
        }

        public int GetCoordinateZ()
        {
            return _coordinates[2];
        }

        public bool IsZero()
        {
            foreach (var coordinate in _coordinates)
            {
                if (coordinate > 0)
                {
                    return false;
                }
            }
            return true;
        }

        // d = `/(x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2
        public double CalculateDistance(Point point)
        {
            double distance = (point.GetCoordinateX() - GetCoordinateX()) ^ 2 +
                              (point.GetCoordinateY() - GetCoordinateY()) ^ 2 +
                              (point.GetCoordinateZ() - GetCoordinateZ()) ^ 2;
            distance = Math.Sqrt(distance);
            return distance;
        }
    }
}
