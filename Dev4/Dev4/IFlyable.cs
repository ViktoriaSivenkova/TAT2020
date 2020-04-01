using System;

namespace Dev4
{
    /// <summary>
    /// Interface with flyable methods declaration for the next implementation in classes.
    /// </summary>
    public interface IFlyable
    {
        void FlyTo(Point point);
        TimeSpan GetFlyTime(Point point);
    }
}
