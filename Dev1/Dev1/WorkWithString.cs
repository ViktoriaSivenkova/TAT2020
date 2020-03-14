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
        public int CompareNumberOfLettersWithBufferNumberOfLetters(ref int numLetters,ref int bufferNum)
        {
            if (numLetters > bufferNum)
            {
                bufferNum = numLetters;                
            }
            return bufferNum;          
        }

        public void CheckOnTheEndOfLine(int i, string str, ref int numLet,ref int buf)
        {
            if (i == str.Length - 1)
            {
                buf = CompareNumberOfLettersWithBufferNumberOfLetters(ref numLet,ref buf);
                numLet = 1;                
            }
            
        }

        /// <summary>
        /// Method which gets the number of 
        /// </summary>
        /// <returns></returns>
        public int GetNumberOfMaxRepeatingSymbols(string inputString)
        {
            if (inputString == null)
            {
                throw new Exception("UndefindException");
                //return 0;
            }
            
            

            int numberOfLetters = 1;
            int bufferNumberOfLetters = 0;
                        
            for (int i = 1; i < inputString.Length; i++)
            {
                if (inputString[i] == inputString[i - 1])
                {
                    numberOfLetters += 1;
                    CheckOnTheEndOfLine(i, inputString, ref numberOfLetters,ref bufferNumberOfLetters);              
                   
                }
                else
                {
                    bufferNumberOfLetters = CompareNumberOfLettersWithBufferNumberOfLetters(ref numberOfLetters,ref bufferNumberOfLetters);
                    numberOfLetters = 1;                    
                }
            }

            return inputString.Length == 1 ? 1 : bufferNumberOfLetters; // If string has only one any symbol - return 1
        }
    }
}