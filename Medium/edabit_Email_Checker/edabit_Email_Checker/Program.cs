using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace edabit_Email_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objects
            Conversation convo = new Conversation();
            Valid_Email_Check val = new Valid_Email_Check();

            //variables
            
            string email;
            Boolean final_result;

            convo.Introduction();
            email = convo.Email_string();
            string[] email_address = new string[email.Length];
            email_address = convo.Email_array(email);
            final_result = val.Email_Check(email_address, email);
            convo.Result(final_result, email);
            Console.ReadKey();
        }
    }

    class Conversation
    {

        public void Introduction()
        {
            Console.WriteLine("Hello this  program takes in a string and interprets if it is a valid email address or not" );
        }

        public string Email_string()
        {
            string email;
            Console.WriteLine("Please enter a email address: ");
            email = Console.ReadLine();

            return email;
            
        }

        public string[] Email_array(string email)
        {
            string[] email_address = new string[email.Length];

            for (int i = 0; i < email.Length; i++)
            {
                foreach (char c in email)
                {
                    email_address[i] = Convert.ToString(c);
                }
            }

            return email_address;
        }

        public void Result(Boolean final_result, string email)
        {

            if(final_result == true)
            {
                Console.WriteLine(email + " is a valid email address");
            }
            else
            {
                Console.WriteLine(email + " is an invalid email address");
            }

        }
    }

    class Valid_Email_Check
    {

        public Boolean Email_Check(string[] email_address, string email)
        {
            Boolean at_character_check = false;
            Boolean words_before_at_check = false;
            Boolean period_after_at_check = false;
            Boolean com_after_period_check = false;
 
            Boolean all_checks_cleared = false;

            //loop to find @ character and isn't at [0]
            for(int i = 0; i < email.Length; i++)
            {
                foreach(char x in email)
                {
                    if (x == '@')
                    {
                        at_character_check = true;
                    }
                    if(email[0] != '@')
                    {
                        words_before_at_check = true;
                    }
                    if (x == '.' && at_character_check == true)
                    {
                        period_after_at_check = true;
                    }

                    int email_length = Convert.ToInt32(email.Length);
                    int char_c_place = email_length - 3;
                    int char_o_place = email_length - 2;
                    int char_m_place = email_length - 1;
                    char c = email[char_c_place];
                    char o = email[char_o_place];
                    char m = email[char_m_place];

                    if(c == 'c' && o == 'o' && m == 'm')
                    {
                        com_after_period_check = true;
                    }
                  
                }

                if (at_character_check == true && words_before_at_check == true && period_after_at_check == true && com_after_period_check == true)
                {
                    all_checks_cleared = true;
                }
            }

            return all_checks_cleared;
        }
    }
}
