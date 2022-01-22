using System;
using System.Collections.Generic;

namespace BookCross
{
    public class Book
    {
        string _author;
        string _name;
        string _year;
        List<int> _allIdPlaces;
        int _idReader;

        public void Publish(string myAuthor, string myName, string myYear)
        {
            _author = myAuthor;
            _name = myName;
            _year = myYear;
            _allIdPlaces = new List<int>();
            _idReader = -1;
        }

        public bool GetStatus()
        {
            if (_idReader >= 0)
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
            return _idReader;
        }

        public void Take(int newId, int idPlace)
        {
            _idReader = newId;
            _allIdPlaces.Add(idPlace);
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
            return _author;
        }

        public string GetName()
        {
            return _name;
        }

        public string GetYear()
        {
            return _year;
        }
    }
}
