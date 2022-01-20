using NUnit.Framework;
using BookCross;

namespace BookCrossTest
{
    [TestFixture]
    public class ReadersTest
    {
        [Test]
        public void Add()
        {
            Readers persons = new Readers();
            persons.Add(1, "Климкин Владислав Юрьевич");
            Assert.AreEqual(persons.GetName(1), "Климкин Владислав Юрьевич");
        }

        [Test]
        public void CompareSame()
        {
            Readers persons = new Readers();
            persons.Add(1, "Климкин Владислав Юрьевич");
            persons.Add(2, "Климкин Владислав Юрьевич");
            Assert.IsTrue(persons.Compare(1, 2));
        }

        [Test]
        public void CompareNotSame()
        {
            Readers persons = new Readers();
            persons.Add(1, "Климкин Владислав Юрьевич");
            persons.Add(2, "Климкин Влад Юрьевич");
            Assert.IsFalse(persons.Compare(1, 2));
        }
    }
}
