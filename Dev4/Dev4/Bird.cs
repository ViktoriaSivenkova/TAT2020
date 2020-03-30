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

        public bool FlyTo(Point newPoint)
        {
            var flyTime = GetFlyTime(newPoint);
            if (flyTime > TimeSpan.FromHours(ConstantValues.MaxBirdFlyTime))
            {
                throw new ArgumentException($"Bird's flight time '{flyTime}' is longer than max fly time '{ConstantValues.MaxBirdFlyTime}'");
            }
            else
            {
                CurrentPoint = newPoint;
                return true;
            }
        }

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
