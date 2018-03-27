using System;

namespace ClientServicePropertyExample
{
    public class Service1 : IService
    {
        public bool Called1 { get; set; }

        public void ServiceMethod()
        {
            Called1 = true;
            // Service Method implementation.
        }
    }
}
