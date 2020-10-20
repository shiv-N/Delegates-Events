using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    class MulticastDelegateExample
    {
        delegate void DelOp(int x, int y);
        
        public static void ImplementDelegate()
        {
            // Delegate instantiation  
            DelOp obj = Operation.Add;
            obj += Operation.Square;

            obj(5,5);
            obj(8,3);

            Console.ReadLine();
        }

        public class Operation
        {
            public static void Add(int a,int b)
            {
                Console.WriteLine("Addition={0}", a + b);
            }
            public static void Square(int a,int b)
            {
                Console.WriteLine("Multiple={0}", a * b);
            }
        }
    }
}
