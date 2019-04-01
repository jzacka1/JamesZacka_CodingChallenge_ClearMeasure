using System;

namespace CustomerMethods
{
    public class CustomerClass
    {
        public static string[] Print100()
        {
            string[] strArr = new string[100];

            //THROUHG EACH ITERATION, ADD A NUMBER AND THE WORDS, 'Fizz', 'Buzz', OR BOTH
            //INTO THE ARRAY
            for (int i = 1; i <= 100; i++)
            {
                strArr[i-1] = i.ToString() + " ";

                //IF NUMBER IS DIVISABLE BY 3, PRINT 'Fizz'
                if (i % 3 == 0)
                {
                    strArr[i - 1] += "Fizz";
                }

                //IF NUMBER IS DIVISABLE BY 5, PRINT 'Buzz'
                if (i % 5 == 0)
                {
                    strArr[i - 1] += "Buzz";
                }
            }

            return strArr;
        }
    }
}
