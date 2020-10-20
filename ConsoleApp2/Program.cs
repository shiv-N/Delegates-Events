using DelegateExample;
using System;

namespace ConsoleApp2
{
    // Delegate Definition  
    public delegate int operation(int x, int y);

    class Program
    {
        // Method that is passes as an Argument  
        // It has same signature as Delegates   
        static int Addition(int a, int b)
        {
            return a + b;
        }


        /// <summary>
        /// Main method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Delegate instantiation  
            operation obj = new operation(Addition);

            // output  
            Console.WriteLine("Addition is={0}", obj(23, 27));
            Console.WriteLine();

            Console.WriteLine("*******************************Array of Delegates********************");

            ArrayDelegates.ImplementDelegate();

            Console.WriteLine("*******************************Anonymous Delegates********************");

            AnonymousDelegate.ImplementDelegate();

            Console.WriteLine("*******************************Anonymous Delegates********************");

            MulticastDelegateExample.ImplementDelegate();
        }
    }
}
