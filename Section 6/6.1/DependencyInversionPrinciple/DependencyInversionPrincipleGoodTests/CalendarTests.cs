using System.Collections.ObjectModel;
using DependencyInversionPrincipleGood;
using Xunit;
using Moq;

namespace DependencyInversionPrincipleGoodTests
{
    public class CalendarTests
    {
        [Fact]
        public void Start_OneItemInCollection_ItemMethodCalled()
        {
            var item = new Mock<ICalendarItem>();
            var collection = new Collection<ICalendarItem>();
            collection.Add(item.Object);

            var calendar = new Calendar(collection);
            calendar.Start();

            item.Verify(x => x.Start());
        }
    }
}
