using NUnit.Framework;
using BookCross;
using System.Collections.Generic;

namespace BookCrossTest
{
    [TestFixture]
    public class PlacesTest
    {
        [Test]
        public void Add()
        {
            Places shelves = new Places();
            shelves.Add("СПбГМТУ корпус А", "СПбГМТУ корпус У");
            List<string> placeData = shelves.GetAll(1);
            Assert.AreEqual(placeData[0], "1");
            Assert.AreEqual(placeData[1], "СПбГМТУ корпус А");
            Assert.AreEqual(placeData[2], "СПбГМТУ корпус У");
        }

        [Test]
        public void CompareSame()
        {
            Places shelves = new Places();
            shelves.Add("СПбГМТУ корпус А", "СПбГМТУ корпус У");
            shelves.Add("СПбГМТУ корпус А", "СПбГМТУ корпус У");
            Assert.IsTrue(shelves.Compare(1, 2));
        }

        [Test]
        public void CompareNotArrival()
        {
            Places shelves = new Places();
            shelves.Add("СПбГМТУ корпус А", "СПбГМТУ корпус У");
            shelves.Add("СПбГМТУ корпус А", "СПбГМТУ корпус Б");
            Assert.IsFalse(shelves.Compare(1, 2));
        }

        [Test]
        public void CompareNotDeparture()
        {
            Places shelves = new Places();
            shelves.Add("СПбГМТУ корпус А", "СПбГМТУ корпус У");
            shelves.Add("СПбГМТУ корпус Б", "СПбГМТУ корпус У");
            Assert.IsFalse(shelves.Compare(1, 2));
        }

        [Test]
        public void CompareNotSame()
        {
            Places shelves = new Places();
            shelves.Add("СПбГМТУ корпус А", "СПбГМТУ корпус У");
            shelves.Add("СПбГМТУ корпус Б", "СПбГМТУ корпус А");
            Assert.IsFalse(shelves.Compare(1, 2));
        }
    }
}
