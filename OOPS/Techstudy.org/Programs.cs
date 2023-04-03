using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Techstudy.org
{
    public class Programs
    {
        //C# Language Basic programs with examples
        static void Main(string[] args)
        {
            //1.C# Program to Print “Hello, World!”
            Console.WriteLine("Hello, World!");
            //----------------------------------
            //2.C# Program to Add Two Integers.
            int num1, num2;
            //Console.WriteLine("Enter First Number..");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number..");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Addition result of two numbers is: {0}", num1 + num2);
            //----------------------------------
            //3.C# Program to Swap Values of Two Variables.
            int var1 = 12;
            int var2 = 13;
            var1 = var1 * var2;
            var2 = var1 / var2;
            var1 = var1 / var2;
            Console.WriteLine(var1);
            Console.WriteLine(var2);
            //----------------------------------
            //4.C# Program to Multiply two Floating Point Numbers
            //float float1, float2;
            //Console.WriteLine("Enter Your First Floating Number..");
            //float1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Your Second Floating Number..");
            //float2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Floating Point Numbers Additional Result is: {0}", float1 * float2);
            //----------------------------------
            //5.C# Program to perform all arithmetic operations
            //Console.WriteLine("Enter First Number");
            //num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Number");
            //num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a operator(+,-,/,*)");
            //string opr = Console.ReadLine();

            //switch (opr)
            //{
            //    case "+":
            //        Console.Write("Addition Result is: {0}", num1 + num2);
            //        break;
            //    case "-":
            //        Console.Write("Subtraction Result is: {0}", num1 - num2);
            //        break;
            //    case "/":
            //        Console.Write("Division Result is: {0}", num1 / num2);
            //        break;
            //    case "*":
            //        Console.Write("Multiplication Result is: {0}", num1 * num2);
            //        break;
            //    default:
            //        Console.Write("Wrong Input..");
            //        break;
            //}
            //Console.WriteLine();
            //----------------------------------
            //6.C# Program to convert feet to meter
            //double feet, meter;
            //Console.Write("Enter the length in feet: ");
            //feet =  double.Parse(Console.ReadLine());
            //meter = feet * 0.3048;
            //Console.WriteLine("Converted result from feet to meter is: {0}", meter);
            //----------------------------------
            //7.C# Program to convert celcius to farenheit
            //Console.Write("Enter the volume of celcius: ");
            //celcius = double.Parse(Console.ReadLine());
            //ferenheit = (celcius * 9/5) + 32;
            //Console.WriteLine("Converted result from celcius to farenheit is : {0}", ferenheit);
            //----------------------------------
            //8.C# Program to convert farenheit to celcius
            //Console.Write("Enter the volume of farenheit: ");
            //double ferenheit = double.Parse(Console.ReadLine());
            ////double celcius = (ferenheit - 32) / (9/5);//Not working this here
            //double celcius = (ferenheit - 32) / 1.8;
            //Console.WriteLine("Converted result from farenheit to celcius is : {0}", celcius);
            //----------------------------------
            //9.C# Program to find the Size of data types
            Console.WriteLine("Size of char: " + sizeof(char));//use c# sizeof method for knowing size of data types in bytes
            Console.WriteLine("Size of short: " + sizeof(short));
            Console.WriteLine("Size of bool: " + sizeof(bool));
            Console.WriteLine("Size of char: " + sizeof(double));
            Console.WriteLine("Size of char: " + sizeof(long));
            Console.WriteLine("Size of char: " + sizeof(float));
            Console.WriteLine("Size of char: " + sizeof(int));
            //----------------------------------
            //10.C# Program to Print ASCII Value
            int asciiValue;
            int i = 0;
            for (asciiValue = 33; asciiValue <= 127; asciiValue++)
            {
                if ((i % 5) == 0)
                {
                    Console.Write("\n");
                }
                Console.Write(" " + Convert.ToChar(asciiValue));
                i++;
            }
            Console.WriteLine();
            //----------------------------------
            ////11.C# Program to Calculate Area of Circle
            //Console.WriteLine("Enter radius of a Circle..");
            //double radius = double.Parse(Console.ReadLine());
            //double Area = 3.14159265359 * radius * radius;
            //Console.WriteLine("Area of Circle is: {0}", Area);

            //----------------------------------
            ////12.C# Program to Calculate Area of Square
            //Console.WriteLine("Enter Side of a Square..");
            //double side = double.Parse(Console.ReadLine());
            //double Area = side * side;
            //Console.WriteLine("Area of a Square is: " + Area);

            //----------------------------------
            ////13.C# Program to Calculate Area of Rectangle
            //Console.WriteLine("Enter Length of a Rectangle..");
            //double length = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Width of a Rectangle..");
            //double width = double.Parse(Console.ReadLine());
            //double Area = length * width;
            //Console.WriteLine("Area of a Rectangle is: " + Area);

            //----------------------------------
            ////14.C# Program to convert days to years, weeks and days
            //int days, years, weeks;
            //Console.WriteLine("Enter days:");
            //days = Convert.ToInt32(Console.ReadLine());

            //years = (days / 365);
            //weeks = (days % 365) / 7;
            //days = days - ((years * 365) + (weeks * 7));

            //Console.WriteLine("Years : " + years);
            //Console.WriteLine("weeks : " + weeks);
            //Console.WriteLine("Days : " + days);


            //List of all conditional programs in c# language
            ////1.C# Program to check whether an integer entered by the user is odd or even
            //Console.WriteLine("Enter a Number..");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Its an Even Number");
            //}
            //else{
            //    Console.WriteLine("Its an Odd Number");
            //}

            //----------------------------------
            //2.C# Program to find the largest number among three number.
            Console.WriteLine("Enter First Number..");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number..");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Third Number..");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    Console.WriteLine("The 1st Number is greatest among three");
                }
                else
                {
                    Console.WriteLine("The 3rd Number is greatest among three");
                }
            }
            else if (n2 > n3)//Jab  phele no. bada ni tha to sirf no. 3 se chk kara liye 1 and 2 dono no. bade nahi the to bydefault no. 3 hi greater hoga
                Console.WriteLine("The 2nd Number is greatest among three");
            else
                Console.WriteLine("The 3rd Number is greatest among three");
            //----------------------------------
            //3.C# Program to Find the Largest Number using Conditional Operator.

            Console.ReadKey();
        }
    }
}

//C# Practice Questions :- https://techstudy.org/csharp/csharp-programming-example-and-solutions
