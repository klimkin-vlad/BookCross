using NUnit.Framework;
using BookCross;

namespace BookCrossTest
{
    [TestFixture]
    public class ReaderTest
    {
        [Test]
        public void Add()
        {
            Reader person = new Reader();
            person.Add(1, "Климкин Владислав Юрьевич");
            Assert.AreEqual(person.GetName(), "Климкин Владислав Юрьевич");
        }

        [Test]
        public void CompareSame()
        {
            Reader person = new Reader();
            person.Add(1, "Климкин Владислав Юрьевич");
            Assert.IsTrue(person.Compare(1));
        }

        [Test]
        public void CompareNotSame()
        {
            Reader person = new Reader();
            person.Add(1, "Климкин Владислав Юрьевич");
            Reader person1 = new Reader();
            person1.Add(2, "Климкин Влад Юрьевич");
            Assert.IsFalse(person.Compare(2));
        }
    }
}
