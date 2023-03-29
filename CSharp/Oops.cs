using System;

namespace CSharp
{
    //(1)C# Tutorial in Hindi and Urdu - Introduction to Classes in C#
    class Student
    {
        public string Name;
        public int Age;
        public int Marks;

        public void Details()
        {
            Console.WriteLine("Name = {0} Age = {1} Marks = {2}", Name, Age, Marks);
        }
    }

    //(2)C# Tutorial in Hindi and Urdu - Value vs Reference Types and Stack vs Heap in C#

    class Oops
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Name = "Gulshan"; ;
            s.Age = 27;
            s.Marks = 90;

            s.Details();

            Console.ReadLine();
        }
    }

    //3 - C# Tutorial in Hindi and Urdu - Value vs Reference Types and Stack vs Heap in C#


}
