using System;
using System.Text;

namespace Dev2
{
    public class ConvertingFromDecimalToAnotherSystem
    {
        int _decimalNumber;
        int _valueOfBaseOfNewSystem;
        int _temporaryNumber;
        private const string baseSymbols = "0123456789ABCDEFGHIJ";

        /// <summary>
        /// Class constructor for NumeralSystemConverter.
        /// </summary>
        /// <param name="number">Decimal number.</param>
        /// <param name="newBase">New base of numeral system.</param>

        public ConvertingFromDecimalToAnotherSystem(int decimalNumber, int valueOfBaseOfNewSystem)
        {
            if (valueOfBaseOfNewSystem >= 2 && valueOfBaseOfNewSystem <= 20)
            {
                _decimalNumber = decimalNumber;
                _valueOfBaseOfNewSystem = valueOfBaseOfNewSystem;
            }
            else
            {
                throw new ArgumentException("The base of the new system should be from 2 to 20");
            }
        }

        /// <summary>
        /// Method that converts a decimal number to a new number system.
        /// </summary>
        /// <returns>Number in another system</returns>
        public string ConvertDecimalNumberToAnotherSystem()
        {
            var convertingResult = new StringBuilder();
            _temporaryNumber = Math.Abs(_decimalNumber);

            if (_decimalNumber == 0)
            {
                return convertingResult.Append(0).ToString();
            }

            while (_temporaryNumber > 0)
            {
                convertingResult.Append(baseSymbols[_temporaryNumber % _valueOfBaseOfNewSystem]);
                _temporaryNumber /= _valueOfBaseOfNewSystem;
            }

            return _decimalNumber >= 0 ? Reverse(convertingResult.ToString()) : "-" + Reverse(convertingResult.ToString());
        }

        /// <summary>
        ///  Method that reverse number.
        /// </summary>
        /// <param name="convertingResult">String for reverse</param>
        /// <returns>Reverse string</returns>
        private string Reverse(string convertingResult)
        {
            var reversedString = new StringBuilder();

            for (int i = convertingResult.Length - 1; i >= 0; i--)
            {
                reversedString.Append(convertingResult[i]);
            }
            return reversedString.ToString();
        }
    }
}
