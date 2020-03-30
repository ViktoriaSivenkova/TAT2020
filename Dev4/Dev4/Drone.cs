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

        /// <summary>
        /// Methods that returns true when drone will fly to new point.
        /// When drone will not fly to new point will be exception.
        /// Current positoin changes to new point when drone flew.
        /// </summary>
        /// <param name="newPoint">new point</param>
        /// <returns></returns>
        public void FlyTo(Point newPoint)
        {
            GetFlyTime(newPoint);
            CurrentPoint = newPoint;
            Console.WriteLine("Drone flew to the end point");
        }

        /// <summary>
        /// Method that returns drone fligth time to a new point.
        /// Condition: dron hangs up on 1 minutes every 10 minutes. 
        /// Fligth distance can not be more than MaxDroneDistance.
        /// </summary>
        /// <param name="newPoint"></param>
        /// <returns></returns>
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
