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

        public bool FlyTo(Point newPoint)
        {
            GetFlyTime(newPoint);
            CurrentPoint = newPoint;
            return true;
        }
        /// <summary>
        /// Method which gets plane fligth time 
        /// Condition: plane increases speed on 10km/hour every 10 km. Start speed = 200 km/hour
        /// </summary>
        /// <param name="newPoint"> finish point </param>
        /// <returns>plane fligth time</returns>
        public TimeSpan GetFlyTime(Point newPoint)
        {
            //Set start plane speed
            double speed = ConstantValues.PlaneStartSpeed;
            TimeSpan flyTime = TimeSpan.FromHours(0);

            //Count time for every 10 km of flight. 
            //Subtract from distans beetween finish and start point 10 km, count the tine
            for (double distance = CurrentPoint.FindDistance(newPoint, CurrentPoint); distance > 0; distance -= ConstantValues.PlaneSpeedIncrease)
            {
                if (distance >= ConstantValues.PlaneSpeedIncrease) 
                {
                    flyTime += TimeSpan.FromHours(ConstantValues.PlaneSpeedIncrease / speed);
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
