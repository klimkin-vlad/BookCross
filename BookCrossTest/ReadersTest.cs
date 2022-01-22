using NUnit.Framework;
using BookCross;
using System.Collections.Generic;

namespace BookCrossTest
{
    [TestFixture]
    public class ReadersTest
    {
        [Test]
        public void Add()
        {
            Readers persons = new Readers();
            persons.Add("Климкин Владислав Юрьевич");
            List<string> readerData = persons.GetAll(1);
            Assert.AreEqual(readerData[0], "1");
            Assert.AreEqual(readerData[1], "Климкин Владислав Юрьевич");
        }

        [Test]
        public void CompareSame()
        {
            Readers persons = new Readers();
            persons.Add("Климкин Владислав Юрьевич");
            persons.Add("Климкин Владислав Юрьевич");
            Assert.IsTrue(persons.Compare(1, 2));
        }

        [Test]
        public void CompareNotSame()
        {
            Readers persons = new Readers();
            persons.Add("Климкин Владислав Юрьевич");
            persons.Add("Климкин Влад Юрьевич");
            Assert.IsFalse(persons.Compare(1, 2));
        }
    }
}
