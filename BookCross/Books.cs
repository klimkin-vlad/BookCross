using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCross
{
    public class Books
    {
        List<Book> allBooks;

        public Books()
        {
            allBooks = new List<Book>();
        }

        public void Publish(string myAuthor, string myName, string myYear)
        {
            Book current = new Book();
            current.Publish(myAuthor, myName, myYear);
            allBooks.Add(current);
        }

        public bool GetStatus(int index)
        {
            return allBooks[index - 1].GetStatus();
        }

        public int GetIdReader(int index)
        {
            return allBooks[index - 1].GetIdReader();
        }

        public void Take(int index, int idReader, int idPlace)
        {
            allBooks[index - 1].Take(idReader, idPlace);
        }

        public bool Compare(int first, int second)
        {
            Book toCompare = allBooks[second - 1];
            return allBooks[first - 1].Compare(toCompare);
        }

        public string GetAuthor(int index)
        {
            return allBooks[index - 1].GetAuthor();
        }

        public string GetName(int index)
        {
            return allBooks[index - 1].GetName();
        }

        public string GetYear(int index)
        {
            return allBooks[index - 1].GetYear();
        }

        public List<string> GetAll(int index)
        {
            List<string> dataBook = new List<string>();
            Book current = allBooks[index - 1];
            dataBook.Add(index.ToString());
            dataBook.Add(current.GetAuthor());
            dataBook.Add(current.GetName());
            dataBook.Add(current.GetYear());
            return dataBook;
        }

        public List<int> SearchByAuthor(string myAuthor)
        {
            List<int> ids = new List<int>();
            string toCompare;
            int index = 1;
            foreach (Book current in allBooks)
            {
                toCompare = current.GetAuthor();
                if (myAuthor == toCompare)
                {
                    ids.Add(index);
                }
                index += 1;
            }
            return ids;
        }

        public List<int> SearchByName(string myName)
        {
            List<int> ids = new List<int>();
            string toCompare;
            int index = 1;
            foreach (Book current in allBooks)
            {
                toCompare = current.GetName();
                if (myName == toCompare)
                {
                    ids.Add(index);
                }
                index += 1;
            }
            return ids;
        }

        public List<int> SearchByYear(string myYear)
        {
            List<int> ids = new List<int>();
            string toCompare;
            int index = 1;
            foreach (Book current in allBooks)
            {
                toCompare = current.GetYear();
                if (myYear == toCompare)
                {
                    ids.Add(index);
                }
                index += 1;
            }
            return ids;
        }
    }
}
