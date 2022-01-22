namespace BookCross
{
    public class PlacePresenter
    {
        PlaceForm _addPlaceForm;
        Places _allPlaces;

        public PlacePresenter(Places myPlaces)
        {
            _addPlaceForm = new PlaceForm(this);
            _allPlaces = myPlaces;
            _addPlaceForm.ShowDialog();
        }

        public void Add()
        {
            _allPlaces.Add(_addPlaceForm.departure, _addPlaceForm.arrival);
        }

        public Places Update()
        {
            return _allPlaces;
        }
    }
}
