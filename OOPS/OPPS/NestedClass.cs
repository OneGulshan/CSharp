using System;

namespace OOPS
{
    public class NestedClass //Nested class call
    {
        public int Id { get; set; }
        public int EmpId { get; set; }

        public class Employee
        {
            public int Employees { get; set; }
        }
    }

    class CallSalesByMatch
    {
        //public static void Main(string[] args)
        //{
        //    NestedClass.Employee emp = new NestedClass.Employee();
        //    emp.Employees = 23;
        //    Console.WriteLine(emp.Employees);
        //    Console.ReadLine();
        //}
    }
}