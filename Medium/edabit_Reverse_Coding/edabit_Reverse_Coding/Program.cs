using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit_Reverse_Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            //objects
            Conversation convo = new Conversation();
            Calculate cal = new Calculate();

            //variables
            int number;
            string number_string;
            int result;

            convo.Introduction();
            number = convo.Number();
            number_string = cal.Convert_to_String(number);
            result = cal.Result(number_string);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    class Conversation
    {
        public void Introduction()
        {
            Console.WriteLine("You were given these samples of input and output");
            Console.WriteLine(" MysteryFunc(152) ➞ 10 \nMysteryFunc(832) ➞ 48 \nMysteryFunc(19) ➞ 9 \nMysteryFunc(133) ➞ 9");
            Console.WriteLine("You had to figure out what were the numbers going through and create \na program to reproduce the same results");
        }

        public int Number()
        {
            int a;
            Console.WriteLine("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            return a;
        }
    }

    class Calculate
    {
        public string Convert_to_String(int number)
        {
            string number_string = Convert.ToString(number);
            return number_string;
        }

        public int Result(string number_string)
        {
            int[] int_array = new int[number_string.Length];
            char[] char_array = new char[number_string.Length];
 
            int result = 1;
            int i = 0;

            foreach (char c in number_string)
            {
                char_array[i] = c;
                ++i;
            }

            for(int x = 0; x < number_string.Length; x++)
            {
                char holder = char_array[x];
                switch (holder)
                {
                    case '0':
                        int_array[x] = 0;
                        break;

                    case '1':
                        int_array[x] = 1;
                        break;

                    case '2':
                        int_array[x] = 2;
                        break;

                    case '3':
                        int_array[x] = 3;
                        break;

                    case '4':
                        int_array[x] = 4;
                        break;

                    case '5':
                        int_array[x] = 5;
                        break;

                    case '6':
                        int_array[x] = 6;
                        break;

                    case '7':
                        int_array[x] = 7;
                        break;

                    case '8':
                        int_array[x] = 8;
                        break;

                    case '9':
                        int_array[x] = 9;
                        break;

                    default:
                        Console.WriteLine("Something went wrong in the conversion stage");
                        break;
                }
               
            }

           foreach(int y in int_array)
            {
                result *= y;
            }


            return result;

        }
    }
}
