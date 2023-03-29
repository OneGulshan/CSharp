using HackerRank;
using System;
using System.Globalization;
using System.Linq;

namespace OOPS
{
    public class Programe
    {
        static void Main(string[] args)
        {
            ////(1)Find even or odd number in C# |C# Basics for Beginners in Hindi
            //Console.WriteLine("Find even or odd number in C#...");
            //Console.WriteLine("Enter a Number..");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine(num + " is a even number..");
            //}
            //else
            //{
            //    Console.WriteLine(num + " is a odd number..");
            //}

            ////Print all even numbers between 0 to 100
            //for (int i = 0; i <= 100; i++)//Even Number
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.Write(i);
            //        if (i != 99)
            //            Console.Write(",");
            //    }
            //}

            //Console.WriteLine();

            //for (int i = 0; i <= 100; i++)//Odd Number
            //{
            //    if (i % 2 == 1)
            //    {
            //        continue;
            //    }
            //    Console.Write(i);
            //    if (i != 100)
            //        Console.Write(",");
            //}

            ////(2)Find Largest Number Between Two or Three Numbers in C# |C# Basics for Beginners in Hindi
            //Console.WriteLine("Enter First Number..");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number..");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Third Number..");
            //int c = Convert.ToInt32(Console.ReadLine());

            ////if (a > b)
            ////{
            ////    Console.WriteLine("First number is greater..");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Second number is greater..");
            ////}

            ////if (a > b && a > c)
            ////{
            ////    Console.WriteLine("First number is greater..");
            ////}
            ////else if (b > a && b > c)
            ////{
            ////    Console.WriteLine("Second number is greater..");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Third number is greater..");
            ////}

            //if (a > b)//Finding Greatest number between three numbers using nested if statement
            //{
            //    if (a > c)
            //    {
            //        Console.WriteLine("First number is greater..");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Third number is greater..");
            //    }                
            //}
            //else
            //{
            //    if (b > c)
            //    {
            //        Console.WriteLine("Second number is greater..");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Third number is greater..");
            //    }
            //}

            ////(3)How to Swap Two Numbers in C# |C# Basics for Beginners in Hindi
            ////two variables values interchanging process is called swapping
            //Console.WriteLine("Enter your first number..");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter your second number..");
            //int b = Convert.ToInt32(Console.ReadLine());
            ////a = a + b;
            ////b = a - b;
            ////a = a - b;
            //a = a * b;
            //b = a / b;
            //a = a / b;
            //Console.WriteLine("Variable a value is " + a);
            //Console.WriteLine("Variable b value is " + b);

            ////(4)Fibonacci Series in C# |C# Basics for Beginners in Hindi
            //int a = 0;
            //int b = 1;
            //int c;

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //for (int i = 0; i < 10; i++)
            //{
            //    c = a + b;//Helping by swapping here c value is always 2nd last and last only
            //    Console.WriteLine(c);
            //    a = b;//Here every printing time our 2nd last value and last value changed, for solving this and performing Fibonacci Series printing here, we used swapping here
            //    b = c;
            //}

            ////(5)Factorial of a Number in C# |C# Basics for Beginners in Hindi
            ////Factorial of given number is multiplication of all the integers from 1 to given number. For Example: Find the Factorial of Number = 4. 24 = 4*3*2*1
            //Console.WriteLine("Enter a Number for printing factorial..");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int fact = 1;

            //for (int i = 1; i <= num; i++)
            //{
            //    fact = fact * i;
            //}
            //Console.WriteLine(fact);

            ////(6)Reverse of a Number & Reverse of a string using for loop in C#
            ////Console.WriteLine("Enter a Number for reverse..");
            ////int num = Convert.ToInt32(Console.ReadLine());
            ////int result = 0;
            ////int rem;

            ////while (num != 0)
            ////{
            ////    rem = num % 10;
            ////    result = result*10 + rem;
            ////    num = num / 10;
            ////}
            ////Console.WriteLine(result);

            ////--------------------------------------------------------------------

            //string str = "", reverse = "";
            //int Length = 0;

            //Console.WriteLine("Enter a Word");
            //str = Console.ReadLine();
            //Length = str.Length - 1;
            //while (Length >= 0)
            //{
            //    reverse = reverse + str[Length];
            //    Length--;
            //}
            //Console.WriteLine("Reverse word is {0}", reverse);

            ////(7)Palindrome Number in C# [Hindi] & Palindrome String Program In C# also
            ////A palindromic number is a number that remains the same when its digits are reversed. For Example: 121 is palidrome number. Reverse of 16461=16461
            ////Console.WriteLine("Enter a number for reverse number result cheacking..");
            ////int num = Convert.ToInt32(Console.ReadLine());//121
            ////int rem;
            ////int result = 0;
            ////int temp = num;

            ////while (num != 0)//Here our num value always 0 after loop throw for resolving this issue, we recollect our num value here using temp variable
            ////{
            ////    rem = num % 10;
            ////    result = result * 10 + rem;
            ////    num = num / 10;
            ////}

            ////num = temp;

            ////if (num == result)
            ////{
            ////    Console.WriteLine("It's a Palindrome number");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("It's not a Palindrome number");
            ////}

            ////--------------------------------------------------------------------

            //string str = "";
            //Console.WriteLine("Enter A String");
            //str = Console.ReadLine();

            ////char[] chaar = str.ToCharArray();
            ////System.Array.Reverse(chaar);
            ////string str_reverse = new string(chaar);
            //var str_reverse = new string(str.ToCharArray().Reverse().ToArray());

            //if (str.ToLower().Equals(str_reverse.ToLower()))
            //{
            //    Console.WriteLine(str + " -> Its A Palindrome String..");
            //}
            //else
            //{
            //    Console.WriteLine(str + " -> Its Not A Palindrome String..");
            //}

            ////(8)Armstrong Number in C# [Hindi]
            ////A Armstrong number is a number that is equal to the sum of cubes of its digits.
            ////For example:- 153 is Armstrong Number <- 1 cube + 5 cube + 3 cube, 1*1*1+5*5*5+3*3*3, 1+125+27=153

            //int num = 153;
            //int rem;
            //int cube;
            //int result = 0;
            //int temp = num;


            //while (num != 0)
            //{
            //    rem = num % 10;
            //    cube = rem * rem * rem;
            //    result = result + cube;
            //    num = num / 10;
            //}

            //num = temp;

            //if (num == result)
            //{
            //    Console.WriteLine("Armstrong Number");
            //}
            //else
            //{
            //    Console.WriteLine("Not An Armstrong Number");
            //}

            ////(9)Calculator Using Switch case in c# [Hindi]
            //string value;
            //do
            //{
            //    int res;
            //    Console.Write("Enter First Number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter Second Number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter Symbol(/,*,+,-): ");
            //    string symbol = Console.ReadLine();
            //    Console.WriteLine();

            //    switch (symbol)
            //    {
            //        case "/":
            //            res = num1 / num2;
            //            Console.WriteLine("Division result is: " + res);
            //            break;
            //        case "*":
            //            res = num1 * num2;
            //            Console.WriteLine("Multiplication result is: " + res);
            //            break;
            //        case "+":
            //            res = num1 + num2;
            //            Console.WriteLine("Addition result is: " + res);
            //            break;
            //        case "-":
            //            res = num1 - num2;
            //            Console.WriteLine("Subtraction result is: {0} ", res);
            //            break;
            //        default:
            //            Console.WriteLine("Wrong Input");
            //            break;
            //    }
            //    Console.ReadLine();
            //    Console.WriteLine("Do You Want To Continue(Press y For yes and n For No)..");
            //    value = Console.ReadLine().ToLower();
            //}
            //while (value=="y");

            ////(10)Prime Number in C# [Hindi] & Find Prime Numbers between 1 to 100
            ////Note:- Prime number is the number that is only divisible by one and itself.
            ////string value;
            ////do
            ////{
            ////    Console.WriteLine("Enter a Number..");
            ////    int num = Convert.ToInt32(Console.ReadLine());
            ////    int count = 0;

            ////    for (int i = 1; i <= num; i++)
            ////    {
            ////        if (num % i == 0)
            ////        {
            ////            count++;
            ////        }
            ////    }

            ////    if (count == 2)
            ////    {
            ////        Console.WriteLine("Prime Number..");
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("Not a Prime Number..");
            ////    }
            ////    Console.ReadLine();
            ////    Console.WriteLine("Do You Want To Continue(Press y For yes and n For No)..");
            ////    value = Console.ReadLine().ToLower();
            ////}
            ////while (value == "y");

            ////--------------------------------------------------------------------

            //for (int number = 1; number <= 100; number++)
            //{
            //    int count = 0;
            //    for (int i = 1; i <= number; i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    if (count == 2)
            //    {
            //        Console.Write(number);
            //        if (number != 97)
            //            Console.Write(",");
            //    }
            //}

            ////(11)#1 Star Pattern Program in C#[Hindi]
            ////Star pattern is used for loop concept, almost changes only in inner for loop only in all for loops
            //for (int i = 1; i <= 5; i++)//for defining row numbers
            //{
            //    for (int j = 1; j <= 5; j++)//for star printing
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= 5; i++)//This code is good excepting by bottom one
            //{
            //    for (int j = i; j <= 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            ////Console.WriteLine();

