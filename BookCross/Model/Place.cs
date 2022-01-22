namespace BookCross
{
    public class Place
    {
        string _departure;
        string _arrival;

        public void Add(string myDeparture, string myArrvial)
        {
            _departure = myDeparture;
            _arrival = myArrvial;
        }

        public string GetDeparture()
        {
            return _departure;
        }

        public string GetArrival()
        {
            return _arrival;
        }

        public bool Compare(Place toCompare)
        {
            if ((_departure == toCompare._departure) && (_arrival == toCompare._arrival))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
