using System;

namespace DIHelloWorld
{
    public class ConsoleWriter : IWritter
    {
        public void WriteHelloWorld()
        {
            Console.WriteLine("Hello World");
        }
    }
}
