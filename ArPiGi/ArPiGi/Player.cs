using System.Drawing;
using System.Windows.Forms;

namespace ArPiGi
{
  /// <summary>
  /// Represents the player.
  /// </summary>
  public class Player : FightableEntity
  {
    private int _xp;
    private int _gold;

    /// <summary>
    /// Gets/sets a the experience points of this player.
    /// </summary>
    public int XP
    {
      get { return _xp; }
      private set { _xp = value; }
    }

    public int Gold
    {
      get { return _gold; }
      private set { _gold = value; }
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    public Player(int hp, int mp, int strength, int defense, int speed, Skill[] skills, string name, Image[] sprites)
      : base(1, hp, mp, strength, defense, speed, skills, name, sprites)
    {   
      XP = 0;
      Gold = 0;
    }
  }
}