namespace ArPiGi
{
  //Represents the skills that every player can learn
  class Skill
  {
    string _name;
    string _description;
    int _mpCost;

    /// <summary>
    /// Gets/Sets the skills name
    /// </summary>
    public string Name
    {
      get { return _name; }
      private set { _name = value; }
    }

    /// <summary>
    /// Gets/Sets the skills description
    /// </summary>
    public string Description
    {
      get { return _description; }
      private set { _description = value; }
    }

    /// <summary>
    /// Gets/Sets a skills manapower costs
    /// </summary>
    public int MpCost
    {
      get { return _mpCost; }
      private set { _mpCost = value; }
    }
  }
}