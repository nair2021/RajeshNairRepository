using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MM100
{
    /*
        a. Have the program go through the numbers 1 to 100 (inclusive)
        b. If the number is divisible by 3 only, output Modern
        c. If the number is divisible by 5 only, output Medical
        d. If the number is divisible by both 3 and 5, output ModernMedical
        e. If the number is not divisible by either 3 or 5, only output the number itself.
     */
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <=100; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("ModernMedical");
                    else
                    {
                        if (i % 3 == 0) Console.WriteLine("Modern");
                        else Console.WriteLine("Medical");
                    }
                   
                }
                else Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
