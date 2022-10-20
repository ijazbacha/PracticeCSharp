using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");

            Console.WriteLine("--------------------------");

            Console.WriteLine("Variable in C#");
            string name = "Jhon";
            int age = 20;
            Console.WriteLine("Your name is " + name);
            Console.WriteLine("And your age is " + age);

            Console.WriteLine("--------------------------");

            Console.WriteLine("Data Types");
            string text = "anything in this qoute!";
            char grade = 'a';
            int num = 0;
            float fNum = 1.1f;
            decimal dNum = 111.1m;
            double dbNum = 1.1;
            bool isVisable = true;

            Console.WriteLine("--------------------------");

            Console.WriteLine("Work with String");
            Console.WriteLine("Learn \"CSharp\"");
            string phrase = "Learn CSharp";
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.IndexOf('a'));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.Remove(1, 3));
            Console.WriteLine(phrase.Replace("Learn", "Start"));
            Console.WriteLine(phrase.Substring(2));
            Console.WriteLine(phrase.Substring(2, 6));

            Console.ReadLine();
        }
    }
}
