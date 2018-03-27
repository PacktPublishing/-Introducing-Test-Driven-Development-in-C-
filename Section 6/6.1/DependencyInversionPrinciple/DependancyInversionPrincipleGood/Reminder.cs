using System;

namespace DependencyInversionPrincipleGood
{
    public class Reminder : ICalendarItem
    {
        public DateTime StartTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void Start()
        {
            // Start Reminder logic.
        }
    }
}
