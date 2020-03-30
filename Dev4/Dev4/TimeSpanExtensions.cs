using System;
using System.Collections.Generic;
using System.Text;

namespace Dev4
{
    public static class TimeSpanExtensions
    {
        public static TimeSpan NoMilliseconds(this TimeSpan currentTimespan)
        {
            return new TimeSpan(currentTimespan.Ticks / TimeSpan.TicksPerSecond * TimeSpan.TicksPerSecond);
        }

        public static string ToFormattedString(this TimeSpan currentTimespan)
        {
            var formattedString = string.Format("{0:D2} days, {1:D2} hours, {2:D2} minutes, {3:D2} sec",
                currentTimespan.Days,
                currentTimespan.Hours,
                currentTimespan.Minutes,
                currentTimespan.Seconds);
            return formattedString;
        }
    }
}
