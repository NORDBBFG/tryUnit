namespace tryUnit
{
    public class Class1
    {

        public static int CountMaxUniqueConsecutiveChars(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] != s[i - 1])
                {

                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            return maxLength;
        }


        public static int CountMaxIdenticalLetters(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1] && Char.IsLetter(s[i - 1]) && Char.IsLetter(s[i]))
                {

                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            return maxLength;
        }

        public static int CountMaxIdenticalDigit(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int maxLength = 1;
            int currentLength = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1] && Char.IsDigit(s[i - 1]) && Char.IsDigit(s[i]))
                {

                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }

            return maxLength;
        }
    }
}
