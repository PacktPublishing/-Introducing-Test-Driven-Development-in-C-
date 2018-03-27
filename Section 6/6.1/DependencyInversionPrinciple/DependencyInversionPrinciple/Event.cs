using System;

namespace DependencyInversionPrinciple
{
    public class Event
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void StartEvent()
        {
            // Start Event logic.
        }
    }
}
