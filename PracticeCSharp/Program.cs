using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            Console.WriteLine("--------------------------");

            Console.WriteLine("Work with Number");
            int num1 = 5;
            int num2 = 2;
            Console.WriteLine(num2 + num1);
            Console.WriteLine(num2 - num1);
            Console.WriteLine(num1 * num2);
            Console.WriteLine(num1 / num2);
            Console.WriteLine(num2 % num1);
            Console.WriteLine(Math.Min(num1, num2));
            Console.WriteLine(Math.Max(num1, num2));
            Console.WriteLine(Math.Pow(num1, num2));
            Console.WriteLine(Math.Sqrt(num1));

            Console.WriteLine("--------------------------");

            Console.WriteLine("Geting Input from the USer");
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hi " + userName);

            Console.Write("How old are you: ");
            string userAge = Console.ReadLine();
            Console.WriteLine("You are " + userAge + " years old.");

            Console.WriteLine("--------------------------");

            Console.WriteLine("BAsic Calculator");
            Console.Write("Enter firstNum: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter secondNum: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(firstNum + secondNum);



            Console.ReadLine();
        }
    }
}
