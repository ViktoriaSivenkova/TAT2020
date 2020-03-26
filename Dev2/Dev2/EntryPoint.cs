using System;

namespace Dev2
{
    class EntryPoint
    {
        public static int DecimalNumber { get; set; }
        public static int RequiredBase { get; set; }

        /// <summary>
        /* Entry point
         Checking for number of arguments and check correct
         or not our base for convert. */
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                if (args.Length > 2)
                {
                    Console.WriteLine("Your number of arguments is greater than 2, program will continue work with the 1st and 2nd argument");
                }

                DecimalNumber = Convert.ToInt32(args[0]);
                RequiredBase = Convert.ToInt32(args[1]);
                var numbersConverter = new ConvertingFromDecimalToAnotherSystem(DecimalNumber, RequiredBase);
                var convertingResult = numbersConverter.ConvertDecimalNumberToAnotherSystem();
                Console.WriteLine($"Result of converting = {convertingResult}");
            }

            catch (IndexOutOfRangeException)
            {
                if (args.Length <= 2)
                {
                    Console.Error.WriteLine("Invalid number of arguments.");
                }
            }

            catch (FormatException)
            {
                Console.Error.WriteLine("Check your input, you need to input numbers.");
            }

            catch (ArgumentException)
            {
                if (RequiredBase < 2 || RequiredBase > 20)
                {
                    Console.Error.WriteLine("The base of the new system should be from 2 to 20");
                }
            }
        }
    }
}
