using System;

namespace AnagramOfPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Result.gameOfThrones("cdefghmnopqrstuvw"));
            Console.WriteLine("Hello World!");
        }
    }

    class Result
    {

        /*
         * Complete the 'gameOfThrones' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string gameOfThrones(string s)
        {

            // allow only one instance of a single/Odd character
            // all other characters must be multiple of 2 for everything else
            bool singleorCharBool = false;
            // keep track of characters checked for efficency
            string sCharacter = "";
            foreach (char charInS in s)
            {

                if (!sCharacter.Contains(charInS))
                {
                    string[] temp = s.Split('x');
                    int count = s.Split(charInS).Length-1;

                    // 
                    if (count == 1 && singleorCharBool)
                    {
                        return "NO";
                    }
                    else if (count == 1 && !singleorCharBool)
                    {
                        singleorCharBool = true;

                    }
                    else  // count is > 1
                    {
                        // only even number
                        if (count % 2 != 0)
                        {
                            if (singleorCharBool)
                            {
                                return "NO";
                            }
                            else
                            {
                                singleorCharBool = true;
                            }
                        }
                    }
                    sCharacter = sCharacter + charInS;
                }
            }

            return "YES";

        }

    }
}
