using System;
using System.Text.RegularExpressions;

namespace Dev3
{
    /// <summary>
    /// Class with different extension methods for the help with strings.
    /// </summary>
    public static class StringHelpers
    {
        /// <summary>
        /// Checks cases when string is null or empty.
        /// </summary>
        public static bool IsNullOrEmptyString(this string currentString, string currentStringName)
        {
            switch (currentString)
            {
                case null:
                    throw new ArgumentNullException($"Your string '{currentStringName}' is null");
                case "":
                    throw new FormatException($"Your string '{currentStringName}' is empty");
                default:
                    return false;
            }
        }

        /// <summary>
        /// Checks string for condition that string has only latin and numeric symbols.
        /// </summary>
        public static bool IsLatinAndNumericString(this string currentString, string currentStringName)
        { 
            var regex = new Regex("^[A-z0-9]+$"); // Expression for strings which have only latin and numeric symbols
            var exceptionMessage = $"Your string '{currentStringName}' should contain only latin and numeric symbols, your current input : {currentString}";
            return regex.IsMatch(currentString) != true ? throw new FormatException(exceptionMessage) : true;
        }
    }
}
