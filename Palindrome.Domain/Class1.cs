using System;

namespace Palindrome.Domain
{
    public class Class1
    {
        public static bool PalindromeChecker(string input)
        {
            var str = input.ToLower(); // I'm assuming case insensitive
            var forwards = new System.Text.StringBuilder();
            var reverse = new System.Text.StringBuilder();

            for (var i = 0; i < str.Length; i++)
            {
                // remove spaces and special characters (I'm assuming it should ignore these)
                if (
                    (str[i] >= '0' && str[i] <= '9')
                    || (str[i] >= 'A' && str[i] <= 'z')
                )
                {
                    forwards.Append(str[i]);
                }

                // remove spaces and special characters and reverse string
                var reverse_index = str.Length - i - 1;
                if (
                    (str[reverse_index] >= '0' && str[reverse_index] <= '9')
                    || (str[reverse_index] >= 'A' && str[reverse_index] <= 'z')
                )
                {
                    reverse.Append(str[reverse_index]);
                }
            }

            // check if string is the same forwards and back
            if (forwards.ToString().Equals(reverse.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
