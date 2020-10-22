using System;

namespace Delegates
{
    public delegate int operation(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to delegate demo!");
            //Delegate instantiation
            operation obj = new operation(Addition);

            Console.WriteLine("Sum is: " + obj(23, 67));
            Console.WriteLine();
            MultiDel.ImpleDel();
        }
        static int Addition(int a, int b)
        {
            return a + b;
        }
        
    }
   
}
