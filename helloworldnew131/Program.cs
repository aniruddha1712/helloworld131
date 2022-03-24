using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworldnew131
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 131");
            Console.WriteLine("1:FindReverse\n2:SwapNumber\n3:FlipCoin\n4:ReplaceUserName");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Reversenumber.FindReverse();
                    break;
                case 2:
                    Swapnumber.SwapTwoNumbers();
                    break;
                case 3:
                    FlipCoin.FindFlipCoinCount();
                    break;
                case 4:
                    ReplaceUser.ReplaceUserName();
                    break;
                default:
                    Console.WriteLine("Enter valid input");
                    break;
            }
            Console.ReadLine();

        }
    }
}
