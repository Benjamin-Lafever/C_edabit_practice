using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit_Remove_All_Special_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            // these characters are not allowed ! @ # $ % ^ & \ *
            char[] special_character_array = new char[] {'!', '@', '#', '$', '%', '^', '&', '/', '*', ')', '('};
            

            string user_string;
            string new_user_string;

            Conversation convo = new Conversation();
            String_Methods str_method = new String_Methods();

            convo.Introduction();
            user_string = convo.String_Input();
            List<char> user_char_array = new List<char>(user_string);
            user_char_array = str_method.Store_chars_in_Array(user_string, special_character_array);
            new_user_string = str_method.String_Loop(user_string, user_char_array, special_character_array);
            Console.WriteLine(new_user_string);
            Console.ReadKey();
        }
    }

    class Conversation
    {

        public void Introduction()
        {
            Console.WriteLine("This program takes a string as input and removes these special characters: ! @ # $ % ^ & / *");
        }

        public string String_Input()
        {
            string user_string; 

            Console.WriteLine("Enter your string: ");
            user_string = Console.ReadLine();

            return user_string;
        }
    }

    class String_Methods
    {
        public List<char> Store_chars_in_Array(string user_string, char[] special_character_array)
        {
            List<char> user_char_array = new List<char>(user_string);
            int i = 0;


            foreach(char c in user_string)
            {
                user_char_array[i] = c;
                i++;
            }

            return user_char_array;
            
        }

        public string String_Loop(string user_string, List<char> user_char_array, char[] special_character_array)
        {
            int counter_user_char_array_size = user_string.Length;
            int counter_special_character_array = 11;
            string new_user_string = "";

            for(int i = 0; i < counter_user_char_array_size; i++)
            {
                for(int x = 0; x < counter_special_character_array; x++)
                {
                    if(user_char_array[i] == special_character_array[x])
                    {
                        user_char_array.RemoveAt(i);
                        i--;
                        counter_user_char_array_size--;
                       
                        Console.WriteLine(i);
                    }
                    if(i == -1)
                    {
                        i++;
                    }
                }
            }
         
            foreach(char p in user_char_array)
            {
                new_user_string += p;
            }

            return new_user_string;
        } 
    }
}
