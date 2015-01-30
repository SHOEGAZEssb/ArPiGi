namespace ArPiGi
{
  class Skill
  {
    string _name;
    string _description;
    int _mpCost;

    public string Name
    {
      get { return _name; }
      private set { _name = value; }
    }

    public string Description
    {
      get { return _description; }
      private set { _description = value; }
    }

    public int MpCost
    {
      get { return _mpCost; }
      private set { _mpCost = value; }
    }
  }
}
