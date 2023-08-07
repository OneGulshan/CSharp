using System;
using static CSharp.Program;

namespace CSharp
{
    static class MyStaticClass
    {
        public static void Func2(this ExtensionClass ec)//This is an extension method no need to provide value to this parameter//this extension method parameter is called binding parameters thats belongs to ExtensionClass specified here
        {
            Console.WriteLine("This is third method..");
        }

        public static void Func3(this ExtensionClass ec, int a)//int a <- this is an normal parameter not ignored on calling time
        {
            Console.WriteLine("This is third method.. " + a);
        }

        public static bool IsGreaterThan(this int i, int value)
        {
            return i > value;
        }
    }
}
