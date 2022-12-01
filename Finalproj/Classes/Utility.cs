using System;

namespace UtilityLibrary
{

    public class Utility
    {
        public static bool IsValid(String ccNumber)
        {
            bool valid = true;
            long sum = 0, number;
            int size = ccNumber.Length;
            if (size >= 13 && size <= 16)
            {
                if (ccNumber.Substring(0, 1).Equals("4") ||
                    ccNumber.Substring(0, 1).Equals("5") ||
                    ccNumber.Substring(0, 1).Equals("6") ||
                    ccNumber.Substring(0, 2).Equals("37"))
                {
                    if (long.TryParse(ccNumber, out number))
                    {
                        sum = SumOfDoubleEvenPlace(number, size) + SumOfOddPlace(number, size);

                        valid = (sum % 10 == 0);
                    }
                    else
                    {
                        // invalid entry
                        valid = false;
                    }
                }
                else
                {
                    // Doesn't start with correct prefix
                    valid = false;
                }
            }
            else
            {
                // number contains less than 13 digits or more than 16 digits.
                valid = false;
            }
            return valid;
        }

        public static int SumOfDoubleEvenPlace(long number, int size)
        {
            int sum = 0, offset;
            long product, digit;

            offset = (size % 2 == 0) ? 0 : 1;

            for (int i = size - 1; i >= 0; i--)
            {
                // Get the digit
                digit = number % 10;

                if ((i + offset) % 2 == 0)
                {
                    product = digit * 2;
                    sum += GetDigit((int)product);
                }

                // Remove the digit just processed
                number /= 10;
            }

            return sum;
        }

        public static int SumOfOddPlace(long number, int size)
        {
            int sum = 0, offset;
            long digit;

            offset = (size % 2 == 0) ? 0 : 1;

            for (int i = size - 1; i >= 0; i--)
            {
                // Get the digit
                digit = number % 10;

                // Sum the odd digits
                if ((i + offset) % 2 != 0)
                {
                    sum += (int)digit;
                }

                // Remove the digit just processed
                number /= 10;
            }

            return sum;
        }

        public static int GetDigit(int number)
        {
            int evenValue = 0;
            int digit;

            // determine if the value passed in is larger than a single digit
            if (number > 9)
            {
                // Get the digit
                digit = number % 10;

                // Remove the digit
                number /= 10;

                // Add it to the output value
                evenValue += digit;

                // Get the next digit
                digit = number % 10;

                evenValue += digit;

                return evenValue;
            }
            else
            {
                return number;
            }
        }
    }
}