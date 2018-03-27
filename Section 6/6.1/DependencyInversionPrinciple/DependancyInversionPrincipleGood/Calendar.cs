using System.Collections.Generic;

namespace DependencyInversionPrincipleGood
{
    public class Calendar
    {
        private readonly ICollection<ICalendarItem> _items;

        public Calendar(ICollection<ICalendarItem> items)
        {
            _items = items;
        }

        public void Start()
        {
            foreach (var item in _items)
            {
                item.Start();
            }
        }
    }
}
