namespace ArPiGi
{
  /// <summary>
  /// Represents a skill that an entity can learn.
  /// </summary>
  public class Skill
  {
    string _name;
    string _description;
    int _mpCost;

    /// <summary>
    /// Gets/sets the name of this skill.
    /// </summary>
    public string Name
    {
      get { return _name; }
      private set { _name = value; }
    }

    /// <summary>
    /// Gets/sets the description of this skill.
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