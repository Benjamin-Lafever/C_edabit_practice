using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edabit_Dull_Museum
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversation convo = new Conversation();
            Calculations cal = new Calculations();

            List<int> user_ratings = new List<int>();

            convo.Introduction();
            user_ratings = convo.User_Ratings();
            user_ratings = cal.Loop_And_Remove(user_ratings);
            cal.Print(user_ratings);
            Console.ReadKey();
        }
    }

    class Conversation
    {
        public void Introduction()
        {
            Console.WriteLine("please enter your ratings for the following exibits, the lowest rated one will be removed");
        }

        public List<int> User_Ratings()
        {
            List<int> user_ratings = new List<int>();

            Console.WriteLine("This exibit shows a half eaten potato chip, what is your rating?: ");
            user_ratings.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("This exibit shows a smoking samsung galaxy, what is your rating?: ");
            user_ratings.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("This exibit shows a pebble, what is your rating?: ");
            user_ratings.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("This exibit is a printed peice of paper with 'This side up' printed on it, what is your rating?: ");
            user_ratings.Add(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("This exibit shows a sweater with a few holes in it, what is your rating?: ");
            user_ratings.Add(Convert.ToInt32(Console.ReadLine()));

            return user_ratings;
        }
    }

    class Calculations
    {
        public List<int> Loop_And_Remove(List<int> user_ratings) {

            user_ratings.Remove(user_ratings.Min());

            return user_ratings;
        }

        public void Print(List<int> user_ratings)
        { 
                Console.WriteLine(String.Join(" , ", user_ratings));  
        }
    }
}
