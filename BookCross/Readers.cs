using System.Collections.Generic;

namespace BookCross
{
    public class Readers
    {
        List<Reader> allReaders;

        public Readers()
        {
            allReaders = new List<Reader>();
        }

        public void Add(int id, string name)
        {
            Reader current = new Reader();
            current.Add(id, name);
            allReaders.Add(current);
        }

        public string GetName(int id)
        {
            return allReaders[id - 1].GetName();
        }

        public bool Compare(int first, int second)
        {
            Reader compared = allReaders[first - 1];
            Reader toCompare = allReaders[second - 1];
            return compared.Compare(toCompare);
        }

        public int Count()
        {
            return allReaders.Count;
        }
    }
}
