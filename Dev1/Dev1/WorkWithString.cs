using System;
using System.Collections.Generic;
using System.Linq;

namespace Dev1
{
    /// <summary>
    /// Class for the work with the strings.
    /// </summary>
    public class WorkWithString
    {
        /// <summary>
        /// Method which gets the number of 
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfMaxRepeatingSymbols(string inputString)
        {
            if (string.IsNullOrWhiteSpace(inputString) == true)
            {
                throw new Exception("Incorrect string");
            }

            int numberOfLetters = 1;
            var listNumberOfLetters = new List<int>();

            for (int i = 1; i < inputString.Length; i++)
            {
                if (inputString[i] == inputString[i - 1])
                {
                    numberOfLetters += 1;
                    if (inputString[i] == inputString[inputString.Length-1])
                    {
                        listNumberOfLetters.Add(numberOfLetters);
                    }

                }
                else
                {
                    listNumberOfLetters.Add(numberOfLetters);
                    numberOfLetters = 1;
                }
            }

            return inputString.Length == 1 ? 1 : listNumberOfLetters.Max(); // If string has only one any symbol - return 1
        }
    }
}