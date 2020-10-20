using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateExample
{
    class AnonymousDelegate
    {
        // Delegate Definition  
        delegate void operation();

        public static void ImplementDelegate()
        {
            // Delegate instantiation  
            operation obj = delegate
            {
                Console.WriteLine("Anonymous method");
            };
            obj();
            Console.WriteLine();
        }
    }
}
