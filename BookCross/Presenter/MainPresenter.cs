using System.Collections.Generic;

namespace BookCross
{
    public class MainPresenter
    {
        MainForm _tableForm;
        Readers _allReaders;
        Books _allBooks;
        Places _allPlaces;

        int chooser;

        public MainPresenter()
        {
            _tableForm = new MainForm(this);
            _allBooks = new Books();
            _allPlaces = new Places();
            _allReaders = new Readers();
            chooser = 0;
        }

        public MainForm GetMainForm()
        {
            return _tableForm;
        }

        public void ChangeModeToBook()
        {
            List<List<string>> rows = new List<List<string>>();
            List<string> row = new List<string>();
            List<string> headers = new List<string>
            {
                "№", "Автор", "Название", "Год", "Статус"
            };
            chooser = 1;
            int index = 1;
            int end = _allBooks.Count();
            while (index <= end)
            {
                row = _allBooks.GetAll(index);
                index += 1;
                rows.Add(row);
            }
            FillTable(rows, headers);
        }

        public void ChangeModeToPlace()
        {
            List<List<string>> rows = new List<List<string>>();
            List<string> row = new List<string>();
            List<string> headers = new List<string>
            {
                "№", "Место получения", "Место сдачи"
            };
            chooser = 2;
            int index = 1;
            int end = _allPlaces.Count();
            while (index <= end)
            {
                row = _allPlaces.GetAll(index);
                index += 1;
                rows.Add(row);
            }
            FillTable(rows, headers);
        }

        public void ChangeModeToReader()
        {
            List<List<string>> rows = new List<List<string>>();
            List<string> row = new List<string>();
            List<string> headers = new List<string>
            {
                "№", "ФИО"
            };
            chooser = 3;
            int index = 1;
            int end = _allReaders.Count();
            while (index <= end)
            {
                row = _allReaders.GetAll(index);
                index += 1;
                rows.Add(row);
            }
            FillTable(rows, headers);
        }

        public void FillTable(List<List<string>> rows, List<string> headers)
        {
            _tableForm.Clear();
            _tableForm.SetHeaders(headers);
            _tableForm.SetTableValues(rows);
        }

        public void Add(int dialog)
        {
            switch (chooser)
            {
                case 1:
                    BookPresenter books = new BookPresenter(_allBooks);
                    _allBooks = books.Update();
                    ChangeModeToBook();
                    break;
                case 2:
                    PlacePresenter places = new PlacePresenter(_allPlaces);
                    _allPlaces = places.Update();
                    ChangeModeToPlace();
                    break;
                case 3:
                    ReaderPresenter readers = new ReaderPresenter(_allReaders);
                    _allReaders = readers.Update();
                    ChangeModeToReader();
                    break;
                default:
                    break;
            }
            ChangeMode();
        }

        public void ChangeMode()
        {
            switch (chooser)
            {
                case 1:
                    ChangeModeToBook();
                    break;
                case 2:
                    ChangeModeToPlace();
                    break;
                case 3:
                    ChangeModeToReader();
                    break;
                default:
                    break;
            }
        }

        public void Take(int dialog)
        {
            List<string> current = _tableForm.GetCurrentRow();
            TakeBookPresenter taker = new TakeBookPresenter(_allBooks, _allPlaces, _allReaders);
            taker.Fill(current[1], current[2], current[3]);
            _allBooks = taker.UpdateBooks();
            _allPlaces = taker.UpdatePlaces();
            _allReaders = taker.UpdateReaders();
            ChangeMode();
        }
    }
}
