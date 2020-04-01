using System;

namespace Dev4
{
    /// <summary>
    /// Entry point of program which implements FlyTo and GetFlyTime method of IFlyable interface.
    /// </summary>
    class EntryPoint
    {
        static void Main(string[] args)
        {
            try
            {
                Point startPoint1 = new Point(0, 0, 0);
                Point finishPoint1 = new Point(4, 4, 4);

                Bird bird = new Bird(startPoint1);
                Console.WriteLine("Bird flight time is " + bird.GetFlyTime(finishPoint1).ToFormattedString());
                bird.FlyTo(finishPoint1);

                Point startPoint3 = new Point(5, 100, 0);
                Point finishPoint3 = new Point(25, 100, 0);

                Plane plane = new Plane(startPoint3);
                Console.WriteLine("Plane flight time is " + plane.GetFlyTime(finishPoint3).ToFormattedString());
                plane.FlyTo(finishPoint1);

                Point startPoint2 = new Point(55, 5, 0);
                Point finishPoint2 = new Point(55, 5, 23);

                Drone drone = new Drone(startPoint2);
                Console.WriteLine("Drone flight time is " + drone.GetFlyTime(finishPoint2).ToFormattedString());
                drone.FlyTo(finishPoint1);
            }
            catch (ArgumentException exception)
            {
                Console.Error.WriteLine(exception.Message);
            }
        }
    }
}
