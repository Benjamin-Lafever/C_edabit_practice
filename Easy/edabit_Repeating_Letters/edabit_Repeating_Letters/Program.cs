using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit_Repeating_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Object
            Add add = new Add();

            //Variables
            string word;
            string duplicated;

            word = add.Question();
            duplicated = add.Duplicate(word);
            Console.WriteLine(word + " with the duplicated effect = " + duplicated);
            Console.ReadKey();
        }
    }


    class Add
    {
        public string Question()
        {
            string word;

            Console.WriteLine("Please enter a word: ");
            word = Console.ReadLine();

            return word;
        }

        public string Duplicate(string word)
        { 
           string duplicated = null;

           for(int i = 0; i < word.Length; i++)
           {
               duplicated +=  word[i].ToString() + word[i].ToString();
           }

            return duplicated;
        }
    }
}
