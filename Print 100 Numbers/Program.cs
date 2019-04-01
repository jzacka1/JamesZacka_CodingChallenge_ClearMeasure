using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CustomerMethods.CustomerClass;

namespace Print_100_Numbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Print100();

            for(int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i]);
            }
        }
    }
}