            ////for (int i = 1; i <= 5; i++)//This is mine code
            ////{
            ////    for (int j = 5; j >= i; j--)
            ////    {
            ////        Console.Write("*");
            ////    }
            ////    Console.WriteLine();
            ////}

            //Console.WriteLine();

            ////for (int i = 1; i <= 5; i++)//This is mine code
            ////{
            ////    for (int j = 1; j <= i; j++)
            ////    {
            ////        Console.Write("*");
            ////        if (j == 5)
            ////        {
            ////            Console.WriteLine();
            ////            for (int k = 1; k <= 4; k++)
            ////            {
            ////                for (int l = 4; l >= k; l--)
            ////                {
            ////                    Console.Write("*");
            ////                }
            ////                Console.WriteLine();
            ////            }
            ////        }
            ////    }
            ////    Console.WriteLine();
            ////}

            //for (int i = 1; i <= 5; i++)//This is Origional pattern code of video
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 4; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            ////(12)#2 Number Pattern Program in C#[Hindi]
            ////Number pattern also used same concept of for loop
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //int count = 0;
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        count++;
            //        Console.Write(count);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //int count = 0;
            //for (int i = 1; i <= 4; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        count++;
            //        Console.Write(count);
            //    }
            //    Console.WriteLine();
            //}

