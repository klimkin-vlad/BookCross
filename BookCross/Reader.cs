namespace BookCross
{
    public class Reader
    {
        int id;
        string name;

        public void Add(int myId, string myName)
        {
            id = myId;
            name = myName;
        }

        public string GetName()
        {
            return name;
        }

        public bool Compare(Reader toCompare)
        {
            if (name == toCompare.name)
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
