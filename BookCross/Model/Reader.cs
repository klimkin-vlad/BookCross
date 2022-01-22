namespace BookCross
{
    public class Reader
    {
        string _name;

        public void Add(string myName)
        {
            _name = myName;
        }

        public string GetName()
        {
            return _name;
        }

        public bool Compare(Reader toCompare)
        {
            if (_name == toCompare._name)
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
