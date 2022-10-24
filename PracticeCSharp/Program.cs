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

            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter secondNum: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(firstNum + secondNum);

            Console.WriteLine("--------------------------");

            Console.WriteLine("Array");
            int[] numbers = { 1, 2, 3, 4, 5, 6, };
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers[0]);
            numbers[1] = 200;
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers);

            string[] names = new string[5];
            names[0] = "abc";
            Console.WriteLine(names[0]);

            Console.WriteLine("--------------------------");

            Console.WriteLine("Calling Method");

            SayHi("peter", 20);

            Console.WriteLine("--------------------------");

            Console.WriteLine("Return Method");

            int cube = CubeNum(4);
            Console.WriteLine("the cube of 4 is: " + cube);

            Console.WriteLine("--------------------------");

            Console.WriteLine("IF STATEMENT");
            IfStatement();

            Console.WriteLine("--------------------------");

            Console.WriteLine("SWITCH STATEMENT");
            Console.WriteLine(GetDay(0));

            Console.WriteLine("--------------------------");

            Console.WriteLine("WHILE LOOP");

            int index = 0;
            while(index < 10)
            {
                Console.WriteLine("value of index " + index);
                index++;
            }

            Console.WriteLine("--------------------------");

            Console.WriteLine("DO WHILE LOOP");

            int doIndex = 10;
            do
            {
                Console.WriteLine("value of do index " + index);
                index++;
            } while (doIndex < 10);

            Console.ReadLine();
        }


        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hi Yor name is -> " + name + " and age is -> " + age);
        }

        static int CubeNum(int num)
        {
            return num * num * num;
        }

        static void IfStatement()
        {
            
            bool isMale = true;
            int isAge = 10;

            if (isMale && isAge >= 18)
            {
                Console.WriteLine("you are male and can be vote...");
            }
            else if(!isMale && isAge >= 18)
            {
                Console.WriteLine("you are female and can be vote...");
            }
            else
            {
                Console.WriteLine("you are under age and cant be vote");
            }
        }

         static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "A";
                        break;
                case 1:
                    dayName = "B";
                    break;
                case 3:
                    dayName = "C";
                    break;
                case 4:
                    dayName = "D";
                    break;
                case 5:
                    dayName = "E";
                    break;
                case 6:
                    dayName = "F";
                    break;
                default:
                    dayName = "Invaild Day Number";
                    break;
            }
            return dayName; 
        }
    }
}