            //(13)#3 Star Pattern Program in C#[Hindi]

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            ////for (int i = 5; i >= 1; i--)//This is my code
            ////{
            ////    for (int j = i; j <= 4; j++)
            ////    {
            ////        Console.Write(" ");
            ////    }
            ////    for (int k = i; k >= 1; k--)
            ////    {
            ////        Console.Write("*");
            ////    }
            ////    Console.WriteLine();
            ////}

            //Console.WriteLine();

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 2; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = i; k <= 5; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 2; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = i; k <= 5; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 2; i <= 5; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 2; i <= 5; i++)
            //{
            //    for (int j = 2; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = i; k <= 5; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //(14)#4 Pyramid Patterns Program in C#[Hindi]

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int l = 2; l <= i; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 2; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = i; k <= 5; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int l = i; l <= 4; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            //for (int i = 1; i <= 5; i++)//This is also print a Pyramid
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }                
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)//This is also print a Pyramid
            //{
            //    for (int j = 2; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 2*i-1; k <= 9; k++)
            //    {
            //        Console.Write("*");
            //    }                
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)//Dimond Pyramid
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 2; i <= 5; i++)
            //{
            //    for (int j = 2; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 2 * i - 1; k <= 9; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)//Damro Pyramid
            //{
            //    for (int j = 2; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 2 * i - 1; k <= 9; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 2; i <= 5; i++)
            //{
            //    for (int j = i; j <= 4; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            Console.ReadLine();
        }
    }
}
