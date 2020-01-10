using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Survey.App
{
    class Program
    {
        public static Dictionary<string, string> Dictionary { get; set; } = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            Dictionary<string, string> questionDictionary = new Dictionary<string, string>();
            Dictionary<string, string> surveyDictionary = new Dictionary<string, string>();

            

            string[] questions = File.ReadAllLines(@"..\..\question.txt");

            // пробежаться по словарю и заполнить его значениями из файла
            // Fill questionDictionary
            foreach(var question in questions)
            {
                var questionAndAnswer = question.Split(new string[] { "#-#" }, StringSplitOptions.RemoveEmptyEntries);
                var key = questionAndAnswer[0];
                var value = questionAndAnswer[1];
                Dictionary.Add(key, value);
            }

            // random.Next(0, 5)
            // Dictionary.Skip(random).Take(5);

            // выбрать 5 рандомных вопросов в словаре
            // Fill surveyDictionary with 5 questions from questionDictionary (set only Key)
            
            Random random = new Random();
            Console.WriteLine("survey");
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine("{0} -> {1}", i, random.Next(5));

            }




            // пробежаться по 5 вопросам и задать их пользователю
            // Fill surveyDictionary Values from the user

                // сравнить ответы пользователя с правильными ответами и вывести результат теста



        }
    }
}