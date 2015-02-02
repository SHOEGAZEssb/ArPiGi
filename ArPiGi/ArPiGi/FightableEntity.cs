using System.Drawing;

namespace ArPiGi
{
  /// <summary>
  /// Represents an entity that can fight and can be fought.
  /// </summary>
  public abstract class FightableEntity : EntityBase
  {
    private int _level;
    private int _hp;
    private int _mp;
    private int _strength;
    private int _defense;
    private int _speed;
    private Skill[] _skills;

    public int Level
    {
      get { return _level; }
      private set { _level = value; }
    }

    public int HP
    {
      get { return _hp; }
      private set { _hp = value; }
    }

    public int MP
    {
      get { return _mp; }
      private set { _mp = value; }
    }

    public int Strength
    {
      get { return _strength; }
      private set { _strength = value; }
    }

    public int Defense
    {
      get { return _defense; }
      private set { _defense = value; }
    }

    public int Speed
    {
      get { return _speed; }
      private set { _speed = value; }
    }

    public Skill[] Skills
    {
      get { return _skills; }
      private set { _skills = value; }
    }

    public FightableEntity(int level, int hp, int mp, int strength, int defense, int speed, Skill[] skills, string name, Image[] sprites)
      : base(name, sprites)
    {
      Level = level;
      HP = hp;
      MP = mp;
      Strength = strength;
      Defense = defense;
      Speed = speed;
      Skills = skills;
    }
  }
}