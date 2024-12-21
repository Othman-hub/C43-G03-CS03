using System.ComponentModel;
using System.Diagnostics;

namespace Assignment_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Write a program that allows the user to enter a number then print it.
            double num;
            do
            {
                Console.Write("please enter a number: ");
            } while (!double.TryParse(Console.ReadLine(), out num));
            Console.WriteLine(num);
            #endregion

            #region 2.Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //int x = int.Parse("Hello");
            ////runtime error

            #endregion
            #region  3.Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happe
            Console.WriteLine(2.22 + 3.133);
            #endregion
            #region 4.Write C# program that Extract a substring from a given string.
            string str = "hello";
            string substr = str.Substring(2);
            Console.WriteLine(substr);
            #endregion
            #region 5.Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            int x = 3;
            int y = x;
            x = 5;
            //x => 5
            //y => 3
            #endregion

            #region 6.Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            ////////////They will have the same value
            #endregion
            #region 7.Write C# program that take two string variables and print them as one variable 
            string str1 = "Hello ";
            string str2 = "World :)";
            string SumStr = str1 + str2;
            Console.WriteLine(SumStr);
            #endregion

            #region 8.Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100

            int principal = 200;
            int rate = 44;
            int time = 12;
            Console.WriteLine($"Interest = ({principal} * {rate} * {time}) / 100 = {(principal * rate * time) / 100}");
            #endregion
            #region 9.Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)
            double weight = 80.5;
            double height = 1.75;
            Console.WriteLine($"BMI = {weight} / ({height} * {height}) = {weight / (height * height)}");
            #endregion

            #region 10.Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".
            int temp = 25;
            string result = temp < 10 ? "Just Cold" : temp > 30 ? "Just Hot" : "Just Good";
            Console.WriteLine(result);
            #endregion
            #region 11.Write a program that takes the date from the user and displays it in various formats using string interpolation

            #endregion
            #region 12- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no
            int nom;
            do
            {
                Console.Write("Please Enter a Numper: ");
            } while (!int.TryParse(Console.ReadLine(), out nom));

            Console.WriteLine(nom % 3 == 0 && nom % 4 == 0 ? "Yes" : "No");
            #endregion

            #region 13- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive
            int num1;
            do
            {
                Console.Write("Please Enteer a Numbeer: ");
            } while (!int.TryParse(Console.ReadLine(), out num1) || num1 == 0);
            Console.WriteLine(num1 > 0 ? "positive" : "negative");
            #endregion

            #region 14- Write a program that takes 3 integers from the user then prints the max element and the min element
            int nom1, num2, num3;
            bool flag1, flag2, flag3;
            do
            {
                Console.Write("enter a number 1: ");
                flag1 = int.TryParse(Console.ReadLine(), out nom1);
                Console.Write("enter a number 2: ");
                flag2 = int.TryParse(Console.ReadLine(), out num2);
                Console.Write("enter a number 3: ");
                flag3 = int.TryParse(Console.ReadLine(), out num3);

            } while (!(flag1 && flag2 && flag3));
            int max, min;
            if (nom1 > num2 && nom1 > num3)
                max = nom1;
            else if (num2 > num3)
                max = num2;
            else
                max = num3;

            if (nom1 < num2 && nom1 < num3)
                min = nom1;
            else if (num2 < num3)
                min = num2;
            else
                min = num3;
            Console.WriteLine($"Max element = {max}");
            Console.WriteLine($"Min element = {min}");

            #endregion


            #region 15- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            char c;
            do
            {
                Console.Write("enter character: ");
            } while (!char.TryParse(Console.ReadLine(), out c));

            if (c == 'a' || c == 'e' || c == 'l' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'L' || c == 'O' || c == 'U')
                Console.WriteLine("vowel");
            else
                Console.WriteLine("Consonant");
            #endregion

            #region 16- Write a program to enter the month number and print the number of days in that month
            int month;
            do
            {
                Console.Write("Enter the month number: ");
            } while (!int.TryParse(Console.ReadLine(), out month) || month > 12 || month < 1);

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Days in Month: 31");
                    break;
                case 2:
                    Console.WriteLine("Days in Month: 28 or 29");
                    break;
                default:
                    Console.WriteLine("Days in Month: 30");
                    break;
            }
            #endregion



            #region 17- Write a program to create a Simple Calculator.
            int n1, n2;
            char oper;
            bool f1, f2, f3;
            do
            {
                Console.Write("Enter the first number: ");
                f1 = int.TryParse(Console.ReadLine(), out n1);
                Console.Write("Enter the operation: ");
                f3 = char.TryParse(Console.ReadLine(), out oper);
                Console.Write("Enter the second number: ");
                f2 = int.TryParse(Console.ReadLine(), out n2);

            } while (!(f1 && f2 && f3) || (oper != '-' && oper != '+' && oper != '*' && oper != '/' && oper != '%'));
            switch (oper)
            {

                case '-':
                    Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                    break;
                case '+':
                    Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                    break;
                case '*':
                    Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
                    break;
                case '/':
                    Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
                    break;
                case '%':
                    Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                    break;
            }
            #endregion

            #region 18.Write a program that allows the user to insert an integer then print all numbers between 1 to that number
            int nu;
            do
            {
                Console.Write("Enter a number: ");
            } while (!int.TryParse(Console.ReadLine(), out nu) || nu < 0);
            for (int i = 1; i <= nu; i++)
            {
                if (i == nu)
                    Console.WriteLine(i);
                else
                    Console.Write(i + ", ");

            }
            #endregion


            #region 19- Write a program that allows the user to insert an integer then print a multiplication table up to 12

            int num19;
            do
            {
                Console.Write("Enter a number: ");
            } while (!int.TryParse(Console.ReadLine(), out num19));
            for (int i = 1; i <= 12; i++)
            {
                switch (i)
                {
                    case 12:
                        Console.WriteLine(i * num19);
                        break;
                    default:
                        Console.Write(i * num19 + " ");
                        break;
                }
            }

            #endregion


            #region 20- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            int num20;
            do
            {
                Console.Write("Enter a number: ");
            } while (!int.TryParse(Console.ReadLine(), out num20));
            for (int i = 1; i <= num20; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine();

            #endregion


            #region 21- Write a program that takes two integers then prints the power.
            int numb1, numb2, result21;
            bool fl1, fl2;
            do
            {
                Console.Write("enter a number: ");
                fl1 = int.TryParse(Console.ReadLine(), out numb1);
                Console.Write("enter a power: ");
                fl2 = int.TryParse(Console.ReadLine(), out numb2);
            } while (!(fl1 && fl2));
            result21 = numb1;
            for (int i = 1; i < numb2; i++)
            {
                result21 *= numb1;
            }
            Console.WriteLine($"{numb1}^{numb2} = {result21}");
            #endregion

            #region 22- Write a program to allow the user to enter int and print the REVERSED of it.

            int num22;
            do
            {
                Console.Write("Enter a number: ");
            } while (!int.TryParse(Console.ReadLine(), out num22));

            Console.WriteLine(num22 * -1);

            #endregion

            #region 23- Write a program in C# Sharp to find prime numbers within a range of numbers

            #endregion


            #region 24- . Write a program in C# Sharp to convert a decimal number into binary without using an array

            #endregion


            #region 25- Write a program in C# Sharp to find the sum of all elements of the array.
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int SumArr = 0;
            for (int i = 0; i < arr.Length; i++)
                SumArr += arr[i];

            Console.WriteLine(SumArr);
            #endregion



        }
    }   
}
