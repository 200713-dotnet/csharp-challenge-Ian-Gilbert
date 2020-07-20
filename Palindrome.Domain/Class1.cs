using System;

namespace Palindrome.Domain
{
    public class Class1
    {
        public static bool PalindromeChecker(string input)
        {
            string forwards = new StringBuilder();
            string reverse = new StringBuilder();

            for (var i = 0; i < input.Length; i++)
            {
                if (
                    (input[i] >= '0' && input[i] <= '9')
                    || (input[i] >= 'A' && input[i] <= 'z')
                )
                {
                    forwards.Append(input[i]);
                }

                var reverse_index = input.Length - i - 1;
                if (
                    (input[reverse_index] >= '0' && input[reverse_index] <= '9')
                    || (input[reverse_index] >= 'A' && input[reverse_index] <= 'z')
                )
                {
                    reverse.Append(input[i]);
                }

                if (forwards.Equals(reverse))
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
}
