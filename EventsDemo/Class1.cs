using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDemo
{
    public delegate void EventsHandler(string xyz);
    class EventHandling
    {
        public class Operation
        {
            public event EventsHandler xyz;
            public void Action(string a)
            {
                if(xyz!=null)
                {
                    xyz(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        private static void CatchEvent(string a)
        {
            Console.WriteLine("Method Calling");
        }
        public static void ImpleEvent()
        {
            Operation o = new Operation();
            o.Action("Event calling");
            Console.WriteLine();
            o.xyz += new EventsHandler(CatchEvent);
            o.Action("Events Caller");
        }
    }
}
