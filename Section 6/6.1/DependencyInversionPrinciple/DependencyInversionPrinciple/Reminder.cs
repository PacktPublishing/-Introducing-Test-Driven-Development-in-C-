using System;

namespace DependencyInversionPrinciple
{
    public class Reminder
    {
        public DateTime StartTime { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public void StartReminder()
        {
            // Start Reminder logic.
        }
    }
}
