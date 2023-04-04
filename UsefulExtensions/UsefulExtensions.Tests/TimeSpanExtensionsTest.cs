using PaoloCattaneo.UsefulExtensions;

namespace UsefulExtensions.Tests
{
    public class TimeSpanExtensionsTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FromHumanReadable()
        {
            var humanReadable = "4d 11h 30m 12s 431f";
            var timeSpan = TimespanExtensions.FromHumanReadable(humanReadable);
            var backToHuman = timeSpan.ToHumanReadable();

            Assert.Multiple(() =>
            {
                Assert.That(timeSpan.Days, Is.EqualTo(4));
                Assert.That(timeSpan.Hours, Is.EqualTo(11));
                Assert.That(timeSpan.Minutes, Is.EqualTo(30));
                Assert.That(timeSpan.Seconds, Is.EqualTo(12));
                Assert.That(timeSpan.Milliseconds, Is.EqualTo(431));
                Assert.That(backToHuman, Is.EqualTo(humanReadable));
            });
        }

        [Test]
        public void ToHumanReadable()
        {
            var timeSpan = new TimeSpan(6, 12, 43);
            var humanReadable = timeSpan.ToHumanReadable();
            var backToTimeSpan = TimespanExtensions.FromHumanReadable(humanReadable);
            
            Assert.Multiple(() =>
            {
                Assert.That(humanReadable, Is.EqualTo("6h 12m 43s"));
                Assert.That(backToTimeSpan, Is.EqualTo(timeSpan));
            });
        }

        [Test]
        public void ZeroToHumanReadable()
        {
            var zero = TimeSpan.Zero;
            var humanReadable = zero.ToHumanReadable();
            var backToTimeSpan = TimespanExtensions.FromHumanReadable(humanReadable);
            
            Assert.Multiple(() =>
            {
                Assert.That(humanReadable, Is.EqualTo("0f"));
                Assert.That(backToTimeSpan, Is.EqualTo(zero));
            });
        }
    }
}