using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit_Less_Than_Zero_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool true_or_false = false;

            Console.WriteLine("Enter a number and if it is less than or equal to 0 true will be displayed: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number <= 0)
            {
                true_or_false = true;
                Console.WriteLine("The answer is {0}", true_or_false);
                Console.ReadKey();
            }
            else
            {
                true_or_false = false;
                Console.WriteLine("The answer is {0}", true_or_false);
                Console.ReadKey();
            }
        }
    }
}
