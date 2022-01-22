namespace BookCross
{
    public class ReaderPresenter
    {
        ReaderForm _addReaderForm;
        Readers _allReaders;

        public ReaderPresenter(Readers myReaders)
        {
            _addReaderForm = new ReaderForm(this);
            _allReaders = myReaders;
            _addReaderForm.ShowDialog();
        }

        public void Add()
        {
            _allReaders.Add(_addReaderForm.name);
        }

        public Readers Update()
        {
            return _allReaders;
        }
    }
}
