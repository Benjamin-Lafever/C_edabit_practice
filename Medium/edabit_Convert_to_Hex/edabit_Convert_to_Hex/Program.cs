using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit_Convert_to_Hex
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversation convo = new Conversation();
            Convert_To_Hex con = new Convert_To_Hex();

            string user_string;
            string hex_code;

            convo.Introduction();
            user_string = convo.User_Input();
            hex_code = con.ASCII2HEX(user_string);
            Console.WriteLine(hex_code);
            Console.ReadKey();


        }
    }

    class Conversation
    {
        public void Introduction()
        {
            Console.WriteLine("This program takes a string and converts it into Hexadecimal");
        }

        public string User_Input()
        {
            Console.WriteLine("Please enter a string: ");
            string user_string = Console.ReadLine();
            return user_string;
        }
    }

    class Convert_To_Hex
    {
        public string ASCII2HEX(string user_ASCII) {

            StringBuilder sb = new StringBuilder();

            byte[] inputBytes = Encoding.UTF8.GetBytes(user_ASCII);

            foreach(byte b in inputBytes)
            {
                sb.Append(string.Format("{0:x2}" + " " , b));
            }

            return sb.ToString();
        }
    }
}
