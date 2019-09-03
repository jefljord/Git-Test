using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            Console.WriteLine("Guess a number!");
            guess = Convert.ToInt32(Console.ReadLine());

            var x = new Random().Next(0, 100);
            int count = 1;
            while (x != guess)
            {
                if (x > guess)
                {
                    Console.WriteLine("Too Low");
                }
                if (x < guess)
                {
                    Console.WriteLine("Too high");
                }
                if (x == guess)
                {
                    Console.WriteLine("That's correct!!");
                }
                guess = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            Console.WriteLine("It took " + count + " tries");
        }
    }
}
