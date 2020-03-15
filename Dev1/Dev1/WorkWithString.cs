using System;

namespace Dev1
{
    /// <summary>
    /// Class for the work with the string.
    /// </summary>
    public class WorkWithString
    {
        /// <summary>
        /// Method which gets max number of unrepeating consecutive symbols in string
        /// </summary>
        public int GetNumberOfMaxUnrepeatingSymbols(string inputString)
        {
            //Checking that the entered string is not null
            if (inputString == null)
            {
                throw new NullReferenceException("String is null. Input your string.");
            }                     

            int numberOfSymbols = 1;
            int bufferNumberOfSymbols = 0;

            //Go along the string and find max number of unrepeating consecutive symbols in string
            for (int index = 1; index < inputString.Length; index++)
            {
                //If consecutive symbols are not equal then add 1 to the number of symbols 
                if (inputString[index] != inputString[index - 1])
                {
                    numberOfSymbols += 1;
                    CheckOnTheEndOfLine(index, inputString, ref numberOfSymbols, ref bufferNumberOfSymbols);           
                }
                else                
                {
                    bufferNumberOfSymbols = CompareNumberOfSymbolsWithBufferNumberOfSymbols(ref numberOfSymbols, ref bufferNumberOfSymbols);
                    numberOfSymbols = 1;                    
                }
            }
            return inputString.Length == 1 ? 1 : bufferNumberOfSymbols; // If string has only one any symbol - return 1
        }

        /// <summary>
        /// Method which compare number of unrepeating consecutive symbols with max number of unrepeating consecutive symbols.
        /// </summary>
        private int CompareNumberOfSymbolsWithBufferNumberOfSymbols(ref int numberOfSymbols, ref int bufferNumberOfSymbols)
        {
            if (numberOfSymbols > bufferNumberOfSymbols)
            {
                bufferNumberOfSymbols = numberOfSymbols;
            }
            return bufferNumberOfSymbols;
        }

        /// <summary>
        /// Method which checks if string has ended
        /// </summary>
        private void CheckOnTheEndOfLine(int index, string inputString, ref int numberOfSymbols, ref int bufferNumberOfSymbols)
        {
            if (index == inputString.Length - 1)
            {
                bufferNumberOfSymbols = CompareNumberOfSymbolsWithBufferNumberOfSymbols(ref numberOfSymbols, ref bufferNumberOfSymbols);
                numberOfSymbols = 1;
            }
        }
    }
}