using System;

namespace ClientServicePropertyExample
{
    public class Service2 : IService
    {
        public bool Called2 { get; set; }

        public void ServiceMethod()
        {
            Called2 = true;
            // Service Method implementation.
        }
    }
}
