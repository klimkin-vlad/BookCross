using NUnit.Framework;
using BookCross;

namespace BookCrossTest
{
    [TestFixture]
    public class PlacesTest
    {
        [Test]
        public void Add()
        {
            Places shelves = new Places();
            shelves.Add(1, "СПбГМТУ корпус А", "СПбГМТУ корпус У");
            Assert.AreEqual(shelves.GetDeparture(1), "СПбГМТУ корпус А");
            Assert.AreEqual(shelves.GetArrival(1), "СПбГМТУ корпус У");
        }

        [Test]
        public void CompareSame()
        {
            Places shelves = new Places();
            shelves.Add(1, "СПбГМТУ корпус А", "СПбГМТУ корпус У");
            shelves.Add(2, "СПбГМТУ корпус А", "СПбГМТУ корпус У");
            Assert.IsTrue(shelves.Compare(1, 2));
        }

        [Test]
        public void CompareNotArrival()
        {
            Places shelves = new Places();
            shelves.Add(1, "СПбГМТУ корпус А", "СПбГМТУ корпус У");
            shelves.Add(2, "СПбГМТУ корпус А", "СПбГМТУ корпус Б");
            Assert.IsFalse(shelves.Compare(1, 2));
        }

        [Test]
        public void CompareNotDeparture()
        {
            Places shelves = new Places();
            shelves.Add(1, "СПбГМТУ корпус А", "СПбГМТУ корпус У");
            shelves.Add(2, "СПбГМТУ корпус Б", "СПбГМТУ корпус У");
            Assert.IsFalse(shelves.Compare(1, 2));
        }

        [Test]
        public void CompareNotSame()
        {
            Places shelves = new Places();
            shelves.Add(1, "СПбГМТУ корпус А", "СПбГМТУ корпус У");
            shelves.Add(2, "СПбГМТУ корпус Б", "СПбГМТУ корпус А");
            Assert.IsFalse(shelves.Compare(1, 2));
        }
    }
}
