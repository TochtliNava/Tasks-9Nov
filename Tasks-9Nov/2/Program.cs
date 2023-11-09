using System;
using System.Text;
using System.Threading.Tasks;
using Tasks_9Nov._2;

namespace Tasks_9Nov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Task 2.1
   
            //  Test if someone tries to set mass to a negative value
            Point point1 = new Point(1, 3, 4, -4);
            double mass = point1.GetMass();
            bool isZero = point1.IsZero();

            //  Test if someone set all coordinates to 0
            Point point2 = new Point(0, 0, 0, 3);
            isZero = point2.IsZero();
            mass = point2.GetMass();

            //  Test CalculateDistance()
            double distance = point2.CalculateDistance(point1);

            //  Task 2.2

            Training training = new Training("true");
            Training training2 = new Training("false");
            
            PracticalLesson lesson = new PracticalLesson(null, null, null);
            PracticalLesson lesson2 = new PracticalLesson(null, null, null);

            LectureLesson lecture = new LectureLesson("POO en México");
            
            training.Add(lesson);
            training.Add(lesson2);

            training2.Add(lesson);
            training2.Add(lecture);

            bool isPractical = training.IsPractical();  // true
            isPractical = training2.IsPractical();      // false
        }
    }
}
