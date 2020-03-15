using System;

namespace Dev1
{
    public class Program
    {
        /// <summary>
        /// Entry point for program which counts the number of unrepeating symbols in the string.
        /// </summary>
        static void Main(string[] args)
        {
            var unitedString = string.Join(string.Empty, args);
            var stringWorker = new WorkWithString();
            var maxNumber = stringWorker.GetNumberOfMaxUnrepeatingSymbols(unitedString);
            Console.WriteLine(maxNumber);
        }
    }
}
