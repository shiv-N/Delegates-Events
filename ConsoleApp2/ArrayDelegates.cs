using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    public class Operation  
    {  
        public static void Add(int a, int b)  
        {  
            Console.WriteLine("Addition={0}",a + b);  
        }  
  
        public static void Multiple(int a, int b)  
        {  
            Console.WriteLine("Multiply={0}", a * b);  
        }  
    }
    
    class ArrayDelegates
    {
        delegate void DelOp(int x, int y);

        public static void ImplementDelegate()
        {
            // Delegate instantiation  
            DelOp[] obj =
           {
               new DelOp(Operation.Add),
               new DelOp(Operation.Multiple)
           };

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 5);
                obj[i](8, 5);
                obj[i](4, 6);

                Console.WriteLine();
            }
        }
    }
}
