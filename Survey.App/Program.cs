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
            Console.WriteLine("qoestion!");
            string[] rightAnswer = new string[] { "50", "Master of Sports", "Simpleo", "1964", "Tokyo","printer ", "Isaac Newton","programming", "exe", "Марк Цукерберг" };
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
            
            for (int i = 0; i < question.Length; i++)
            {
                Console.WriteLine(question[i]);
                
               a = Console.ReadLine();
                if (rightAnswer[i] == a) {
                    o++;
                    
                
                }
                
            }
            Console.WriteLine("percentage of correct answers");
            o = o * 100 / 10;
            Console.WriteLine(o);
           






        }




        
    }
}
