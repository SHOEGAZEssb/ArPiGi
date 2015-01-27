using System.Drawing;

namespace ArPiGi
{
  class Player : FightableEntity
  {
    private int _xp;
    private Point _location;

    public int XP
    {
      get { return _xp; }
      private set { _xp = value; }
    }

    public Point Location
    {
      get { return _location; }
      private set { _location = value; }
    }

    public Player(int level, int hp, int mp, int strength, int defense, int speed, Skill[] skills, string name, Image[] sprites)
      : base(level, hp, mp, strength, defense, speed, skills, name, sprites)
    {
      XP = 0;
    }
  }
}