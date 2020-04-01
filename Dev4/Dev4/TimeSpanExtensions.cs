using System;

namespace Dev4
{
    /// <summary>
    /// Class with extension methods for TimeSpan structure.
    /// </summary>
    public static class TimeSpanExtensions
    {
        /// <summary>
        /// Gets timespan without milliseconds.
        /// </summary>
        public static TimeSpan NoMilliseconds(this TimeSpan currentTimespan)
        {
            return new TimeSpan(currentTimespan.Ticks / TimeSpan.TicksPerSecond * TimeSpan.TicksPerSecond);
        }

        /// <summary>
        /// Method which convert timespan to more readable string.
        /// </summary>
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
