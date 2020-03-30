using System;
using System.Collections.Generic;
using System.Text;

namespace Dev4
{
    public interface IFlyable
    {
        void FlyTo(Point point);
        TimeSpan GetFlyTime(Point point);
    }
}
