namespace DependencyInversionPrinciple
{
    public class Calendar
    {
        private readonly Event _event;
        private readonly Reminder _reminder;

        public Calendar()
        {
            _event = new Event();
            _reminder = new Reminder();
        }

        public void Start()
        {
            _event.StartEvent();
            _reminder.StartReminder();
        }
    }
}
