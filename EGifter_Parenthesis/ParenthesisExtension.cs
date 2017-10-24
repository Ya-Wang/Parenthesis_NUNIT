using System;

namespace EGifter_ParenthesisExtension
{
    public static class ParenthesisExtension
    {
        /// <summary>
        /// Checks to see if Parenthesis are matched and/or closed
        /// strings with no ( or ) will be valid
        /// </summary>
        /// <param name="input"> The string in question </param>
        /// <returns>If Parenthesis matches</returns>
        public static bool IsClosed(this string input)
        {
            // unsigned so that an exception would occur if first is a closed
            uint count = 0;
            try
            {
                checked
                {
                    for (int idx = 0; idx < input.Length; idx++)
                    {
                        switch (input[idx])
                        {
                            case '(':
                                count++;
                                continue;
                            case ')': 
                                count--;
                                continue;
                            default: //If anything other than what we care about
                                continue;
                        }  
                    }
                }
            }
            catch (OverflowException)
            {
                return false;
            }

            if (count == 0) // cool they match
                return true;
            
            return false;
        }
    }
}
