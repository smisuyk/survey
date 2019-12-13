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
            string a;
            int o = 0;
            int j=0;
            int i;
            Console.WriteLine("qoestion!");
             int[] alredyansswerquestio = new   int[5];
            string[] rightAnswer = new string[] { "50", "Master of Sports", "Simpleo", "1964", "Tokyo", "printer ", "Isaac Newton", "programming", "exe", "Марк Цукерберг" };

            string[] question = new string[] { "How long did dinosaurs grow?",
                "How is kmc decoded?",
                "who is the top 1 of the world by cs go?",
                "what year did the porsche 911 appear?",
                "The capital of Japan?",
                "Text printing device?",
                "Which physicist apple fell on Newton’s head?",
                "C #, java, c ++ are languages?",
                "Windows executable?",
                "who develope d facebook"};
            
            Random random = new Random();
            for (i = 0; i < question.Length; i++)
            {

                var randomindex= random.Next(0, 10);
                while (alredyansswerquestio.Contains(randomindex)) ;
                { randomindex = random.Next(0, 10); }
                alredyansswerquestio[i] = randomindex;
                Console.WriteLine(question[j]);

                a = Console.ReadLine();

                if (rightAnswer[j] == a)
                {
                    o++;


                }
            }
            Console.WriteLine("percentage of correct answers");
            o = o * 100 / 10;
            Console.WriteLine(o);
        }
    }
}
