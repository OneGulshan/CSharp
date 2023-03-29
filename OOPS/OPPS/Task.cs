using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPS
{
    class CallTask
    {
        //public static async Task Main()
        //{
        //    await Task.Run(() => {
        //        // Just loop.
        //        int ctr = 0;
        //        for (ctr = 0; ctr <= 1000000; ctr++)
        //        { }
        //        Console.WriteLine("Finished {0} loop iterations",
        //                          ctr);
        //    });            
        //}
    }    
}

//Task Vs Thread differences in C#
//In computer science, a Task is a future or a promise.

//A Thread is a way of fulfilling that promise.
//You can use Task to specify what you want to do then attach that Task with a
//Thread. In .NET 4.0 terms, a Task represents an asynchronous operation.
//Thread(s) are used to complete that operation by breaking the work up into
//chunks and assigning to separate threads .


//Task And Thread In C#
//What is a Task?
//A task is something you want done. It is a set of program instructions that
//are loaded in memory . When program instruction is loaded into memory people
//do call as process or task. Task and Process are synonyms nowadays. A task
//will by default use the Threadpool, which saves resources as creating
//threads can be expensive. The Task can tell you if the work is completed and
//if the operation returns a result. Also, you can see a Task as a higher level
//abstraction upon threads.

//What is a Thread?
//A thread is a basic unit of CPU utilization , consisting of a program counter
//, a stack, and a set of registers. Thread has its own program area and memory
//area . A thread of execution is the smallest sequence of programmed
//instructions that can be managed independently by a scheduler. Threads are
//not a .NET construct, they are built into your operating system . The thread
//class from .NET is just a way to create and manage threads. Threads can
//themselves split into two or more simultaneously running tasks .

//------------------------------------------

//non-abstract class in c#?
//A non-abstract C# class defines the implementation of each member. In C#, it
//is possible to have a type that is intermediate between a pure interface that
//does not define any implementation, and a type that defines a complete implementation.

//What is a pure interface?
//A pure Abstract class has only abstract member functions and no data or
//concrete member functions. In general, a pure abstract class is used to
//define an interface and is intended to be inherited by concrete classes.
//concrete Class, meaning we can create objects of them.

//------------------------------------------

