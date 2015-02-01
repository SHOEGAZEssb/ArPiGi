using System.Drawing;

namespace ArPiGi
{
  /// <summary>
  /// Represents the player.
  /// </summary>
  class Player : FightableEntity
  {
    private int _xp;
    private Point _location;

    /// <summary>
    /// Gets/sets a the experience points of this player.
    /// </summary>
    public int XP
    {
      get { return _xp; }
      private set { _xp = value; }
    }

    /// <summary>
    /// Gets/sets the location of this player.
    /// </summary>
    public Point Location
    {
      get { return _location; }
      private set { _location = value; }
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    public Player(int hp, int mp, int strength, int defense, int speed, Skill[] skills, string name, Image[] sprites)
      : base(1, hp, mp, strength, defense, speed, skills, name, sprites)
    {   
      XP = 0;
    }
  }
}