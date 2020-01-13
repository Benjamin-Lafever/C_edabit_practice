using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit_Password_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversation convo = new Conversation();
            convo.Introduction();
            Console.ReadKey();
        }
    }

    class Conversation
    {
        public void Introduction()
        {
            Console.WriteLine("This program takes passwords and diplays wether they follow the listed instructions");
            Console.WriteLine("The rules are as follows: \n ");
            string rules = @" 
             - Length between 6 and 24 characters.
             - At least one uppercase letter(A - Z).
             - At least one lowercase letter(a - z). 
             - At least one digit(0 - 9).\n\Maximum of 2 repeated characters. 
             - 'aa' is OK 👍
             - 'aaa' is NOT OK 👎
             - Supported special characters: ! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; ' ? < >";
           
            Console.WriteLine(rules);
        }


        

    }
}


