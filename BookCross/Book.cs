using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCross
{
    public class Book
    {
        string id;
        string author;
        string name;
        int year;
        int[] allIdPlaces;
        int idReader;

        public void Publish(string myName, string myAuthor, string year)
        {
            
        }

        public bool GetStatus()
        {
            return false;
        }

        public int GetIdReader()
        {
            return -1;
        }

        public void Take(int newId)
        {

        }

        public bool Compare()
        {
            return false;
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
