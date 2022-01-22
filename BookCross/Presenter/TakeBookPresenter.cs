using System;
using System.Collections.Generic;
using System.Linq;

namespace BookCross
{
    public class TakeBookPresenter
    {
        TakeBookForm _takeForm;
        Readers _allReaders;
        Books _allBooks;
        Places _allPlaces;

        public TakeBookPresenter(Books myBooks, Places myPlaces, Readers myReaders)
        {
            _takeForm = new TakeBookForm(this);
            _allBooks = myBooks;
            _allPlaces = myPlaces;
            _allReaders = myReaders;
        }

        public void Fill(string author, string name, string year)
        {
            _takeForm.author = author;
            _takeForm.bookName = name;
            _takeForm.year = year;
            ShowPlaces();
            ShowReaders();
            _takeForm.ShowDialog();
        }

        public string CombineStringFromList(List<string> values)
        {
            string line = "";
            foreach (string value in values)
            {
                line += value + ", ";
            }
            line.Remove(line.Count() - 1, 1);
            return line;
        }

        public void ShowPlaces()
        {
            int index = 1;
            int end = _allPlaces.Count();
            string toShow;
            while (index <= end)
            {
                toShow = CombineStringFromList(_allPlaces.GetAll(index));
                _takeForm.AddPlace(toShow);
                index += 1;
            }
        }

        public void ShowReaders()
        {
            int index = 1;
            int end = _allReaders.Count();
            string toShow;
            while (index <= end)
            {
                toShow = CombineStringFromList(_allReaders.GetAll(index));
                _takeForm.AddReader(toShow);
                index += 1;
            }
        }

        public void Take()
        {
            int idBook = _allBooks.Search(_takeForm.author, _takeForm.bookName, _takeForm.year);
            string place = _takeForm.place;
            string reader = _takeForm.reader;
            int idPlace = GetID(Split(place));
            int idReader = GetID(Split(reader));
            _allBooks.Take(idBook, idReader, idPlace);
        }

        public List<string> Split(string toSplit)
        {
            List<string> splitted = toSplit.Split(',').ToList();
            return splitted;
        }

        public int GetID(List<string> data)
        {
            return Convert.ToInt32(data[0]);
        }

        public Books UpdateBooks()
        {
            return _allBooks;
        }

        public Places UpdatePlaces()
        {
            return _allPlaces;
        }

        public Readers UpdateReaders()
        {
            return _allReaders;
        }
    }
}
