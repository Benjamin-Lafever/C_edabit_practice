using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit_Double_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objects
            Conversation convo = new Conversation();
            Check ch = new Check();

            //Variables
            string word;
            bool answer;

            //Program method calls
            convo.Introduction();
            word = convo.Enter_word();
            answer = ch.Check_for_Double(word);
            convo.Answer(answer);
        }
    }

    class Conversation
    {
        public void Introduction()
        {
            Console.WriteLine("Hello, this program will check a word to see if it has two consecutive identical letters");
            Console.WriteLine("Enter your word: ");
        }
        
        public string Enter_word()
        {
            string word = Console.ReadLine();
            return word;
        }

        public void Answer(bool answer)
        {
            Console.WriteLine(answer);
            Console.ReadKey();
        }

    }

    class Check
    {
        public bool Check_for_Double(string word)
        {
            bool answer = false;
            char letter_holder;
            int current_count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if(current_count + 1 == word.Length)
                {
                    break;
                }

                letter_holder = word[i + 1];

                if (word[i] == letter_holder)
                {
                    answer = true;
                    break;
                }
                else
                {
                    answer = false;
                }

                current_count++;
            }
            return answer;
        }
    }
}

