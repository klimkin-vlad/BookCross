using NUnit.Framework;
using BookCross;

namespace BookCrossTest
{
    [TestFixture]
    public class BookTest
    {
        [Test]
        public void PublishAll()
        {
            Book toTest = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            Assert.Equals(toTest.GetAuthor(), "Л. Н. Толстой");
            Assert.Equals(toTest.GetName(), "Анна Каренина");
            Assert.Equals(toTest.GetYear(), "1877");
        }

        [Test]
        public void PublishNoYear()
        {
            Book toTest = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "");
            Assert.Equals(toTest.GetAuthor(), "Л. Н. Толстой");
            Assert.Equals(toTest.GetName(), "Анна Каренина");
            Assert.Equals(toTest.GetYear(), "");
        }

        [Test]
        public void PublishNoAuthor()
        {
            Book toTest = new Book();
            toTest.Publish("Л. Н. Толстой", "", "");
            Assert.Equals(toTest.GetAuthor(), "");
            Assert.Equals(toTest.GetName(), "Анна Каренина");
            Assert.Equals(toTest.GetYear(), "1877");
        }

        [Test]
        public void PublishOnlyName()
        {
            Book toTest = new Book();
            toTest.Publish("", "Анна Каренина", "");
            Assert.Equals(toTest.GetAuthor(), "");
            Assert.Equals(toTest.GetName(), "Анна Каренина");
            Assert.Equals(toTest.GetYear(), "");
        }

        [Test]
        public void GetStatusTrue()
        {
            Book toTest = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            toTest.Take(1);
            Assert.IsTrue(toTest.GetStatus());
        }

        public void GetStatusFalse()
        {
            Book toTest = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            Assert.IsFalse(toTest.GetStatus());
        }

        [Test]
        public void GetReaderTrue()
        {
            Book toTest = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            toTest.Take(1);
            Assert.Equals(toTest.GetIdReader(), 1);
        }

        public void GetReaderFalse()
        {
            Book toTest = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            Assert.Equals(toTest.GetIdReader(), -1);
        }

        [Test]
        public void CompareSame()
        {
            Book toTest = new Book();
            Book toTest1 = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            toTest1.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            Assert.IsTrue(toTest.Compare());
        }

        [Test]
        public void CompareNoAuthor()
        {
            Book toTest = new Book();
            Book toTest1 = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            toTest1.Publish("", "Анна Каренина", "1877");
            Assert.IsFalse(toTest.Compare());
        }

        [Test]
        public void CompareNoName()
        {
            Book toTest = new Book();
            Book toTest1 = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            toTest1.Publish("Л. Н. Толстой", "", "1877");
            Assert.IsFalse(toTest.Compare());
        }

        [Test]
        public void CompareNoYear()
        {
            Book toTest = new Book();
            Book toTest1 = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            toTest1.Publish("Л. Н. Толстой", "Анна Каренина", "");
            Assert.IsFalse(toTest.Compare());
        }

        [Test]
        public void CompareOnlyName()
        {
            Book toTest = new Book();
            Book toTest1 = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            toTest1.Publish("", "Анна Каренина", "");
            Assert.IsFalse(toTest.Compare());
        }

        [Test]
        public void CompareOnlyAuthor()
        {
            Book toTest = new Book();
            Book toTest1 = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            toTest1.Publish("Л. Н. Толстой", "", "");
            Assert.IsFalse(toTest.Compare());
        }

        [Test]
        public void CompareOnlyYear()
        {
            Book toTest = new Book();
            Book toTest1 = new Book();
            toTest.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            toTest1.Publish("", "", "1877");
            Assert.IsFalse(toTest.Compare());
        }
    }
}
