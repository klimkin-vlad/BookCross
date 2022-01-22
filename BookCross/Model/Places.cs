using System.Collections.Generic;

namespace BookCross
{
    public class Places
    {
        List<Place> allPlaces;

        public Places()
        {
            allPlaces = new List<Place>();
        }

        public void Add(string departure, string arrival)
        {
            Place current = new Place();
            current.Add(departure, arrival);
            allPlaces.Add(current);
        }

        public List<string> GetAll(int id)
        {
            List<string> dataPlace = new List<string>();
            Place current = allPlaces[id - 1];
            dataPlace.Add(id.ToString());
            dataPlace.Add(current.GetDeparture());
            dataPlace.Add(current.GetArrival());
            return dataPlace;
        }

        public string GetDeparture(int id)
        {
            return allPlaces[id - 1].GetDeparture();
        }

        public string GetArrival(int id)
        {
            return allPlaces[id - 1].GetArrival();
        }

        public bool Compare(int first, int second)
        {
            Place compared = allPlaces[first - 1];
            Place toCompare = allPlaces[second - 1];
            return compared.Compare(toCompare);
        }

        public int Count()
        {
            return allPlaces.Count;
        }
    }
}
