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

        public void Publish(int myId, string myAuthor, string myName, string myYear)
        {

        }

        public bool GetStatus(int myId)
        {
            return false;
        }

        public int GetIdReader(int myId)
        {
            return -1;
        }

        public void Take(int idBook, int idReader, int idPlace)
        {

        }

        public bool Compare(int first, int second)
        {
            return false;
        }

        public string GetAuthor(int myId)
        {
            return "";
        }

        public string GetName(int myId)
        {
            return "";
        }

        public string GetYear(int myId)
        {
            return "";
        }

        public List<string> GetAll(int myId)
        {
            List<string> dataBook = new List<string>();
            return dataBook;
        }

        public List<int> SearchByAuthor(string myAuthor)
        {
            List<int> ids = new List<int>();
            return ids;
        }

        public List<int> SearchByName(string myName)
        {
            List<int> ids = new List<int>();
            return ids;
        }

        public List<int> SearchByYear(string myYear)
        {
            List<int> ids = new List<int>();
            return ids;
        }
    }
}
