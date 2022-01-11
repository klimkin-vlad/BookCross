﻿using NUnit.Framework;
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
            shelf.Add(1, "СПбГМТУ корпус А", "СПбГМТУ корпус У");
            Assert.AreEqual(shelf.GetDeparture(), "СПбГМТУ корпус А");
            Assert.AreEqual(shelf.GetArrival(), "СПбГМТУ корпус У");
        }

        [Test]
        public void CompareSame()
        {
            Place shelf = new Place();
            shelf.Add(1, "СПбГМТУ корпус А", "СПбГМТУ корпус У");
            Assert.IsTrue(shelf.Compare(1));
        }

        [Test]
        public void CompareNotSame()
        {
            Place shelf = new Place();
            shelf.Add(1, "СПбГМТУ корпус А", "СПбГМТУ корпус У");
            Place shelf1 = new Place();
            shelf1.Add(2, "СПбГМТУ корпус А", "СПбГМТУ корпус Б");
            Assert.IsFalse(shelf.Compare(2));
        }
    }
}