using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCross
{
    public class Place
    {
        int id;
        string departure;
        string arrival;

        public void Add(int myId, string myDeparture, string myArrvial)
        {
            id = myId;
            departure = myDeparture;
            arrival = myArrvial;
        }

        public string GetDeparture()
        {
            return departure;
        }

        public string GetArrival()
        {
            return arrival;
        }

        public bool Compare(int myId)
        {
            if (id == myId)
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
