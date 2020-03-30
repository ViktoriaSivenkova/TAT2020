using System;
using System.Collections.Generic;
using System.Text;

namespace Dev4
{
    public class Bird : IFlyable
    {
        Point _currentPoint;

        public Bird (Point currentPoint)
        {
            CurrentPoint = currentPoint;
        }

        public Point CurrentPoint
        {
            get => _currentPoint;
            set
            {
                _currentPoint = value;
            }            
        }
        /// <summary>
        /// Methods that changes current positoin  to new point when bird flew.
        /// When bird will not fly to new point will be exception.
        /// Current positoin changes to new point when bird flew.
        /// Flight time can not be mo than MaxBirdFlyTime.
        /// </summary>
        /// <param name="newPoint"></param>
        /// <returns></returns>
        public void FlyTo(Point newPoint)
        {
            var flyTime = GetFlyTime(newPoint);
            if (flyTime > TimeSpan.FromHours(ConstantValues.MaxBirdFlyTime))
            {
                throw new ArgumentException($"Bird's flight time '{flyTime}' is longer than max fly time '{ConstantValues.MaxBirdFlyTime}'");
            }
            else
            {
                CurrentPoint = newPoint;
                Console.WriteLine("Bird flew to the end point");
            }
        }

        /// <summary>
        /// Method that returns bird fligth time to a new point.
        /// Bird speed has random value from 0 to 20.
        /// </summary>
        /// <param name="newPoint"></param>
        /// <returns></returns>
        public TimeSpan GetFlyTime(Point newPoint)
        {
            Random random = new Random();
            double birdSpeed = random.Next(0, 20);
            if (birdSpeed == 0)
            {
                throw new ArgumentException("Bird's speed should be greater than zero.");
            }
            else
            {
                var flyTime = CurrentPoint.FindDistance(newPoint, CurrentPoint) / birdSpeed;
                return TimeSpan.FromHours(flyTime).NoMilliseconds();
            }
        }
    }
}
