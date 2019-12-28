using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Survey.App
{
    class Program
    {
        private static IEnumerable<KeyValuePair<string, string>> dictionary;

        static void Main(string[] args)
        {
            string a;
            int o = 0;
            int i;
         
            Console.WriteLine("ВОПРОСЫ!");
            int[] alredyansswerquestio = new int[5];

            string[] question = File.ReadAllLines(@"..\..\question.txt");
            string [] rightAnswer = File.ReadAllLines(@"..\..\rightAnswer.txt");
         
            


            Random random = new Random(); 
            for (i = 0; i < 5; i++)
            {
                var randomindex = random.Next(0, 10);
                while (alredyansswerquestio.Contains(randomindex))
                { 
                    randomindex = random.Next(0, 10);
                }
                
                alredyansswerquestio[i] = randomindex;
                Console.WriteLine(question[randomindex]);
                a = Console.ReadLine();

                if (rightAnswer[randomindex] == a)
                {
                    o++;
                }
            }

            Dictionary<string, string> questions = new Dictionary<string, string>();
            for (i = 0; i < 5; i++)
            {
                questions.Add(question[i], rightAnswer[i]);


                foreach (KeyValuePair<string, string> valuePair in dictionary)
                {
                    Console.WriteLine(valuePair.Value);
                }

                Console.ReadKey();

                Console.WriteLine("количество правельных ответов ");
                Console.WriteLine(o);
            }
        }
    }
}