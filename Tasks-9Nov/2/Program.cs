using System;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_9Nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 2.1
   
            // Test if someone tries to set mass to a negative value
            Point point1 = new Point(1, 3, 4, -4);
            double mass = point1.GetMass();
            bool isZero = point1.IsZero();

            // Test if someone set all coordinates to 0
            Point point2 = new Point(0, 0, 0, 3);
            isZero = point2.IsZero();
            mass = point2.GetMass();

            // Test CalculateDistance()
            double distance = point2.CalculateDistance(point1);

            Training training = new Training(null);

        }
    }
}
