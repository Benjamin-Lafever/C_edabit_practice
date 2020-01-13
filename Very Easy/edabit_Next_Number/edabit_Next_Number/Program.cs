using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit_Next_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be incremented: ");
            int incremented = Convert.ToInt32(Console.ReadLine());
            incremented += 1;
            Console.WriteLine(incremented);
            Console.ReadKey();
        }
    }
}
