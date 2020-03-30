using System;
using System.Collections.Generic;
using System.Text;

namespace Dev4
{
    public class Plane : IFlyable
    {    
        Point _currentPoint;

        public Plane(Point currentPoint)
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
        /// Methods that returns true when plane will fly to new point.
        /// When plane will not fly to new point will be exception.
        /// Current positoin changes to new point when plane flew.
        /// </summary>
        /// <param name="newPoint">new point</param>
        /// <returns></returns>
        public void FlyTo(Point newPoint)
        {
            GetFlyTime(newPoint);
            CurrentPoint = newPoint;
            Console.WriteLine("Plane flew to the end point");
        }

        /// <summary>
        /// Method which gets plane fligth time 
        /// Condition: plane increases speed on 10km/hour every 10 km. Start speed = 200 km/hour
        /// Fligth speed can not be more than MaxPlaneSpeed.
        /// </summary>
        /// <param name="newPoint"> finish point </param>
        /// <returns>plane fligth time</returns>
        public TimeSpan GetFlyTime(Point newPoint)
        {
            //Plane start fly from start speed

            double speed = ConstantValues.PlaneStartSpeed;
            TimeSpan flyTime = TimeSpan.FromHours(0);

            //Count time for every 10 km of flight. 
            //Every 10 km count the time and increas speed on 10 km/hour 
            //If distanse less than 10 km when count the time for this distance  end return fly time for all distance

            for (double distance = CurrentPoint.FindDistance(newPoint, CurrentPoint); distance > 0; distance -= ConstantValues.PlaneSpeedIncrease)
            {
                if (distance >= ConstantValues.TenKilometers) 
                {
                    flyTime += TimeSpan.FromHours(ConstantValues.TenKilometers / speed);
                    speed += ConstantValues.PlaneSpeedIncrease;
                    if (speed > ConstantValues.MaxPlaneSpeed)
                    {
                        throw new ArgumentException($"Plane speed '{speed}' is greater than max plane speed '{ConstantValues.MaxPlaneSpeed}'");
                    }
                }
                else
                {
                    flyTime += TimeSpan.FromHours(distance / speed);
                }                
            }
            return flyTime.NoMilliseconds();
        }
    }
}
