using NUnit.Framework;
using BookCross;

namespace BookCrossTest
{
    [TestFixture]
    public class PlaceTest
    {
        [Test]
        public void Add()
        {
            Place shelf = new Place();
            shelf.Add("СПбГМТУ корпус А", "СПбГМТУ корпус У");
            Assert.AreEqual(shelf.GetDeparture(), "СПбГМТУ корпус А");
            Assert.AreEqual(shelf.GetArrival(), "СПбГМТУ корпус У");
        }

        [Test]
        public void CompareSame()
        {
            Place shelf = new Place();
            shelf.Add("СПбГМТУ корпус А", "СПбГМТУ корпус У");
            Assert.IsTrue(shelf.Compare(shelf));
        }

        [Test]
        public void CompareNotArrival()
        {
            Place shelf = new Place();
            shelf.Add("СПбГМТУ корпус А", "СПбГМТУ корпус У");
            Place shelf1 = new Place();
            shelf1.Add("СПбГМТУ корпус А", "СПбГМТУ корпус Б");
            Assert.IsFalse(shelf.Compare(shelf1));
        }

        [Test]
        public void CompareNotDeparture()
        {
            Place shelf = new Place();
            shelf.Add("СПбГМТУ корпус А", "СПбГМТУ корпус У");
            Place shelf1 = new Place();
            shelf1.Add("СПбГМТУ корпус Б", "СПбГМТУ корпус У");
            Assert.IsFalse(shelf.Compare(shelf1));
        }

        [Test]
        public void CompareNotSame()
        {
            Place shelf = new Place();
            shelf.Add("СПбГМТУ корпус А", "СПбГМТУ корпус У");
            Place shelf1 = new Place();
            shelf1.Add("СПбГМТУ корпус Б", "СПбГМТУ корпус А");
            Assert.IsFalse(shelf.Compare(shelf1));
        }
    }
}
