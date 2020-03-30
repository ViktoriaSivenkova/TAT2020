using System;
using System.Collections.Generic;
using System.Text;

namespace Dev4
{
    public class Drone : IFlyable
    {
        Point _currentPoint;
        public Drone(Point currentPoint)
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
            GetFlyTime(newPoint);
            CurrentPoint = newPoint;
            return true;
        }


        public TimeSpan GetFlyTime(Point newPoint)
        {
            TimeSpan flyTime = TimeSpan.FromHours(0);
            double distance = CurrentPoint.FindDistance(newPoint, CurrentPoint);

            if (distance > ConstantValues.MaxDroneDistance)
            {
                throw new ArgumentException($"Drone flight distance '{distance}' is longer than max fly distance '{ConstantValues.MaxDroneDistance}'");
            }

            while (distance > 0)
            {
                if (distance - (ConstantValues.DroneSpeed * ConstantValues.TenMinutesInHours) >= 0)
                {
                    flyTime += TimeSpan.FromMinutes(11);
                }
                else
                {
                    flyTime += TimeSpan.FromHours(distance / ConstantValues.DroneSpeed);
                }
                distance -= ConstantValues.DroneSpeed * ConstantValues.TenMinutesInHours;
            }
            return flyTime.NoMilliseconds();
        }
    }
}
