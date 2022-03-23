using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworldnew131
{
    class Reversenumber
    {
        public static int FindReverse()
        {
            int reverse = 0, remainder = 0;
            Console.WriteLine("Enter number to reverse");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("reverse number is:" + reverse);
            return reverse;
        }
    }
}
