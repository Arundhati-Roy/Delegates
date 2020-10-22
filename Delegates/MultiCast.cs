using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class MultiDel
    {
        delegate void DelOp(int x, int y);
        public static void ImpleDel()
        {
            DelOp obj = Operation.Add;
            obj += Operation.Square;
            obj(5, 5);
            obj(6, 3);
        }
        
        public class Operation
        {
            public static void Add(int a, int b)
            {
                Console.WriteLine("Addition" + (a + b));
            }
            public static void Square(int a, int b)
            {
                Console.WriteLine("Multiple" + (a * b));
            }

        }
    }
    
}
