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
