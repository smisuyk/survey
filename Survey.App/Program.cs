using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var question1 = "How long did dinosaurs grow?";
            var rightAnswer1 = "50";
            var question2 = "How is kmc decoded?";
            var rightAnswer2 = "Master of Sports";
            var question3 = "who is the top 1 of the world by cs go?";
            var rightAnswer3 = "Simpleo";
            var question4 = "what year did the porsche 911 appear?";
            var rightAnswer4 = "1964";
            var question5 = "The capital of Japan?";
            var rightAnswer5 = "Tokyo";
            Console.WriteLine(question1);
            var answer1 = Console.ReadLine();

            Console.WriteLine("Results:");
            if (answer1 == rightAnswer1)
            {
                Console.WriteLine("You are right!");
            }
            else
            {
                Console.WriteLine("Opps! The correct answer is '50'");
            }
                Console.WriteLine(question2);
                var answer2 = Console.ReadLine();

                Console.WriteLine("Results:");
                if (answer2 == rightAnswer2)
                {
                    Console.WriteLine("You are right!");
                }
                else
                {
                    Console.WriteLine("Opps! The correct answer is 'Master of Sports'");
                }
            Console.WriteLine(question3);
            var answer3 = Console.ReadLine();

            Console.WriteLine("Results:");
            if (answer3 == rightAnswer3)
            {
                Console.WriteLine("You are right!");
            }
            else
            {
                Console.WriteLine("Opps! The correct answer is 'Simpleo'");
            }
            Console.WriteLine(question4);
            var answer4 = Console.ReadLine();
            Console.WriteLine("Result:");
            if (answer4 == rightAnswer4)
            {
                Console.WriteLine("You are right!");
            }
            else 
            {
                Console.WriteLine("Opps! The correct answer is '1964'");
            }
            Console.WriteLine(question5);
            var answer5 = Console.ReadLine();

            Console.WriteLine("Results:");
            if (answer5 == rightAnswer5)
            {
                Console.WriteLine("You are right!");
            }
            else
            {
                Console.WriteLine("Opps! The correct answer is 'Tokyo'");
            }

        }
    }
}
