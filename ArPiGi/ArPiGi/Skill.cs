namespace ArPiGi
{
  class Skill
  {
    string _name;
    string _description;
    int _mpCosts;

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

    public int MpCosts
    {
      get { return _mpCosts; }
      set { _mpCosts = value; }
    }
  }
}
