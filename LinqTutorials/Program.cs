using System;
using System.Linq;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("E 1");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task1()));

            System.Console.WriteLine("E 2");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task2()));

            System.Console.WriteLine("E 3");
            System.Console.WriteLine(LinqTasks.Task3());
            
            System.Console.WriteLine("E 4");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task4()));

            System.Console.WriteLine("E 5");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task5()));
            
            System.Console.WriteLine("E 6");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task6()));
            
            System.Console.WriteLine("E 7");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task7()));
            
            System.Console.WriteLine("E 8");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task8()));
            
            System.Console.WriteLine("E 9");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task9()));
            
            System.Console.WriteLine("E 10");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task10()));
            
            System.Console.WriteLine("E 11");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task11()));
            
            System.Console.WriteLine("E 13");
            int[] ints = [1,1,1,1,1,1,10,1,1,1,1];
            System.Console.WriteLine(LinqTasks.Task13(ints));
            
            System.Console.WriteLine("E 14");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task14()));
                        
            System.Console.WriteLine("E 15");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task15()));
            
            System.Console.WriteLine("E 16");
            System.Console.WriteLine(String.Join(", ", LinqTasks.Task16()));
        }
    }
}
