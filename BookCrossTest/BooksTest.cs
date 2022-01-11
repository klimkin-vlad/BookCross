using NUnit.Framework;
using BookCross;
using System.Collections.Generic;

namespace BookCrossTest
{
    [TestFixture]
    public class BooksTest
    {
        [Test]
        public void PublishAll()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            List<string> bookData = allBooks.GetAll(1);
            Assert.AreEqual(bookData[0], "1");
            Assert.AreEqual(bookData[1], "Л. Н. Толстой");
            Assert.AreEqual(bookData[2], "Анна Каренина");
            Assert.AreEqual(bookData[3], "1877");
        }

        [Test]
        public void PublishNoYear()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "");
            List<string> bookData = allBooks.GetAll(1);
            Assert.AreEqual(bookData[0], "1");
            Assert.AreEqual(bookData[1], "Л. Н. Толстой");
            Assert.AreEqual(bookData[2], "Анна Каренина");
            Assert.AreEqual(bookData[3], "");
        }

        public void PublishNoAuthor()
        {
            Books allBooks = new Books();
            allBooks.Publish("", "Анна Каренина", "1877");
            List<string> bookData = allBooks.GetAll(1);
            Assert.AreEqual(bookData[0], "1");
            Assert.AreEqual(bookData[1], "");
            Assert.AreEqual(bookData[2], "Анна Каренина");
            Assert.AreEqual(bookData[3], "1877");
        }

        public void PublishOnlyName()
        {
            Books allBooks = new Books();
            allBooks.Publish("", "Анна Каренина", "");
            List<string> bookData = allBooks.GetAll(1);
            Assert.AreEqual(bookData[0], "1");
            Assert.AreEqual(bookData[1], "");
            Assert.AreEqual(bookData[2], "Анна Каренина");
            Assert.AreEqual(bookData[3], "");
        }

        [Test]
        public void GetStatusTrue()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            allBooks.Take(1, 1, 1);
            Assert.IsTrue(allBooks.GetStatus(1));
        }

        [Test]
        public void GetStatusFalse()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            Assert.IsFalse(allBooks.GetStatus(1));
        }

        [Test]
        public void GetReaderTrue()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            allBooks.Take(1, 1, 1);
            Assert.AreEqual(allBooks.GetIdReader(1), 1);
        }

        public void GetReaderFalse()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            Assert.AreEqual(allBooks.GetIdReader(1), -1);
        }

        [Test]
        public void CompareSame()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            Assert.IsTrue(allBooks.Compare(1, 2));
        }

        [Test]
        public void CompareNoAuthor()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            allBooks.Publish("", "Анна Каренина", "1877");
            Assert.IsFalse(allBooks.Compare(1, 2));
        }

        [Test]
        public void CompareNoName()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            allBooks.Publish("Л. Н. Толстой", "", "1877");
            Assert.IsFalse(allBooks.Compare(1, 2));
        }

        [Test]
        public void CompareNoYear()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "");
            Assert.IsFalse(allBooks.Compare(1, 2));
        }

        [Test]
        public void CompareOnlyName()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            allBooks.Publish("", "Анна Каренина", "");
            Assert.IsFalse(allBooks.Compare(1, 2));
        }

        [Test]
        public void CompareOnlyAuthor()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            allBooks.Publish("Л. Н. Толстой", "", "");
            Assert.IsFalse(allBooks.Compare(1, 2));
        }

        [Test]
        public void CompareOnlyYear()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            allBooks.Publish("", "", "1877");
            Assert.IsFalse(allBooks.Compare(1, 2));
        }

        [Test]
        public void GetAuthor()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            Assert.AreEqual(allBooks.GetAuthor(1), "Л. Н. Толстой");
        }

        [Test]
        public void GetName()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            Assert.AreEqual(allBooks.GetName(1), "Анна Каренина");
        }

        [Test]
        public void GetYear()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            Assert.AreEqual(allBooks.GetYear(1), "1877");
        }

        [Test]
        public void SearchByAuthor()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            allBooks.Publish("Л. Н. Толстой", "Война и мир", "1873");
            List<int> allIds = allBooks.SearchByAuthor("Л. Н. Толстой");
            Assert.AreEqual(allIds[0], 1);
            Assert.AreEqual(allIds[1], 2);
        }

        [Test]
        public void SearchByName()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            allBooks.Publish("Л. Н. Толстой", "Война и мир", "1873");
            List<int> allIds = allBooks.SearchByName("Анна Каренина");
            Assert.AreEqual(allIds[0], 1);
        }

        [Test]
        public void SearchByYear()
        {
            Books allBooks = new Books();
            allBooks.Publish("Л. Н. Толстой", "Анна Каренина", "1877");
            allBooks.Publish("Л. Н. Толстой", "Война и мир", "1873");
            List<int> allIds = allBooks.SearchByYear("1877");
            Assert.AreEqual(allIds[0], 1);
        }
    }
}
