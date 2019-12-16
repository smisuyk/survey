using System;
using System.Collections.Generic;
using System.IO;
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
            int i;
            Console.WriteLine("question!");
            int[] alredyansswerquestio = new int[5];

            var question = File.ReadAllLines(@"‪D:\dev\survey\survey\Survey.App\question.txt");
            var rightAnswer = File.ReadAllLines(@"‪D:\dev\survey\survey\Survey.App\rightAnswer.txt");
    
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
            Console.WriteLine("количество правельных ответов ");
            Console.WriteLine(o);
        }
    }
}
