namespace BookCross
{
    public class BookPresenter
    {
        BookForm _addBookForm;
        Books _allBooks;

        public BookPresenter(Books myBooks)
        {
            _addBookForm = new BookForm(this);
            _allBooks = myBooks;
            _addBookForm.ShowDialog();
        }

        public void Add()
        {
            _allBooks.Publish(_addBookForm.author, _addBookForm.name, _addBookForm.year);
        }

        public Books Update()
        {
            return _allBooks;
        }
    }
}
