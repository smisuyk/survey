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
            int a = 0;
            Console.WriteLine("qoestion!");
            string[] rightAnswer = new string[5] { "50", "Master of Sports", "Simpleo", "1964", "Tokyo" };
            string[] question = new string[5] { "How long did dinosaurs grow?", "How is kmc decoded?", "who is the top 1 of the world by cs go?", "what year did the porsche 911 appear?", "The capital of Japan?" };
            for (int i = 0; i < question.Length; i++)
            {
                Console.WriteLine(question[i]);
                Console.WriteLine();
                if (question[0] == rightAnswer[0])
                {
                    Console.WriteLine("You are right!", a++);
                    Console.WriteLine(question[1]);
                };
                Console.Read();

            }
        

            return;
            Console.WriteLine();
            if (question[0] == rightAnswer[0]) {
                Console.WriteLine("You are right!");
          
            }

            for (int i = 0; i < question.Length; i++)
            {
                Console.WriteLine(question[i]);
                
            }
            

        }




        
    }
}
