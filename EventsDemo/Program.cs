using System;

namespace EventsDemo
{
    public delegate void DelEvents();
    class Program
    {
        public static event DelEvents add;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to events demo!");
            //Events instantiation
            add += new DelEvents(India);
            add += new DelEvents(USA);
            add += new DelEvents(England);

            add.Invoke();
            Console.WriteLine("******");
            EventHandling.ImpleEvent();
        }
        public static void India()
        {
            Console.WriteLine("India");
        }
        public static void USA()
        {
            Console.WriteLine("USA");
        }
        public static void England()
        {
            Console.WriteLine("England");
        }
    }
}