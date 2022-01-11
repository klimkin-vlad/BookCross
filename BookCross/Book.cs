using System;
using System.Collections.Generic;

namespace BookCross
{
    public class Book
    {
        string author;
        string name;
        string year;
        List<int> allIdPlaces;
        int idReader;

        public void Publish(string myAuthor, string myName, string myYear)
        {
            author = myAuthor;
            name = myName;
            year = myYear;
            allIdPlaces = new List<int>();
            idReader = -1;
        }

        public bool GetStatus()
        {
            if (idReader >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetIdReader()
        {
            return idReader;
        }

        public void Take(int newId, int idPlace)
        {
            idReader = newId;
            allIdPlaces.Add(idPlace);
        }

        public bool Compare(Book toCompare)
        {
            if (toCompare.GetName() != GetName())
            {
                return false;
            }
            else if (toCompare.GetAuthor() != GetAuthor())
            {
                return false;
            }
            else if (toCompare.GetYear() != GetYear())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetName()
        {
            return name;
        }

        public string GetYear()
        {
            return year.ToString();
        }
    }
}
