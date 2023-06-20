using ShowsLibrary;
using NUnit.Framework;

namespace ShowsLibrary.UnitTests
{
    [TestFixture]
    public class ShowsTests
    {
        static Show show;
        static Show show2;
        [SetUp]
        public void Setup()
        {
            show = new Show("Late Night", "talk-show", "Jimmy Fallon", Frequency.NonPeriodic, "23.05.2003 15:30");
            show2 = new Show("Ministry", "discussion", "Kate Jhonson", Frequency.Daily, "13.06.2023");
        }

        [Test]
        public void ConstructorTest()
        {
            Assert.That(show.Title, Is.EqualTo("Late Night"));
            Assert.That(show.Description, Is.EqualTo("talk-show"));
            Assert.That(show.Host, Is.EqualTo("Jimmy Fallon"));
            Assert.That(show.Frequency, Is.EqualTo(Frequency.NonPeriodic));
            Assert.That(show.Time.ToShortDateString()+" "+show.Time.ToShortTimeString(), Is.EqualTo("23.05.2003 15:30"));
        }

        [Test]
        public void GetInfo_Show_ValuesString()
        {
            string expectedInfo = "Not periodic ";
            expectedInfo += "Late Night ";
            expectedInfo += "talk-show. ";
            expectedInfo += "Ведущий Jimmy Fallon. ";
            expectedInfo += "Дата выхода: 23.05.2003 15:30.";

            Assert.That(show.GetInfo(), Is.EqualTo(expectedInfo));
        }

        [Test]
        public void ConstructorTest_2()
        {
            Assert.That(show2.Title, Is.EqualTo("Ministry"));
            Assert.That(show2.Description, Is.EqualTo("discussion"));
            Assert.That(show2.Host, Is.EqualTo("Kate Jhonson"));
            Assert.That(show2.Frequency, Is.EqualTo(Frequency.Daily));
            Assert.That(show2.Time.ToShortDateString(), Is.EqualTo("13.06.2023"));
        }

        [Test]
        public void GetInfo_Show_ValuesString_2()
        {
            string expectedInfo2 = "Daily ";
            expectedInfo2 += "Ministry ";
            expectedInfo2 += "discussion. ";
            expectedInfo2 += "Ведущий Kate Jhonson. ";
            expectedInfo2 += "Дата выхода: 13.06.2023.";

            Assert.That(show2.GetInfo(), Is.EqualTo(expectedInfo2));
        }
    }
}
